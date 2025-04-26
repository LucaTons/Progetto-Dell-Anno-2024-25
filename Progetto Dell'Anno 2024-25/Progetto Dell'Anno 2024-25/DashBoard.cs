using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        private List<Spesa> listaSpese = new List<Spesa>();
        private Dictionary<int, decimal> budgetMensilePerMese = new Dictionary<int, decimal>();
        private decimal budgetMensile;
        private decimal speseMensili = 0;
        string connStr = "server=localhost;database=guardian_of_the_money;user=Luca_Tons;password=spese@2025;";

        public DashBoard()
        {
            InitializeComponent();
            InizializzaComboBox();
            ImpostaControlli();
            InizializzaListView();
            CaricaSpeseDalDatabase();
            CaricaBudgetDalDatabase();
            GeneraReportAnnuale();
        }

        #region BOTTONE AGGIUNGI SPESA
        private void button_AggiungiSpesa_Click(object sender, EventArgs e)
        {
            if (ComboBox_Categoria.SelectedItem == null || textBox_Prezzo.Text == "")
            {
                MessageBox.Show("Compila tutti i campi!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!textBox_Prezzo.Text.All(c => char.IsDigit(c) || c == ',' || c == '.'))
            {
                MessageBox.Show("Inserisci solo numeri validi nel campo prezzo!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal importo = Convert.ToDecimal(textBox_Prezzo.Text.Replace(".", ","));
            DateTime dataInserita = DataTimePicker_Data.Value;
            int meseInserito = dataInserita.Month;
            int annoInserito = dataInserita.Year;
            if (!budgetMensilePerMese.ContainsKey(meseInserito) && !budgetMensilePerMese.ContainsKey(annoInserito))
            {
                MessageBox.Show($"Non hai impostato il budget per il mese {dataInserita.ToString("MMMM")}!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PulisciCampi();
                return;
            }
            budgetMensile = budgetMensilePerMese[meseInserito];
            if (speseMensili + importo > budgetMensile)
            {
                MessageBox.Show("Hai superato il budget mensile!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            speseMensili += importo;
            Spesa nuovaSpesa = new Spesa
            {
                Categoria = ComboBox_Categoria.SelectedItem.ToString(),
                Importo = importo,
                Data = dataInserita
            };
            MessageBox.Show("Spesa aggiunta con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listaSpese.Add(nuovaSpesa);
            SalvaSpesaNelDatabase(nuovaSpesa);
            AggiornaTabella();
            AggiornaBudgetLabel();
            GeneraReportAnnuale();
            PulisciCampi();
        }
        #endregion

        #region BOTTONE MODIFICA SPESA
        private void button_ModificaSpesa_Click(object sender, EventArgs e)
        {
            if (Visualizza_Spese.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una spesa da modificare!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int indice = Visualizza_Spese.SelectedItems[0].Index;
            Spesa spesaDaModificare = listaSpese[indice];
            if (string.IsNullOrEmpty(comboBox_Categorie.Text) || string.IsNullOrEmpty(textBox_Importo.Text))
            {
                MessageBox.Show("Compila tutti i campi!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal nuovoImporto;
            if (!decimal.TryParse(textBox_Importo.Text.Replace(".", ","), out nuovoImporto))
            {
                MessageBox.Show("Importo non valido!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "UPDATE gestore_spese SET categoria = @categoria, importo = @importo, data = @data WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoria", comboBox_Categorie.Text);
                    cmd.Parameters.AddWithValue("@importo", nuovoImporto);
                    cmd.Parameters.AddWithValue("@data", dateTimePicker_Data.Value);
                    cmd.Parameters.AddWithValue("@id", spesaDaModificare.Id);
                    conn.Open();
                    int righeModificate = cmd.ExecuteNonQuery();
                    if (righeModificate > 0)
                    {
                        speseMensili -= spesaDaModificare.Importo;
                        spesaDaModificare.Categoria = comboBox_Categorie.Text;
                        spesaDaModificare.Importo = nuovoImporto;
                        spesaDaModificare.Data = dateTimePicker_Data.Value;
                        speseMensili += nuovoImporto;
                        AggiornaTabella();
                        PulisciCampi();
                        AggiornaBudgetLabel();
                        GeneraReportAnnuale();
                        MessageBox.Show("Spesa modificata con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Errore durante la modifica", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region BOTTONE ELIMINA SPESA
        private void button_EliminaSpesa_Click(object sender, EventArgs e)
        {
            if (Visualizza_Spese.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una spesa da eliminare", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int indice = Visualizza_Spese.SelectedItems[0].Index;
            Spesa spesaDaEliminare = listaSpese[indice];
            DialogResult risultato = MessageBox.Show("Sei sicuro di voler eliminare questa spesa?", "CONFERMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (risultato == DialogResult.No)
                return;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM gestore_spese WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", spesaDaEliminare.Id);
                    conn.Open();
                    int righeEliminate = cmd.ExecuteNonQuery();
                    if (righeEliminate > 0)
                    {
                        listaSpese.RemoveAt(indice);
                        speseMensili -= spesaDaEliminare.Importo;
                        AggiornaTabella();
                        AggiornaBudgetLabel();
                        PulisciCampi();
                        GeneraReportAnnuale();
                        using (var cmdCount = new MySqlCommand("SELECT COUNT(*) FROM gestore_spese", conn))
                        {
                            int count = Convert.ToInt32(cmdCount.ExecuteScalar());
                            if (count == 0)
                            {
                                ResettaIdAutoIncrement();
                            }
                        }
                        MessageBox.Show("Spesa eliminata con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Errore durante l'eliminazione", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region BOTTONE ORDINA PER DATA
        private void button_OrdinaPerData_Click(object sender, EventArgs e)
        {
            listaSpese.Sort(ConfrontaDate);
            AggiornaTabella();
        }
        #endregion

        #region BOTTONE MODIFICA REPORT MENSILE
        private void button_ModificaReportMensile_Click(object sender, EventArgs e)
        {
            if (listView_ReportMensile.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una spesa da modificare!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idSpesa = (int)listView_ReportMensile.SelectedItems[0].Tag;

                if (string.IsNullOrEmpty(comboBox_CategorieReportMensile.Text) || string.IsNullOrEmpty(textBox_ReportMensile.Text))
                {
                    MessageBox.Show("Compila tutti i campi!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal nuovoImporto;
                if (!decimal.TryParse(textBox_ReportMensile.Text.Replace(".", ","), out nuovoImporto))
                {
                    MessageBox.Show("Importo non valido!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = @"UPDATE gestore_spese SET categoria = @categoria, importo = @importo, data = @data WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoria", comboBox_CategorieReportMensile.Text);
                        cmd.Parameters.AddWithValue("@importo", nuovoImporto);
                        cmd.Parameters.AddWithValue("@data", dateTimePicker_DataReportMensile.Value);
                        cmd.Parameters.AddWithValue("@id", idSpesa);
                        conn.Open();
                        int righeModificate = cmd.ExecuteNonQuery();
                        if (righeModificate > 0)
                        {
                            var spesaDaAggiornare = listaSpese.FirstOrDefault(s => s.Id == idSpesa);
                            if (spesaDaAggiornare != null)
                            {
                                speseMensili -= spesaDaAggiornare.Importo;
                                speseMensili += nuovoImporto;
                                spesaDaAggiornare.Categoria = comboBox_CategorieReportMensile.Text;
                                spesaDaAggiornare.Importo = nuovoImporto;
                                spesaDaAggiornare.Data = dateTimePicker_DataReportMensile.Value;
                            }
                            int meseSelezionato = comboBox_Mesi.SelectedIndex + 1;
                            int annoCorrente = DateTime.Now.Year;
                            CaricaSpeseMeseSelezionato(meseSelezionato, annoCorrente);
                            AggiornaTabella();
                            AggiornaBudgetLabel();
                            PulisciCampi();
                            GeneraReportAnnuale();
                            MessageBox.Show("Spesa modificata con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nessuna spesa modificata.", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la modifica: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BOTTONE ELIMINA REPORT MENSILE
        private void button_EliminaReportMensile_Click(object sender, EventArgs e)
        {
            if (listView_ReportMensile.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una spesa da eliminare", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idSpesa = (int)listView_ReportMensile.SelectedItems[0].Tag;

                DialogResult risultato = MessageBox.Show("Sei sicuro di voler eliminare questa spesa?", "CONFERMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (risultato == DialogResult.No)
                    return;
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM gestore_spese WHERE id = @id";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", idSpesa);
                        int righeEliminate = deleteCmd.ExecuteNonQuery();
                        if (righeEliminate > 0)
                        {
                            int meseSelezionato = comboBox_Mesi.SelectedIndex + 1;
                            int annoCorrente = DateTime.Now.Year;
                            CaricaSpeseMeseSelezionato(meseSelezionato, annoCorrente);
                            CaricaSpeseDalDatabase();
                            AggiornaTabella();
                            AggiornaBudgetLabel();
                            PulisciCampi();
                            GeneraReportAnnuale();
                            using (var cmdCount = new MySqlCommand("SELECT COUNT(*) FROM gestore_spese", conn))
                            {
                                int count = Convert.ToInt32(cmdCount.ExecuteScalar());
                                if (count == 0)
                                {
                                    ResettaIdAutoIncrement();
                                }
                            }
                            MessageBox.Show("Spesa eliminata con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'eliminazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BOTTONE SCARICA REPORT MENSILE
        private void button_ScaricaReportMensile_Click(object sender, EventArgs e)
        {
            if (comboBox_Mesi.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un mese!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int mese = comboBox_Mesi.SelectedIndex + 1;
            string nomeMese = comboBox_Mesi.SelectedItem.ToString();
            int annoCorrente = DateTime.Now.Year;
            decimal budgetMese = 0m;
            bool budgetImpostato = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string budgetQuery = @"SELECT importo FROM budget_mensili WHERE mese = @mese AND anno = @anno";
                using (MySqlCommand budgetCmd = new MySqlCommand(budgetQuery, conn))
                {
                    budgetCmd.Parameters.AddWithValue("@mese", mese);
                    budgetCmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    object result = budgetCmd.ExecuteScalar();
                    if (result != null)
                    {
                        budgetMese = Convert.ToDecimal(result);
                        budgetImpostato = true;
                    }
                    conn.Close();
                }
            }
            List<Spesa> speseMese = new List<Spesa>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"SELECT categoria, importo, data FROM gestore_spese WHERE MONTH(data) = @mese AND YEAR(data) = @anno ORDER BY data ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mese", mese);
                    cmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            speseMese.Add(new Spesa
                            {
                                Categoria = reader["categoria"].ToString(),
                                Importo = Convert.ToDecimal(reader["importo"]),
                                Data = Convert.ToDateTime(reader["data"])
                            });
                        }
                    }
                }
            }
            if (speseMese.Count == 0)
            {
                MessageBox.Show("In questo mese non hai speso nulla, seleziona un altro mese!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string percorsoProgetto = ("../../File");
            string percorsoFile = Path.Combine(percorsoProgetto, $"Report_{nomeMese}_{annoCorrente}.csv");
            using (StreamWriter sw = new StreamWriter(percorsoFile))
            {
                sw.WriteLine("Categoria,Importo,Data");
                foreach (var spesa in speseMese)
                {
                    sw.WriteLine($"{spesa.Categoria},{spesa.Importo},{spesa.Data:dd/MM/yyyy}");
                }
                sw.WriteLine();
                sw.WriteLine($"TOTALE SPESE: {speseMese.Sum(s => s.Importo)}");
                if (budgetImpostato)
                {
                    sw.WriteLine($"BUDGET MENSILE:{budgetMese}");
                    sw.WriteLine($"RIMANENZA/PERDITA: {budgetMese - speseMese.Sum(s => s.Importo)}");
                }
            }
            MessageBox.Show("Report salvato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region BOTTONE SCARICA REPORT ANNUALE
        private void button_ScaricaReportAnnuale_Click(object sender, EventArgs e)
        {
            int annoCorrente = DateTime.Now.Year;
            Dictionary<int, decimal> spesePerMese = new Dictionary<int, decimal>();
            Dictionary<int, decimal> budgetPerMese = new Dictionary<int, decimal>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"SELECT MONTH(data) AS mese, SUM(importo) AS totale FROM gestore_spese WHERE YEAR(data) = @anno GROUP BY MONTH(data)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mese = Convert.ToInt32(reader["mese"]);
                            decimal totale = Convert.ToDecimal(reader["totale"]);
                            spesePerMese[mese] = totale;
                        }
                    }
                }
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"SELECT mese, importo FROM budget_mensili WHERE anno = @anno";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mese = Convert.ToInt32(reader["mese"]);
                            decimal importo = Convert.ToDecimal(reader["importo"]);
                            budgetPerMese[mese] = importo;
                        }
                    }
                }
            }
            if (spesePerMese.Count == 0 && budgetPerMese.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile per generare il report annuale!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string percorsoProgetto = ("../../File");
            string percorsoFile = Path.Combine(percorsoProgetto, $"Report_Annuale_{annoCorrente}.csv");
            try
            {
                using (StreamWriter sw = new StreamWriter(percorsoFile))
                {
                    sw.WriteLine("Mese,Anno,Budget,Spese,Rimanenza/Perdita");
                    decimal speseTotaliAnno = 0;
                    decimal budgetTotaleAnno = 0;
                    for (int mese = 1; mese <= 12; mese++)
                    {
                        string nomeMese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mese);
                        decimal speseMese = spesePerMese.ContainsKey(mese) ? spesePerMese[mese] : 0;
                        decimal budgetMese = budgetPerMese.ContainsKey(mese) ? budgetPerMese[mese] : 0;
                        decimal saldoMese = budgetMese - speseMese;
                        sw.WriteLine($"{nomeMese},{annoCorrente},{budgetMese},{speseMese},{saldoMese}");
                        speseTotaliAnno += speseMese;
                        budgetTotaleAnno += budgetMese;
                    }
                    sw.WriteLine();
                    sw.WriteLine($"TOTALE ANNUALE: {speseTotaliAnno}");
                    sw.WriteLine($"TOTALE BUDGET ANNUALE: {budgetTotaleAnno}");
                    sw.WriteLine($"RIMANENZA/PERDITA: {budgetTotaleAnno - speseTotaliAnno}");
                }
                MessageBox.Show($"Report annuale {annoCorrente} salvato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il salvataggio del report: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BOTTONE IMPOSTA BUDGET
        private void button_ImpostaBudget_Click(object sender, EventArgs e)
        {
            if (comboBox_MesiBudget.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un mese!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_Budget.Text) || !textBox_Budget.Text.All(c => char.IsDigit(c) || c == ',' || c == '.'))
            {
                MessageBox.Show("Inserisci un numero valido!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Budget.Clear();
                return;
            }
            decimal nuovoBudget = Convert.ToDecimal(textBox_Budget.Text.Replace(".", ","));
            int meseSelezionato = comboBox_MesiBudget.SelectedIndex + 1;
            int annoCorrente = DateTime.Now.Year;
            SalvaBudgetNelDatabase(meseSelezionato, annoCorrente, nuovoBudget);
            decimal totaleSpeseMese = 0m;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sumQuery = @"SELECT IFNULL(SUM(importo), 0) FROM gestore_spese WHERE MONTH(data) = @mese AND YEAR(data) = @anno";
                using (MySqlCommand sumCmd = new MySqlCommand(sumQuery, conn))
                {
                    sumCmd.Parameters.AddWithValue("@mese", meseSelezionato);
                    sumCmd.Parameters.AddWithValue("@anno", annoCorrente);
                    totaleSpeseMese = Convert.ToDecimal(sumCmd.ExecuteScalar());
                }
            }
            budgetMensilePerMese[meseSelezionato] = nuovoBudget;
            if (meseSelezionato == DateTime.Now.Month)
            {
                budgetMensile = nuovoBudget;
                speseMensili = totaleSpeseMese;
            }
            AggiornaBudgetLabel();
            GeneraReportAnnuale();
            textBox_Budget.Clear();
            string nomeMese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(meseSelezionato);
            MessageBox.Show($"Budget per il mese di {nomeMese}: {nuovoBudget:C}\n" + $"Spese già registrate: {totaleSpeseMese:C}\n" + $"Saldo aggiornato: {(nuovoBudget - totaleSpeseMese):C}", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region INIZIALIZZA COMBOBOX
        private void InizializzaComboBox()
        {
            ComboBox_Categoria.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
            comboBox_Categorie.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
            comboBox_Mesi.Items.AddRange(new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" });
            comboBox_MesiBudget.Items.AddRange(new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" });
            comboBox_CategorieReportMensile.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
        }
        #endregion

        #region INIZIALIZZA LISTVIEW
        private void InizializzaListView()
        {
            Visualizza_Spese.View = View.Details;
            Visualizza_Spese.Columns.Add("Categoria", 100);
            Visualizza_Spese.Columns.Add("Importo", 100);
            Visualizza_Spese.Columns.Add("Data", 100);
            listView_ReportAnnuale.View = View.Details;
            listView_ReportAnnuale.OwnerDraw = true;
            listView_ReportAnnuale.DrawColumnHeader += ListView_ReportAnnuale_DrawColumnHeader;
            listView_ReportAnnuale.DrawSubItem += ListView_ReportAnnuale_DrawSubItem;
            listView_ReportAnnuale.Columns.Add("Mese", 90);
            listView_ReportAnnuale.Columns.Add("Anno", 75);
            listView_ReportAnnuale.Columns.Add("Budget", 100);
            listView_ReportAnnuale.Columns.Add("Spese", 100);
            listView_ReportMensile.View = View.Details;
            listView_ReportMensile.Columns.Add("Categoria", 100);
            listView_ReportMensile.Columns.Add("Importo", 100);
            listView_ReportMensile.Columns.Add("Data", 100);
        }
        #endregion

        #region IMPOSTA CONTROLLI
        private void ImpostaControlli()
        {
            tabControlOperazioni.SelectedIndex = 0;
            listView_ReportMensile.SelectedIndexChanged += listView_ReportMensile_SelectedIndexChanged;
            comboBox_Mesi.SelectedIndexChanged += comboBox_Mesi_SelectedIndexChanged;
            Visualizza_Spese.SelectedIndexChanged += Visualizza_Spese_SelectedIndexChanged;
        }
        #endregion

        #region AGGIORNA LISTVIEW
        private void AggiornaTabella()
        {
            Visualizza_Spese.Items.Clear();
            int meseCorrente = DateTime.Now.Month;
            List<Spesa> speseDelMese = new List<Spesa>();
            for (int i = 0; i < listaSpese.Count; i++)
            {
                if (listaSpese[i].Data.Month == meseCorrente)
                {
                    speseDelMese.Add(listaSpese[i]);
                }
            }
            for (int i = 0; i < speseDelMese.Count; i++)
            {
                ListViewItem item = new ListViewItem(speseDelMese[i].Categoria);
                item.SubItems.Add(speseDelMese[i].Importo.ToString("C"));
                item.SubItems.Add(speseDelMese[i].Data.ToShortDateString());
                Visualizza_Spese.Items.Add(item);
            }
            button_OrdinaPerData.Enabled = true;
            button_ModificaSpesa.Enabled = true;
            button_EliminaSpesa.Enabled = true;
            comboBox_Categorie.Enabled = true;
            textBox_Importo.Enabled = true;
            dateTimePicker_Data.Enabled = true;
        }

        private void listView_ReportMensile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ReportMensile.SelectedItems.Count == 0)
                return;
            ListViewItem itemSelezionato = listView_ReportMensile.SelectedItems[0];
            try
            {
                comboBox_CategorieReportMensile.Text = itemSelezionato.SubItems[0].Text;
                string importoText = itemSelezionato.SubItems[1].Text
                    .Replace("€", "")
                    .Replace("$", "")
                    .Trim();
                if (decimal.TryParse(importoText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal importo))
                {
                    textBox_ReportMensile.Text = importo.ToString("0.00");
                }
                if (DateTime.TryParse(itemSelezionato.SubItems[2].Text, out DateTime data))
                {
                    dateTimePicker_DataReportMensile.Value = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Visualizza_Spese_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Visualizza_Spese.SelectedItems.Count == 0)
                return;
            ListViewItem itemSelezionato = Visualizza_Spese.SelectedItems[0];
            try
            {
                comboBox_Categorie.Text = itemSelezionato.SubItems[0].Text;
                string importoText = itemSelezionato.SubItems[1].Text
                    .Replace("€", "")
                    .Replace("$", "")
                    .Trim();
                if (decimal.TryParse(importoText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal importo))
                {
                    textBox_Importo.Text = importo.ToString("0.00");
                }
                if (DateTime.TryParse(itemSelezionato.SubItems[2].Text, out DateTime data))
                {
                    dateTimePicker_Data.Value = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListView_ReportAnnuale_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView_ReportAnnuale_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawBackground();
            if (e.ColumnIndex == 3)
            {
                if (e.Item != null && e.Item.SubItems.Count > 4)
                {
                    if (decimal.TryParse(e.Item.SubItems[2].Text.Replace("€", "").Replace("$", "").Trim(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal budget) && decimal.TryParse(e.SubItem.Text.Replace("€", "").Replace("$", "").Trim(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal spese))
                    {
                        Brush brush;
                        if (spese > budget)
                        {
                            brush = Brushes.Red;
                        }
                        else if (spese < budget)
                        {
                            brush = Brushes.Green;
                        }
                        else
                        {
                            brush = Brushes.Black;
                        }
                        e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, brush, e.Bounds, StringFormat.GenericDefault);
                        return;
                    }
                }
            }
            e.DrawText();
        }
        #endregion

        #region AGGIORNA LABEL BUDGET
        private void AggiornaBudgetLabel()
        {
            int meseCorrente = DateTime.Now.Month;
            if (budgetMensilePerMese.ContainsKey(meseCorrente))
            {
                decimal budget = budgetMensilePerMese[meseCorrente];
                decimal Rimanenza_perdita = budget - speseMensili;
                label_Budget.Text = $"Budget del mese di {DateTime.Now.ToString("MMMM")}: {budget:C}";
                label_RimanentePerdita.Text = $"Rimanenza/Perdita: {Rimanenza_perdita:C}";
            }
            else
            {
                label_Budget.Text = "Nessun budget impostato per questo mese!";
                label_RimanentePerdita.Text = "Nessuna spesa inserita!";
            }
        }
        #endregion

        #region SOTTOPROGRAMMA REPORT ANNUALE
        private void GeneraReportAnnuale()
        {
            listView_ReportAnnuale.Items.Clear();
            int annoCorrente = DateTime.Now.Year;
            decimal saldoTotale = 0m;
            Dictionary<int, decimal> budgetPerMese = new Dictionary<int, decimal>();
            Dictionary<int, decimal> spesePerMese = new Dictionary<int, decimal>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string budgetQuery = @"SELECT mese, importo FROM budget_mensili WHERE anno = @anno";
                using (MySqlCommand budgetCmd = new MySqlCommand(budgetQuery, conn))
                {
                    budgetCmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    using (MySqlDataReader budgetReader = budgetCmd.ExecuteReader())
                    {
                        while (budgetReader.Read())
                        {
                            int mese = Convert.ToInt32(budgetReader["mese"]);
                            decimal importo = Convert.ToDecimal(budgetReader["importo"]);
                            budgetPerMese[mese] = importo;
                        }
                    }
                }
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string speseQuery = @"SELECT MONTH(data) as mese, SUM(importo) as totale FROM gestore_spese WHERE YEAR(data) = @anno GROUP BY MONTH(data)";
                using (MySqlCommand speseCmd = new MySqlCommand(speseQuery, conn))
                {
                    speseCmd.Parameters.AddWithValue("@anno", annoCorrente);
                    conn.Open();
                    using (MySqlDataReader speseReader = speseCmd.ExecuteReader())
                    {
                        while (speseReader.Read())
                        {
                            int mese = Convert.ToInt32(speseReader["mese"]);
                            decimal totale = Convert.ToDecimal(speseReader["totale"]);
                            spesePerMese[mese] = totale;
                            saldoTotale += totale;
                        }
                    }
                }
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                for (int mese = 1; mese <= 12; mese++)
                {
                    string nomeMese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mese);
                    decimal budgetMese = budgetPerMese.ContainsKey(mese) ? budgetPerMese[mese] : 0m;
                    decimal totaleMese = spesePerMese.ContainsKey(mese) ? spesePerMese[mese] : 0m;
                    decimal differenza = budgetMese - totaleMese;
                    var item = new ListViewItem(new string[]
                    {
                        nomeMese,
                        annoCorrente.ToString(),
                        budgetMese.ToString("C"),
                        totaleMese.ToString("C"),
                        differenza.ToString("C")
                    });
                    if (differenza < 0)
                    {
                        item.SubItems[3].ForeColor = Color.Red;
                    }
                    else if (differenza > 0)
                    {
                        item.SubItems[3].ForeColor = Color.Green;
                    }
                    listView_ReportAnnuale.Items.Add(item);
                }
            }
            label_SaldoAnnuale.Text = $"SPESE ANNUALI: {saldoTotale:C}";
            chart_ReportAnnuale.Series.Clear();
            chart_ReportAnnuale.Legends.Clear();
            chart_ReportAnnuale.Titles.Clear();
            Series serieSpese = new Series("Spese");
            serieSpese.ChartType = SeriesChartType.Column;
            serieSpese.Color = Color.Red;
            serieSpese.XValueType = ChartValueType.String;
            Series serieBudget = new Series("Budget");
            serieBudget.ChartType = SeriesChartType.Column;
            serieBudget.Color = Color.MediumSpringGreen;
            serieBudget.XValueType = ChartValueType.String;
            for (int mese = 1; mese <= 12; mese++)
            {
                string nomeMese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mese);
                double totaleSpese = spesePerMese.ContainsKey(mese) ? (double)spesePerMese[mese] : 0;
                double totaleBudget = budgetPerMese.ContainsKey(mese) ? (double)budgetPerMese[mese] : 0;
                serieSpese.Points.AddXY(nomeMese, totaleSpese);
                serieBudget.Points.AddXY(nomeMese, totaleBudget);
            }
            chart_ReportAnnuale.Series.Add(serieSpese);
            chart_ReportAnnuale.Series.Add(serieBudget);
            for (int i = 0; i < serieSpese.Points.Count; i++)
            {
                serieSpese.Points[i].ToolTip = $"Spese: {serieSpese.Points[i].YValues[0]:C}";
            }
            for (int i = 0; i < serieBudget.Points.Count; i++)
            {
                serieBudget.Points[i].ToolTip = $"Budget: {serieBudget.Points[i].YValues[0]:C}";
            }
            Legend legenda = new Legend();
            legenda.Docking = Docking.Bottom;
            legenda.Alignment = StringAlignment.Center;
            chart_ReportAnnuale.Legends.Add(legenda);
            chart_ReportAnnuale.ChartAreas[0].AxisX.Title = "Mese";
            chart_ReportAnnuale.ChartAreas[0].AxisY.Title = "Importo (€)";
            chart_ReportAnnuale.ChartAreas[0].AxisX.Interval = 1;
            chart_ReportAnnuale.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_ReportAnnuale.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart_ReportAnnuale.Titles.Add("Confronto Spese e Budget Annuale");
            chart_ReportAnnuale.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);
            serieSpese["PointWidth"] = "0.4";
            serieBudget["PointWidth"] = "0.4";
        }
        #endregion

        #region SOTTOPROGRAMMA RESETTA ID
        private void ResettaIdAutoIncrement()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "ALTER TABLE gestore_spese AUTO_INCREMENT = 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SOTTOPROGRAMMA PROSSIMO ID
        private int ProssimoId()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'gestore_spese'";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }
        #endregion

        #region SOTTOPROGRAMMA ESISTE ID
        private bool IdEsiste(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT 1 FROM gestore_spese WHERE id = @id LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    return cmd.ExecuteScalar() != null;
                }
            }
        }
        #endregion

        #region SOTTOPROGRAMMA SALVA BUDGET DB
        private void SalvaBudgetNelDatabase(int mese, int anno, decimal importo)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"INSERT INTO budget_mensili (mese, anno, importo) VALUES (@mese, @anno, @importo) ON DUPLICATE KEY UPDATE importo = @importo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mese", mese);
                    cmd.Parameters.AddWithValue("@anno", anno);
                    cmd.Parameters.AddWithValue("@importo", importo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SOTTOPROGRAMMA CARICA BUDGET DB
        private void CaricaBudgetDalDatabase()
        {
            budgetMensilePerMese.Clear();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT mese, anno, importo FROM budget_mensili";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mese = Convert.ToInt32(reader["mese"]);
                            int anno = Convert.ToInt32(reader["anno"]);
                            decimal importo = Convert.ToDecimal(reader["importo"]);
                            if (anno == DateTime.Now.Year)
                            {
                                budgetMensilePerMese[mese] = importo;
                            }
                        }
                    }
                }
            }
            int meseCorrente = DateTime.Now.Month;
            if (budgetMensilePerMese.ContainsKey(meseCorrente))
            {
                budgetMensile = budgetMensilePerMese[meseCorrente];
            }
            AggiornaBudgetLabel();
        }
        #endregion

        #region SOTTOPROGRAMMA CARICA SPESE NEL MESE SELEZIONATO
        private void CaricaSpeseMeseSelezionato(int mese, int anno)
        {
            listView_ReportMensile.Items.Clear();
            decimal totaleSpeseMese = 0m;
            decimal budgetMese = 0m;
            bool budgetImpostato = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string budgetQuery = @"SELECT importo FROM budget_mensili WHERE mese = @mese AND anno = @anno";
                    using (MySqlCommand budgetCmd = new MySqlCommand(budgetQuery, conn))
                    {
                        budgetCmd.Parameters.AddWithValue("@mese", mese);
                        budgetCmd.Parameters.AddWithValue("@anno", anno);
                        conn.Open();
                        object result = budgetCmd.ExecuteScalar();
                        if (result != null)
                        {
                            budgetMese = Convert.ToDecimal(result);
                            budgetImpostato = true;
                        }
                        conn.Close();
                    }
                }
                bool Spese = false;
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = @"SELECT id, categoria, importo, data FROM gestore_spese WHERE MONTH(data) = @mese AND YEAR(data) = @anno ORDER BY data ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mese", mese);
                        cmd.Parameters.AddWithValue("@anno", anno);
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Spese = true;
                                int id = Convert.ToInt32(reader["id"]);
                                string categoria = reader["categoria"].ToString();
                                decimal importo = Convert.ToDecimal(reader["importo"]);
                                DateTime data = Convert.ToDateTime(reader["data"]);
                                ListViewItem item = new ListViewItem(categoria);
                                item.SubItems.Add(importo.ToString("C", CultureInfo.CurrentCulture));
                                item.SubItems.Add(data.ToShortDateString());
                                item.Tag = id;
                                listView_ReportMensile.Items.Add(item);
                                totaleSpeseMese += importo;
                            }
                        }
                    }
                }
                string nomeMese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mese);
                if (!Spese)
                {
                    label_TotaleReportMese.Text = "Nessuna spesa registrata per questo mese";
                    label_TotaleReportMese.ForeColor = Color.Black;
                }
                else
                {
                    label_TotaleReportMese.Text = $"Totale spese {nomeMese}: {totaleSpeseMese:C}";
                    decimal Rimanenza_perdita = budgetImpostato ? (budgetMese - totaleSpeseMese) : 0;
                    if (Rimanenza_perdita < 0)
                    {
                        label_TotaleReportMese.ForeColor = Color.Red;
                    }
                    else
                    {
                        label_TotaleReportMese.ForeColor = Color.Green;
                    }
                }
                if (budgetImpostato)
                {
                    decimal Rimanenza_perdita = budgetMese - totaleSpeseMese;
                    label_BudgetReportMensile.Text = $"Budget {nomeMese}: {budgetMese:C}";
                    label_RimanenzaPerditaReportMensile.Text = $"Rimanenza/Perdita: {Rimanenza_perdita:C}";
                }
                else
                {
                    label_BudgetReportMensile.Text = $"Nessun budget impostato per {nomeMese}";
                    label_RimanenzaPerditaReportMensile.Text = $"Nessuna spesa inserita!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento delle spese: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_Mesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Mesi.SelectedIndex != -1)
            {
                int meseSelezionato = comboBox_Mesi.SelectedIndex + 1;
                int annoCorrente = DateTime.Now.Year;
                CaricaSpeseMeseSelezionato(meseSelezionato, annoCorrente);
            }
        }
        #endregion

        #region SOTTOPROGRAMMA SALVA SPESE DB
        private void SalvaSpesaNelDatabase(Spesa spesa)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "INSERT INTO gestore_spese (categoria, importo, data) VALUES (@categoria, @importo, @data)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoria", spesa.Categoria);
                    cmd.Parameters.AddWithValue("@importo", spesa.Importo);
                    cmd.Parameters.AddWithValue("@data", spesa.Data);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    spesa.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        #endregion

        #region SOTTOPROGRAMMA CARICA SPESE DB
        private void CaricaSpeseDalDatabase()
        {
            listaSpese.Clear();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var cmdCount = new MySqlCommand("SELECT COUNT(*) FROM gestore_spese", conn))
                {
                    int count = Convert.ToInt32(cmdCount.ExecuteScalar());
                    if (count == 0)
                    {
                        ResettaIdAutoIncrement();
                    }
                }
                string query = "SELECT id, categoria, importo, data FROM gestore_spese WHERE MONTH(data) = MONTH(CURRENT_DATE()) AND YEAR(data) = YEAR(CURRENT_DATE()) ORDER BY data ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaSpese.Add(new Spesa
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Categoria = reader["categoria"].ToString(),
                                Importo = Convert.ToDecimal(reader["importo"]),
                                Data = Convert.ToDateTime(reader["data"])
                            });
                        }
                    }
                }
            }
            speseMensili = listaSpese.Sum(s => s.Importo);
            AggiornaTabella();
            AggiornaBudgetLabel();
            GeneraReportAnnuale();
        }
        #endregion

        #region SOTTOPROGRAMMA PULISCI CAMPI
        private void PulisciCampi()
        {
            ComboBox_Categoria.SelectedIndex = -1;
            textBox_Prezzo.Text = "";
            DataTimePicker_Data.Value = DateTime.Today;
            comboBox_Categorie.SelectedIndex = -1;
            textBox_Importo.Text = "";
            dateTimePicker_Data.Value = DateTime.Today;
            comboBox_CategorieReportMensile.SelectedIndex = -1;
            textBox_ReportMensile.Text = "";
            dateTimePicker_DataReportMensile.Value = DateTime.Today;
        }
        #endregion

        #region SOTTOPROGRAMMA CONFRONTO DATA
        private int ConfrontaDate(Spesa s1, Spesa s2)
        {
            return DateTime.Compare(s1.Data, s2.Data);
        }
        #endregion

        public class Spesa
        {
            public int Id { get; set; }
            public string Categoria { get; set; }
            public decimal Importo { get; set; }
            public DateTime Data { get; set; }
        }
    }
}