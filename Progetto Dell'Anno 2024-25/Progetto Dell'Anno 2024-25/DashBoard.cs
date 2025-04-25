using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        private List<Spesa> listaSpese = new List<Spesa>();
        private Dictionary<int, decimal> budgetMensilePerMese = new Dictionary<int, decimal>();
        private decimal budgetMensile;
        private decimal speseMensili = 0;
        string connStr = "server=localhost;database=guardian_of_the_money;user=root;password=root;";

        public DashBoard()
        {
            InitializeComponent();
            InizializzaComboBox();
            ImpostaControlli();
            InizializzaListView();
            CaricaBudgetDalDatabase();
            CaricaSpeseDalDatabase();
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
                MessageBox.Show("Inserisci solo numeri validi nel campo prezzo.", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal importo = Convert.ToDecimal(textBox_Prezzo.Text.Replace(".", ","));
            int meseCorrente = DateTime.Now.Month;
            if (!budgetMensilePerMese.ContainsKey(meseCorrente))
            {
                MessageBox.Show("Non hai impostato il budget per il mese corrente!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PulisciCampi();
                return;
            }
            budgetMensile = budgetMensilePerMese[meseCorrente];

            if (speseMensili + importo > budgetMensile)
            {
                MessageBox.Show("Hai superato il budget mensile!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Spesa nuovaSpesa = new Spesa
            {
                Categoria = ComboBox_Categoria.SelectedItem.ToString(),
                Importo = importo,
                Data = DataTimePicker_Data.Value
            };
            listaSpese.Add(nuovaSpesa);
            SalvaSpesaNelDatabase(nuovaSpesa); // Ora salva anche l'ID
            speseMensili += importo;
            AggiornaTabella();
            AggiornaBudgetLabel();
            PulisciCampi();
        }
        #endregion

        #region BOTTONE MODIFICA SPESA
        private void button_ModificaSpesa_Click(object sender, EventArgs e)
        {
            if (Visualizza_Spese.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una spesa da modificare.", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = Visualizza_Spese.SelectedItems[0].Index;
            Spesa spesaDaModificare = listaSpese[indice];

            string nuovaCategoria = ComboBox_Categoria.Text;
            string nuovoImportoText = textBox_Prezzo.Text;
            DateTime nuovaData = DataTimePicker_Data.Value;

            if (nuovaCategoria == "" || nuovoImportoText == "")
            {
                MessageBox.Show("Completa i campi per la modifica", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal nuovoImporto = Convert.ToDecimal(nuovoImportoText.Replace(".", ","));

            speseMensili -= spesaDaModificare.Importo;
            speseMensili += nuovoImporto;

            // Aggiorna in lista
            spesaDaModificare.Categoria = nuovaCategoria;
            spesaDaModificare.Importo = nuovoImporto;
            spesaDaModificare.Data = nuovaData;

            // Aggiorna nel DB (USANDO MYSQL)
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "UPDATE gestore_spese SET categoria = @categoria, importo = @importo, data = @data WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoria", nuovaCategoria);
                    cmd.Parameters.AddWithValue("@importo", nuovoImporto);
                    cmd.Parameters.AddWithValue("@data", nuovaData);
                    cmd.Parameters.AddWithValue("@id", spesaDaModificare.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            AggiornaTabella();
            PulisciCampi();
            AggiornaBudgetLabel();
            MessageBox.Show("Spesa modificata con successo", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DialogResult risultato = MessageBox.Show("Sei sicuro di voler eliminare questa spesa?", "CONFERMA", MessageBoxButtons.YesNo);
            if (risultato == DialogResult.No)
            {
                return;
            }

            decimal importoDaRimuovere = listaSpese[indice].Importo;
            speseMensili -= importoDaRimuovere;
            listaSpese.RemoveAt(indice);
            AggiornaTabella();
            AggiornaBudgetLabel();

            // Elimina dal DB (USANDO MYSQL)
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM gestore_spese WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", spesaDaEliminare.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Spesa eliminata con successo!", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region BOTTONE ORDINA PER DATA
        private void button_OrdinaPerData_Click(object sender, EventArgs e)
        {
            listaSpese.Sort(ConfrontaDate);
            AggiornaTabella();
        }
        #endregion

        #region BOTTONE SCARICA REPORT
        private void button_ScaricaReport_Click(object sender, EventArgs e)
        {
            if (comboBox_Mesi.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un mese!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int mese = comboBox_Mesi.SelectedIndex + 1;
            string nomeMese = comboBox_Mesi.SelectedItem.ToString();
            List<Spesa> speseMese = new List<Spesa>();

            for (int i = 0; i < listaSpese.Count; i++)
            {
                Spesa s = listaSpese[i];
                if (s.Data.Month == mese)
                {
                    speseMese.Add(s);
                }
            }

            if (speseMese.Count == 0)
            {
                MessageBox.Show("In questo mese non hai speso nulla, seleziona un altro mese!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string percorsoProgetto = ("../../File");

            string percorsoFile = Path.Combine(percorsoProgetto, $"Report_{nomeMese}.csv");

            using (StreamWriter sw = new StreamWriter(percorsoFile))
            {
                sw.WriteLine("Categoria" + "Importo" + "Data");
                for (int i = 0; i < speseMese.Count; i++)
                {
                    Spesa spesa = speseMese[i];
                    sw.WriteLine($"{spesa.Categoria},{spesa.Importo},{spesa.Data:dd/MM/yyyy}");
                }
            }
            MessageBox.Show("Report salvato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region BOTTONE IMPOSTA BUDGET
        private void button_ImpostaBudget_Click(object sender, EventArgs e)
        {
            if (textBox_Budget.Text != "" && textBox_Budget.Text.All(char.IsDigit))
            {
                int meseCorrente = DateTime.Now.Month;
                int annoCorrente = DateTime.Now.Year;
                decimal budget = Convert.ToDecimal(textBox_Budget.Text);

                // Aggiorna in memoria
                budgetMensilePerMese[meseCorrente] = budget;
                budgetMensile = budget;
                speseMensili = 0;

                // Salva nel database
                SalvaBudgetNelDatabase(meseCorrente, annoCorrente, budget);

                MessageBox.Show($"Budget per il mese di {DateTime.Now.ToString("MMMM")}: {budget:C}", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_Budget.Clear();
                AggiornaBudgetLabel();
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Budget.Clear();
            }
        }
        #endregion

        #region INIZIALIZZA COMBOBOX
        private void InizializzaComboBox()
        {
            ComboBox_Categoria.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
            comboBox_Mesi.Items.AddRange(new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" });
            toolStripComboBox_CambioTema.Items.AddRange(new string[] { "Chiaro", "Scuro" });
        }
        #endregion

        #region INIZIALIZZA LISTVIEW
        private void InizializzaListView()
        {
            Visualizza_Spese.View = View.Details;
            Visualizza_Spese.Columns.Add("Categoria", 100);
            Visualizza_Spese.Columns.Add("Importo", 100);
            Visualizza_Spese.Columns.Add("Data", 100);
        }
        #endregion

        #region IMPOSTA CONTROLLI
        private void ImpostaControlli()
        {
            tabControlOperazioni.SelectedIndex = 0;
        }
        #endregion

        #region AGGIORNA LISTVIEW
        private void AggiornaTabella()
        {
            Visualizza_Spese.Items.Clear();
            for (int i = 0; i < listaSpese.Count; i++)
            {
                var spesa = listaSpese[i];
                var item = new ListViewItem(spesa.Categoria);
                item.SubItems.Add(spesa.Importo.ToString("C"));
                item.SubItems.Add(spesa.Data.ToString("dd/MM/yyyy"));
                Visualizza_Spese.Items.Add(item);
            }
            button_OrdinaPerData.Enabled = true;
            button_ModificaSpesa.Enabled = true;
            button_EliminaSpesa.Enabled = true;
        }
        #endregion

        #region AGGIORNA LABEL BUDGET
        private void AggiornaBudgetLabel()
        {
            int meseCorrente = DateTime.Now.Month;
            if (budgetMensilePerMese.ContainsKey(meseCorrente))
            {
                decimal budget = budgetMensilePerMese[meseCorrente];
                decimal saldo = budget - speseMensili;
                label_Budget.Text = $"Budget del mese di {DateTime.Now.ToString("MMMM")}: {budget:C} | Saldo: {saldo:C}";
            }
            else
            {
                label_Budget.Text = "Nessun budget impostato per questo mese!";
            }
        }
        #endregion

        #region MOSTRA TUTTE LE TABELLE
        /*private void MostraTutteLeTabelle()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                DataTable schema = conn.GetSchema("Tables");

                foreach (DataRow row in schema.Rows)
                {
                    string tableName = row[2].ToString();
                    string query = $"SELECT * FROM [{tableName}]";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Crea un nuovo TabPage per ogni tabella
                        TabPage tabPage = new TabPage(tableName);
                        DataGridView dataGridView = new DataGridView
                        {
                            DataSource = dataTable,
                            Dock = DockStyle.Fill,
                            ReadOnly = true,
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        };
                        tabPage.Controls.Add(dataGridView);
                        tabControlTabelle.TabPages.Add(tabPage);
                    }
                }
            }
        }*/
        #endregion

        #region SOTTOPROGRAMMA SALVA BUDGET DB
        private void SalvaBudgetNelDatabase(int mese, int anno, decimal importo)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                // Query per inserire o aggiornare il budget
                string query = @"INSERT INTO budget_mensili (mese, anno, importo) 
                         VALUES (@mese, @anno, @importo)
                         ON DUPLICATE KEY UPDATE importo = @importo";

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

                            // Se è l'anno corrente, aggiungi al dizionario
                            if (anno == DateTime.Now.Year)
                            {
                                budgetMensilePerMese[mese] = importo;
                            }
                        }
                    }
                }
            }

            // Aggiorna il budget corrente
            int meseCorrente = DateTime.Now.Month;
            if (budgetMensilePerMese.ContainsKey(meseCorrente))
            {
                budgetMensile = budgetMensilePerMese[meseCorrente];
            }

            AggiornaBudgetLabel();
        }
        #endregion

        #region SOTTOPROGRAMMA SALVA SPESE DB
        private void SalvaSpesaNelDatabase(Spesa spesa)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                // Query modificata per auto-incrementare l'ID
                string query = "INSERT INTO gestore_spese (categoria, importo, data) VALUES (@categoria, @importo, @data); SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoria", spesa.Categoria);
                    cmd.Parameters.AddWithValue("@importo", spesa.Importo);
                    cmd.Parameters.AddWithValue("@data", spesa.Data);

                    conn.Open();
                    // Ottieni l'ID generato dal database
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
                string query = "SELECT id, categoria, importo, data FROM gestore_spese";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Spesa s = new Spesa
                            {
                                Id = Convert.ToInt32(reader["id"]), // Aggiunto questa linea
                                Categoria = reader["categoria"].ToString(),
                                Importo = Convert.ToDecimal(reader["importo"]),
                                Data = Convert.ToDateTime(reader["data"])
                            };
                            listaSpese.Add(s);
                        }
                    }
                }
            }

            // Aggiorna il totale delle spese mensili
            speseMensili = listaSpese
                .Where(s => s.Data.Month == DateTime.Now.Month && s.Data.Year == DateTime.Now.Year)
                .Sum(s => s.Importo);

            AggiornaTabella();
            AggiornaBudgetLabel();
        }
        #endregion

        #region SOTTOPROGRAMMA PULISCI CAMPI
        private void PulisciCampi()
        {
            ComboBox_Categoria.SelectedIndex = -1;
            textBox_Prezzo.Text = "";
            DataTimePicker_Data.Value = DateTime.Today;
        }
        #endregion

        #region SOTTOPROGRAMMA CONFRONTO DATA
        private int ConfrontaDate(Spesa s1, Spesa s2)
        {
            return DateTime.Compare(s1.Data, s2.Data);
        }
        #endregion        

        #region SOTTOPROGRAMMA CAMBIO TEMA
        private void CambiaTema(string tema)
        {
            if (tema == "Scuro")
            {
                this.BackColor = Color.Black;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Control c = this.Controls[i];
                    c.ForeColor = Color.Black;
                }
                tabPageAggiungi.BackColor = Color.Black;
                tabPageVisualizza.BackColor = Color.Black;
                tabPageReport.BackColor = Color.Black;
                tabPageImpostazioni.BackColor = Color.Black;
                label_ImpostaBudget.ForeColor = Color.White;
                label_Visualizza.ForeColor = Color.White;
                label_Aggiungi.ForeColor = Color.White;
                label_Report.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Control c = this.Controls[i];
                    c.ForeColor = Color.Black;
                }
                tabPageAggiungi.BackColor = Color.White;
                tabPageVisualizza.BackColor = Color.White;
                tabPageReport.BackColor = Color.White;
                tabPageImpostazioni.BackColor = Color.White;
                label_ImpostaBudget.ForeColor = Color.Black;
                label_Visualizza.ForeColor = Color.Black;
                label_Aggiungi.ForeColor = Color.Black;
                label_Report.ForeColor = Color.Black;
            }
        }

        private void toolStripComboBox_CambioTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temaSelezionato = toolStripComboBox_CambioTema.SelectedItem.ToString();
            CambiaTema(temaSelezionato);
        }
        #endregion

        #region SOTTOPROGRAMMA GRAFICO SPESE
        /*private void CreaGraficoSpese()
        {
            chartSpese.Series.Clear();
            chartSpese.ChartAreas.Clear();
            chartSpese.Titles.Clear();

            ChartArea chartArea = new ChartArea();
            chartSpese.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Spese",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            var spesePerCategoria = listaSpese
                .GroupBy(s => s.Categoria)
                .Select(g => new { Categoria = g.Key, Totale = g.Sum(s => s.Importo) });

            foreach (var item in spesePerCategoria)
            {
                series.Points.AddXY(item.Categoria, item.Totale);
            }

            chartSpese.Series.Add(series);
            chartSpese.Titles.Add("Distribuzione delle Spese per Categoria");
        }*/
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