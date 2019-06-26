//Programme 07: Arche de Noé, Moodle
//Samuel Roland
//3.06.2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                //Activer le bouton inverse:
                cmdMettreATerre.Enabled = true;
                //Créer un nouvel Item dans la liste de droite.
                lstABord.Items.Add(lstATerre.SelectedItem.ToString());
                //Enlever l'item ancien de la liste de gauche.
                lstATerre.Items.RemoveAt(lstATerre.SelectedIndex);
            }
            //Si il n'y a pas d'Items dans la liste de gauche, désactiver le button MettreABord
            if (lstATerre.Items.Count == 0)
            {
                cmdMettreABord.Enabled = false;

            }
            sauverpartie();
        }

        private void cmdMettreATerre_Click(object sender, EventArgs e)
        {
            if (lstABord.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur. Aucun animal sélectionné !");
            }
            else
            {
                //Activer le bouton inverse:
                cmdMettreABord.Enabled = true;
                //Créer un nouvel Item dans la liste de gauche.
                lstATerre.Items.Add(lstABord.SelectedItem.ToString());
                //Enlever l'item ancien de la liste de droite.
                lstABord.Items.RemoveAt(lstABord.SelectedIndex);
            }
            //Si il n'y a pas d'Items dans la liste de droite, désactiver le button MettreATerre
            if (lstABord.Items.Count == 0)
            {
                cmdMettreATerre.Enabled = false;
            }
            //Déclencher l'écriture dans le fichier pour sauver les animaux à bord.
            sauverpartie();
        }
        void sauverpartie()
        {
            StreamWriter ecrire = null;
            try
            {
                using (ecrire = new StreamWriter("applicationenpause.txt"))
                {
                    //Ecrire le commentaire:
                    ecrire.WriteLine("//Listes des Items à bord lors de la dernière fermeture du formulaire.");
                    foreach (Object Itemsabord in lstABord.Items)
                    {

                        ecrire.WriteLine(Itemsabord);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void frmArcheDeNoe_Load(object sender, EventArgs e)
        {
            //Nettoyer tous les élements de la liste de droite:
            lstABord.Items.Clear();
            //Désactiver le button MettreATerre:
            cmdMettreATerre.Enabled = false;
            //Charger le fichier applicationenpause.txt pour déplacer les items qui sont à bord:
            StreamReader lecteurfichier = null;
            string iteminrun = "salut";
            try
            {
                using (lecteurfichier = new StreamReader("applicationenpause.txt"))
                {

                    while (iteminrun != "")
                    {
                        iteminrun = lecteurfichier.ReadLine();
                        if (lstATerre.Items.Contains(iteminrun))
                        {
                            lstABord.Items.Add(iteminrun);
                            lstATerre.Items.Remove(iteminrun);
                        }
                    }
                }
                MessageBox.Show(iteminrun);

            }
            catch (Exception)
            {

            }

        }

        private void lstABord_DoubleClick(object sender, EventArgs e)
        {
            int nbitem = lstABord.Items.Count;
            for (int i = 0; i < nbitem; i++)
            {
                //Créer un nouvel Item dans la liste de gauche.
                lstATerre.Items.Add(lstABord.Items[0].ToString());  //L'item 0, car une fois enlevé, la liste repars de 0. l'élement suivant a donc comme index 0.
                //Enlever l'item ancien de la liste de droite.
                lstABord.Items.RemoveAt(0);
            }
        }

    }
}
