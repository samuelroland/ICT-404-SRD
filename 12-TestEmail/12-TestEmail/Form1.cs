//Programme: 12-TestEmail exo de Moodle
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

namespace _12_TestEmail
{
    public partial class frmTestEmail : Form
    {
        public frmTestEmail()
        {
            InitializeComponent();
        }

        private void CmdVerifier_Click(object sender, EventArgs e)
        {
            int nbcondtrue = 0; //nb de conditions correctes. si ==4 alors l'email est valide.
            if (txtEmail.Text == "")
            {
                lblEmailAVerif.ForeColor = Color.Red;
                MessageBox.Show("Veuillez remplir le champ Email afin de procéder à sa vérification, svp", "Champ Email Vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Calculer l'index du @:
                int indexate = txtEmail.Text.IndexOf("@");  //la position du @
                int longmail = txtEmail.Text.Length;    //la longueur de l'email.

                //Check entier de l'email:
                //doit avoir un @:
                if (indexate != -1)
                {
                    nbcondtrue++;
                    chkAtePresent.Checked = true;
                }
                else
                {
                    chkAtePresent.Checked = false;
                }
                //doit avoir des chars avant:
                if (indexate > 0)
                {
                    nbcondtrue++;
                    txtCharsAvant.Text = indexate.ToString();
                }
                else
                {
                    txtCharsAvant.Text = "0";
                }
                //doit avoir des chars après:

                if (indexate != -1) //ne pas compter si il n'y pas de @:
                {
                    if (indexate < longmail)
                    {
                        nbcondtrue++;
                        txtCharsApres.Text = (longmail - indexate - 1).ToString();
                    }
                    else
                    {
                        txtCharsApres.Text = "0";
                    }
                }
                else
                {
                    txtCharsApres.Text = "0";
                }

                //doit avoir au moins 4 chars après le @. Et doit avoir un point après le @:
                if (indexate != -1) //ne pas compter si il n'y pas de @:
                {
                    if (longmail - indexate - 1 >= 4 && txtEmail.Text.LastIndexOf(".") > indexate)
                    {
                        nbcondtrue++;
                        chkPointPresent.Checked = true;
                    }
                    else
                    {
                        chkPointPresent.Checked = false;
                    }
                }
                else
                {
                    chkPointPresent.Checked = false;
                }

                //Si les ces 4 conditions sont remplies, l'adresse est valide:
                if (nbcondtrue == 4)
                {
                    lblUsername.Text = txtEmail.Text.Substring(0, indexate);
                    lblResult.Text = "L'adresse est correctement formée";
                    lblUsername.Enabled = true;
                }
                else
                {
                    lblUsername.Text = "";
                    lblResult.Text = "L'adresse n'est pas correctement formée";
                    lblUsername.Enabled = false;
                }
            }
        }

        private void FrmTestEmail_Load(object sender, EventArgs e)
        {
            //Initialisation du formulaire au démarrage:
            txtCharsAvant.Text = "2";
            txtCharsApres.Text = "4";
            //champ lblUsername:
            lblUsername.Text = "";
            lblUsername.Enabled = false;
            lblUsername.ForeColor = Color.Black;
            lblUsername.BackColor = Color.White;
        }
    }
}
