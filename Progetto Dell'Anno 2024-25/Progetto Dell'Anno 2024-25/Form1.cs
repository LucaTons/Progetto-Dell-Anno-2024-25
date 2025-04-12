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
        }

        private void aggiungitoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = true;
            tabControlCategorie.SelectedTab = tabPageAggiungi;
        }

        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = true;
            tabControlCategorie.SelectedTab = tabPageVisualizza;
            AggiornaTabella();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = true;
            tabControlCategorie.SelectedTab = tabPageReport;
            // Funzione report futura
        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = true;
            tabControlCategorie.SelectedTab = tabPageImpostazioni;
        }

        private void btnAggiungiSpesa_Click(object sender, EventArgs e)
        {
            if (txtDescrizione.Text == "" || cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Compila tutti i campi.");
                return;
            }

            Spesa nuovaSpesa = new Spesa
            {
                Descrizione = txtDescrizione.Text,
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Importo = nudImporto.Value,
                Data = dtpData.Value
            };

            listaSpese.Add(nuovaSpesa);
            AggiornaTabella();
            PulisciCampi();
        }

        private void AggiornaTabella()
        {
            dgvSpese.Rows.Clear();
            foreach (var spesa in listaSpese)
            {
                dgvSpese.Rows.Add(spesa.Data.ToShortDateString(), spesa.Descrizione, spesa.Categoria, spesa.Importo + " €");
            }
        }

        private void PulisciCampi()
        {
            txtDescrizione.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudImporto.Value = 0;
            dtpData.Value = DateTime.Today;
        }

        private void InizializzaCategorie()
        {
            cmbCategoria.Items.AddRange(new string[] { "Cibo", "Trasporti", "Svago", "Bollette", "Altro" });
        }

        private void ImpostaControlli()
        {
            tabControlCategorie.Visible = false;
            tabControlCategorie.SelectedIndex = 0;
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