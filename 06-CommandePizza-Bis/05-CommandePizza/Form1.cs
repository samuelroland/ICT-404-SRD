//Projet: Exo 06-CommandePizza-Bis de Moodle. Partie BIS attention!!!!
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
using System.IO;

namespace _05_CommandePizza
{
    public partial class frmCommandePizza : Form
    {
        public frmCommandePizza()
        {
            InitializeComponent();
        }

        private void cmdCommander_Click(object sender, EventArgs e)
        {
            string resultatcommande;
            //Vider le champ rtf:
            resultatcommande = "";
            //Ecrire le début + numero de table:
            resultatcommande += "Pour la " + txtTable.Text + ": pâte ";
            //Ajouter le type de pâte:
            if (optExtrafine.Checked == true)
            {
                resultatcommande += "extra-fine";
            }

            if (optFine.Checked == true)
            {
                resultatcommande += "fine";
            }

            if (optNormale.Checked == true)
            {
                resultatcommande += "normale";
            }

            if (optEpaisse.Checked == true)
            {
                resultatcommande += "épaisse";
            }

            //Ajouter les garnitures:
            resultatcommande += " avec ";
            if (chkAnchois.Checked == true)
            {
                resultatcommande += "anchois, ";
            }

            if (chkCapres.Checked == true)
            {
                resultatcommande += "câpres, ";
            }

            if (chkJambon.Checked == true)
            {
                resultatcommande += "jambon, ";
            }

            if (chkCrevettes.Checked == true)
            {
                resultatcommande += "crevettes, ";
            }

            if (txtTable.Text != "") //Si le champ table n'est pas vide.
            {
                //Enlever la dernière virgule à la fin. Il construit la chaine totale avant de remplacer. OUF !
                //On part du char 0 puis on prend le nb de char (length=longueur) -2 pour enlever ", ":
                resultatcommande = resultatcommande.Substring(0, resultatcommande.Length - 2);
            }
            else
            {
                resultatcommande = "";  //De plus, si on ne vide pas il y a le texte avec la virgule de fin.
                MessageBox.Show("Erreur ! Donnez le numéro de la table !");
            }

            //Envoyer la commande dans le fichier:
            StreamWriter writer = null;
            string filepath = txtRepertoire.Text;
            try
            {
                using (writer = new StreamWriter(filepath + "\\Table " + txtTable.Text + ".txt"))
                {
                    writer.Write(resultatcommande);
                }
                MessageBox.Show("Commande envoyée!");
            }
            catch (Exception)
            {
                //si le répertoire n'existe pas --> msg d'erreur.
                MessageBox.Show("Répertoire non valide!");

            }
        }

        private void CmdChanger_Click(object sender, EventArgs e)
        {
            fbdRepertoire.ShowDialog();
            txtRepertoire.Text = fbdRepertoire.SelectedPath;
        }
    }
}
