using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ArcheDeNoe
{
    public partial class frmArcheDeNoe : Form
    {
        public frmArcheDeNoe()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdMettreABord_Click(object sender, EventArgs e)
        {
            if (lstATerre.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur. Aucun animal sélectionné !");
            }
            else
            {

            }
        }
    }
}
