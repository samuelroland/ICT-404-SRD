//Programme: 09-Combobox exo de moodle sur les ComboBox et les ListBox.
//Samuel Roland
//juin 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Combobox
{
    public partial class frmListComboBox : Form
    {
        int lstlastselect;  //numéro de la liste où le dernièr élement a été sélectionné.

        public frmListComboBox()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter ?");

            Application.Exit();
        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
           
            switch (lstlastselect)
            {
                case 1:
                    lstFinale.Items.Add(cboOperateurs.SelectedItem);
                    break;
                case 2:
                    lstFinale.Items.Add(lstEcoles.SelectedItem);
                    break;
                case 3:
                    lstFinale.Items.Add(cboGymnase.SelectedItem);
                    break;

                default:
                    break;
            }

            //else
            {
                MessageBox.Show("Pas d'élément sélectionné");
            }
        }

        private void CmdEffacer_Click(object sender, EventArgs e)
        {
            int nbitem = lstFinale.Items.Count;
            MessageBox.Show(lstFinale.Items.Count.ToString());
            //Effacer tous les items de la lstFinale:
            for (int i = 0; i < nbitem; i++)
            {
                lstFinale.Items.RemoveAt(0);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstlastselect = 1;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstlastselect = 2;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstlastselect = 3;
        }

        private void FrmListComboBox_Load(object sender, EventArgs e)
        {
            cboOperateurs.SelectedIndex = 0;
        }
    }
}
