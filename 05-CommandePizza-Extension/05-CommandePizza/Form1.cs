//Projet: Exo 05-CommandePizza de Moodle.
//Samuel Roland
//mai 2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Check pour les interdits:

            //pas de jambon et de crevettes ensemble:
            if (chkJambon.Checked==true && chkCrevettes.Checked==true)
            {
                MessageBox.Show("STOP ! Jambon et crevettes ensemble, c'est interdit !");
            }


            //Vider le champ rtf:
            lblResultatCommande.Text = "";
            //Ecrire le début + numero de table:
            lblResultatCommande.Text += "Pour la " + txtTable.Text + ": pâte ";
            //Ajouter le type de pâte:
            if (optExtrafine.Checked == true)
            {
                lblResultatCommande.Text += "extra-fine";
            }

            if (optFine.Checked == true)
            {
                lblResultatCommande.Text += "fine";
            }

            if (optNormale.Checked == true)
            {
                lblResultatCommande.Text += "normale";
            }

            if (optEpaisse.Checked == true)
            {
                lblResultatCommande.Text += "épaisse";
            }

            //Ajouter les garnitures:
            lblResultatCommande.Text += " avec ";
            if (chkAnchois.Checked == true)
            {
                lblResultatCommande.Text += "anchois, ";
            }

            if (chkCapres.Checked == true)
            {
                lblResultatCommande.Text += "câpres, ";
            }

            if (chkJambon.Checked == true)
            {
                lblResultatCommande.Text += "jambon, ";
            }

            if (chkCrevettes.Checked == true)
            {
                lblResultatCommande.Text += "crevettes, ";
            }

            if (txtTable.Text !="") //Si le champ table n'est pas vide.
            {
                //Enlever la dernière virgule à la fin. Il construit la chaine totale avant de remplacer. OUF !
            //On part du char 0 puis on prend le nb de char (length=longueur) -2 pour enlever ", ":
            lblResultatCommande.Text = lblResultatCommande.Text.Substring(0, lblResultatCommande.Text.Length-2);
            }
            else
            {
                lblResultatCommande.Text = "";  //De plus, si on ne vide pas il y a le texte avec la virgule de fin.
                MessageBox.Show("Erreur ! Donnez le numéro de la table !");
            }
        }

        private void txtTable_TextChanged(object sender, EventArgs e)
        {
            //Check si il y un numero de table:
            if (txtTable.Text=="")
            {
                //Si le numero de table est vide, mettre toutes les options invisibles.
                optEpaisse.Visible = false;
                optExtrafine.Visible = false;
                optFine.Visible = false;
                optNormale.Visible = false;
                chkCrevettes.Visible = false;
                chkAnchois.Visible = false;
                chkCapres.Visible = false;
                chkJambon.Visible = false;
            }
            else
            {
                //Sinon les réafficher.
                optEpaisse.Visible = true;
                optExtrafine.Visible = true;
                optFine.Visible = true;
                optNormale.Visible = true;
                chkCrevettes.Visible = true;
                chkAnchois.Visible = true;
                chkCapres.Visible = true;
                chkJambon.Visible = true;
            }
        }

        private void frmCommandePizza_Load(object sender, EventArgs e)
        {
            txtTable.Text = ""; //Vider et ca fera disparaitre les options.
        }
    }
}
