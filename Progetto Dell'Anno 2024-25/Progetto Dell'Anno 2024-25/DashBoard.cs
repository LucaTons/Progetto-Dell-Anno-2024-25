using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        private List<Spesa> listaSpese = new List<Spesa>();
        private decimal budgetMensile = 0;
        private decimal speseMensili = 0;
        private bool avvisoBudgetMostrato = false;

        public DashBoard()
        {
            InitializeComponent();
            InizializzaComboBox();
            ImpostaControlli();
            InizializzaListView();
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
                MessageBox.Show("Inserisci solo numeri validi nel campo prezzo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal importo = Convert.ToDecimal(textBox_Prezzo.Text.Replace(".", ","));

            // Aggiungi la spesa solo se il totale non supera il budget
            if (speseMensili + importo > budgetMensile)
            {
                MessageBox.Show("Hai superato il budget mensile!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PulisciCampi();
                return;
            }

            Spesa nuovaSpesa = new Spesa
            {
                Categoria = ComboBox_Categoria.SelectedItem.ToString(),
                Importo = importo,
                Data = DataTimePicker_Data.Value
            };

            listaSpese.Add(nuovaSpesa);
            speseMensili += importo; // Aggiungi l'importo delle nuove spese al totale

            AggiornaTabella();
            PulisciCampi();

            decimal percentuale = speseMensili / budgetMensile;

            if (!avvisoBudgetMostrato && percentuale >= 0.9m && percentuale < 1.0m)
            {
                MessageBox.Show($"Hai speso circa il 90% del tuo budget mensile!\nBudget: {budgetMensile:C} - Spese: {speseMensili:C}", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                avvisoBudgetMostrato = true;
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
                    sw.WriteLine($"{spesa.Categoria}" + "{spesa.Importo}" + "{spesa.Data:dd/MM/yyyy}");
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
                budgetMensile = Convert.ToDecimal(textBox_Budget.Text);
                speseMensili = 0;
                MessageBox.Show($"Budget impostato: {budgetMensile:C}", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Budget.Clear();
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Budget.Clear();
            }
        }
        #endregion

        #region INIZIALIZZA COMBOBOX
        private void InizializzaComboBox()
        {
            ComboBox_Categoria.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
            comboBox_Mesi.Items.AddRange(new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" });
            comboBox_CambiaTema.Items.AddRange(new string[] { "Chiaro", "Scuro" });
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
        }
        #endregion

        #region COMBOBOX CAMBIO TEMA
        private void comboBox_CambiaTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CambiaTema.SelectedItem != null)
                CambiaTema(comboBox_CambiaTema.SelectedItem.ToString());
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
                    tabPageAggiungi.BackColor = Color.Black;
                    tabPageVisualizza.BackColor = Color.Black;
                    tabPageReport.BackColor = Color.Black;
                    tabPageImpostazioni.BackColor = Color.Black;
                    label_ImpostaBudget.ForeColor = Color.White;
                    label_CambiaTema.ForeColor = Color.White;
                    label_Visualizza.ForeColor = Color.White;
                    label_Aggiungi.ForeColor = Color.White;
                    label_Report.ForeColor = Color.White;
                }
            }
            else
            {
                this.BackColor = SystemColors.Control;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Control c = this.Controls[i];
                    c.ForeColor = Color.Black;
                    tabPageAggiungi.BackColor = Color.White;
                    tabPageVisualizza.BackColor = Color.White;
                    tabPageReport.BackColor = Color.White;
                    tabPageImpostazioni.BackColor = Color.White;
                    label_ImpostaBudget.ForeColor = Color.Black;
                    label_CambiaTema.ForeColor = Color.Black;
                    label_Visualizza.ForeColor = Color.Black;
                    label_Aggiungi.ForeColor = Color.Black;
                    label_Report.ForeColor = Color.Black;
                }
            }
        }
        #endregion
    }
    
    public class Spesa
    {
        public string Categoria { get; set; }
        public decimal Importo { get; set; }
        public DateTime Data { get; set; }
    }
}