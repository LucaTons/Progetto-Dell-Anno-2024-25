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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            button_Inizio.Visible = true;
            button_chiudi.Visible = true;
            Label_Titolo.Visible = true;
            this.BackgroundImage = Image.FromFile("../../Resources/SfondoHome.jpg");
        }

        private void button_Inizio_Click(object sender, EventArgs e)
        {
            button_Inizio.Visible = false;
            button_chiudi.Visible = false;
            Label_Titolo.Visible = false;
            this.Hide();
            DashBoard form2 = new DashBoard();
            form2.ShowDialog();
        }

        private void button_chiudi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
