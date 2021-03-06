﻿//Programme: 12-TestEmail exo de Moodle
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
            txtEmail.Text= txtEmail.Text.Trim();    //enlever les espaces de début et de fin avec Trim():

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

                //CONDITION INUTILE: LA SUIVANTE LA REMPLACE. SI PAS DE CHARS APRES ALORS PAS PLUS DE 4 CHARS APRES !
                //doit avoir des chars après:
                //if (indexate != -1) //ne pas compter si il n'y pas de @:
                //{
                //    if (indexate + 1 < longmail)    //correction procédurale. avant c'était if (indexate + 1 < longmail): si le lastchar était @ alors rentrait quand meme alors nbcondtrue était 1 de trop grand. Ce problème ne changeait rien pour le résultat final car la conditions suivante n'étant pas respectée c'était quand meme faux. Erreur détectée avec l'aide par Altin Zili.
                //    {
                //        nbcondtrue++;
                //        txtCharsApres.Text = (longmail - indexate - 1).ToString();
                //    }
                //    else
                //    {
                //        txtCharsApres.Text = "0";
                //    }
                //}
                //else
                //{
                //    txtCharsApres.Text = "0";
                //}

                //Il faut quand même afficher combien il y a de chars après:
                txtCharsApres.Text = (longmail - indexate - 1).ToString();

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

                //Par contre il faut vérifier si il n'y a pas d'espace:
                if (txtEmail.Text.IndexOf(" ") == -1)
                {
                    nbcondtrue++;
                }
                else
                {
                    MessageBox.Show("Il y a un espace dans l'email. Il ne sera pas valide...");
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
