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
                MessageBox.Show("Inserisci solo numeri validi nel campo prezzo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            for (int i = 0; i < listaSpese.Count; i++)
            {
                var spesa = listaSpese[i];
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

        private void button_OrdinaPerData_Click(object sender, EventArgs e)
        {
            listaSpese.Sort(ConfrontaDate);
            AggiornaTabella();
        }

        private int ConfrontaDate(Spesa s1, Spesa s2)
        {
            return DateTime.Compare(s1.Data, s2.Data);
        }

        private void button_ImpostaBudget_Click(object sender, EventArgs e)
        {
            if (textBox_Budget.Text != "" && textBox_Budget.Text.All(char.IsDigit))
            {
                budgetMensile = Convert.ToDecimal(textBox_Budget.Text);
                MessageBox.Show($"Budget impostato: {budgetMensile:C}", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Budget.Clear();
            }
            else
            {
                MessageBox.Show("Inserisci solo numeri interi nel budget!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                sw.WriteLine("Categoria,Importo,Data");
                for (int i = 0; i < speseMese.Count; i++)
                {
                    Spesa spesa = speseMese[i];
                    sw.WriteLine($"{spesa.Categoria},{spesa.Importo},{spesa.Data:dd/MM/yyyy}");
                }
            }
            MessageBox.Show("Report salvato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
