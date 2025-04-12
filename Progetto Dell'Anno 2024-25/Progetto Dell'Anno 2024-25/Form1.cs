using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Dell_Anno_2024_25
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void aggiungitoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = true;
        }

        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = false;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = false;
        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCategorie.Visible = false;
        }
    }
}
