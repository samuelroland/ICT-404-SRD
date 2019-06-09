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
        int lstlastselectitem;  //numéro de la liste où le dernièr élement a été sélectionné.

        public frmListComboBox()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {

            DialogResult Res = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void noelementselected()
        {
            MessageBox.Show("Pas d'élément sélectionné");
        }
        private bool checkpaspresent(string itemtext)  //vérifie que l'item n'existe pas déja dans la lstFinale.
        {
            //Scan de la lstFinale:
            for (int i = 0; i < lstFinale.Items.Count; i++)
            {
                if (itemtext == lstFinale.Items[i].ToString())
                {
                    MessageBox.Show("litem est " + itemtext + " et le numero dans la boucle for est " + i);
                    return true;    //Si il trouve un item du meme nom il va retourner true direct.
                }
                //Si il a pas trouvé, il retourne false:

            }
            return false;
        }
        private void msgdejapresent()   //msgbox que l'item est deja dans la liste finale.
        {
            MessageBox.Show("Element déjà présent dans la liste finale !");
        }
        private void CmdAjouter_Click(object sender, EventArgs e)
        {

            switch (lstlastselectitem)
            {
                case 1:
                    if (cboOperateurs.SelectedIndex != -1)
                    {
                        if (checkpaspresent(cboOperateurs.SelectedItem.ToString()) == false)
                        {
                            lstFinale.Items.Add(cboOperateurs.SelectedItem);
                        }
                        else
                        {
                            msgdejapresent();
                        }
                    }
                    else
                    {
                        noelementselected();
                    }
                    break;
                case 2:
                    if (lstEcoles.SelectedIndex != -1)
                    {
                        if (checkpaspresent(lstEcoles.SelectedItem.ToString())==false)
                        {
                            lstFinale.Items.Add(lstEcoles.SelectedItem);
                        }
                    }
                    else
                    {
                        noelementselected();
                    }
                    break;
                case 3:
                    if (cboGymnase.SelectedIndex != -1)
                    {
                        if (checkpaspresent(cboGymnase.SelectedItem.ToString())==false)
                        {
                            lstFinale.Items.Add(cboGymnase.SelectedItem);
                        }
                    }
                    else
                    {
                        noelementselected();
                    }
                    break;

                default:
                    break;
            }

            //actualiser nb écoles selected dans lstFinale:
            counterelementlst();
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
            counterelementlst();
        }



        private void FrmListComboBox_Load(object sender, EventArgs e)
        {
            cboOperateurs.SelectedIndex = 0;
        }
        private void counterelementlst()    //compte le nb d'élement dans la lstbox finale.
        {
            lblNbEcolesSelected.Text = lstFinale.Items.Count.ToString();
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstFinale.SelectedIndex != -1)
            {
                lstFinale.Items.RemoveAt(lstFinale.SelectedIndex);
            }
            counterelementlst();
        }

        private void CboOperateurs_Enter(object sender, EventArgs e)
        {
            lstlastselectitem = 1;
        }

        private void LstEcoles_Enter(object sender, EventArgs e)
        {
            lstlastselectitem = 2;
        }

        private void CboGymnase_Enter(object sender, EventArgs e)
        {
            lstlastselectitem = 3;
        }
    }
}