using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        private List<Spesa> listaSpese = new List<Spesa>();

        public DashBoard()
        {
            InitializeComponent();
            InizializzaCategorie();
            ImpostaControlli();
            InizializzaListView();
        }

        private void button_AggiungiSpesa_Click(object sender, EventArgs e)
        {
            if (ComboBox_Categoria.SelectedItem == null)
            {
                MessageBox.Show("Compila tutti i campi!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Creazione di una nuova spesa
            Spesa nuovaSpesa = new Spesa
            {
                Categoria = ComboBox_Categoria.SelectedItem.ToString(),
                Importo = Convert.ToDecimal(textBox_Prezzo.Text),
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
            ComboBox_Categoria.Items.AddRange(new string[] { "Uscite", "Trasporti", "Bollette", "Visite", "Farmacia", "Mutuo", "Bolli", "Assicurazioni", "Altro" });
        }

        private void InizializzaListView()
        {
            Visualizza_Spese.View = View.Details;
            Visualizza_Spese.Columns.Add("Categoria", 200);
            Visualizza_Spese.Columns.Add("Importo", 100);
            Visualizza_Spese.Columns.Add("Data", 150);
        }

        private void ImpostaControlli()
        {
            tabControlOperazioni.SelectedIndex = 0;
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