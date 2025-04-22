using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing; // Per il Color

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        private List<Spesa> listaSpese = new List<Spesa>();
        private decimal budgetMensile;

        public DashBoard()
        {
            InitializeComponent();
            InizializzaCategorie();
            ImpostaControlli();
            InizializzaListView();
        }

        private void button_AggiungiSpesa_Click(object sender, EventArgs e)
        {
            if (ComboBox_Categoria.SelectedItem == null || textBox_Prezzo.Text == "")
            {
                MessageBox.Show("Compila tutti i campi!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!textBox_Prezzo.Text.All(c => char.IsDigit(c) || c == ',' || c == '.'))
            {
                MessageBox.Show("Inserisci solo numeri validi nel campo prezzo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Spesa nuovaSpesa = new Spesa
            {
                Categoria = ComboBox_Categoria.SelectedItem.ToString(),
                Importo = Convert.ToDecimal(textBox_Prezzo.Text.Replace(".", ",")),
                Data = DataTimePicker_Data.Value
            };

            listaSpese.Add(nuovaSpesa);
            AggiornaTabella();
            PulisciCampi();
        }

        private void AggiornaTabella()
        {
            Visualizza_Spese.Items.Clear();
            foreach (var spesa in listaSpese)
            {
                var item = new ListViewItem(spesa.Categoria);
                item.SubItems.Add(spesa.Importo.ToString("C"));
                item.SubItems.Add(spesa.Data.ToString("dd/MM/yyyy"));
                Visualizza_Spese.Items.Add(item);
            }
        }

        private void PulisciCampi()
        {
            ComboBox_Categoria.SelectedIndex = -1;
            textBox_Prezzo.Text = "";
            DataTimePicker_Data.Value = DateTime.Today;
        }

        private void InizializzaCategorie()
        {
            ComboBox_Categoria.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Varie" });
            comboBox_Mesi.Items.AddRange(new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" });
            comboBox_CambiaTema.Items.AddRange(new string[] { "Chiaro", "Scuro" });
        }

        private void InizializzaListView()
        {
            Visualizza_Spese.View = View.Details;
            Visualizza_Spese.Columns.Add("Categoria", 100);
            Visualizza_Spese.Columns.Add("Importo", 100);
            Visualizza_Spese.Columns.Add("Data", 100);
        }

        private void ImpostaControlli()
        {
            tabControlOperazioni.SelectedIndex = 0;
        }

        private void button_ImpostaBudget_Click(object sender, EventArgs e)
        {
            //controllo se la casella è vuota e se ci sono solo numeri
            if (textBox_Budget.Text != "" && textBox_Budget.Text.All(char.IsDigit))
            {
                budgetMensile = Convert.ToDecimal(textBox_Budget.Text);
                MessageBox.Show($"Budget impostato: {budgetMensile:C}");
                textBox_Budget.Clear();
            }
            else
            {
                MessageBox.Show("Inserisci solo numeri interi nel budget!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Budget.Clear();
            }
        }

        private void comboBox_CambiaTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CambiaTema.SelectedItem != null)
                CambiaTema(comboBox_CambiaTema.SelectedItem.ToString());
        }

        private void CambiaTema(string tema)
        {
            if (tema == "Scuro")
            {
                this.BackColor = Color.Black;
                foreach (Control c in this.Controls)
                {
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
                foreach (Control c in this.Controls)
                {
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
    }

    public class Spesa
    {
        public string Descrizione { get; set; }
        public string Categoria { get; set; }
        public decimal Importo { get; set; }
        public DateTime Data { get; set; }
    }
}
