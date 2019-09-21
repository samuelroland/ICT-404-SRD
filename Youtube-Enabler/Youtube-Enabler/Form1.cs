/*
 Programme: ce programme sert à désactiver l'accès à youtube selon les envies. Pour cela, il rajoute ou enlève une ligne dans le fichier hosts de l'ordinateur.
 Option: désactiver un certain temps le programme et pouvoir le fermer et le rouvrir sans perdre ce temps.
 Auteur: Samuel Roland
 Date: 07.07.2019
 */

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

namespace Youtube_Enabler
{
    public partial class frmYoutubeEnabler : Form
    {
        public frmYoutubeEnabler()
        {
            InitializeComponent();
        }
        private void FrmYoutubeEnabler_Load(object sender, EventArgs e)
        {
            gereroptions(); //pour initialiser l'affichage des options.
            //afficher le temps si en cours et bloquer options sur choix durée:

        }

        private void CmdDesactiver_Click(object sender, EventArgs e)
        {
            activation(false);

        }

        private void CmdActiver_Click(object sender, EventArgs e)
        {
            activation(true);
        }


        private void CmdDesactiverTemps_Click(object sender, EventArgs e)
        {
            if (cmdDesactiverTemps.Text == "Désactiver")
            {
                activation(false);
                //TODO: gérer le temps avec le fichier.


                //Changer le texte du bouton:
                cmdDesactiverTemps.Text = "Activer ?";

            }
            else
            {   //si on veut activer, on doit faire un check du fichier.
                tempsrestant();

                //si le fichier nexiste pas ou alors que le temps est dépassé, on peut réactiver:
                activation(true);


                //Changer le texte du bouton:
                cmdDesactiverTemps.Text = "Désactiver";
            }
            //si le fichier qui contient le datetime à laquelle l'accès à youtube est bloqué, existe:

            //lire le temps pour savoir si c'est fini.



        }

        void activation(bool wantactivate)
        {
            StreamWriter ecrivain = null;

            using (ecrivain = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts"))
            {
                if (wantactivate == false)    //si on veut que l'état activité soit faux (donc desactivé) on écrit une ligne dans le fichier hosts.
                {
                    string cmdforenable = "127.0.0.1	www.youtube.com";
                    ecrivain.Write(cmdforenable);
                    lblEtat.Text = "Etat actuel: désactivé";
                }
                else
                {
                    string cmdforenable = "#No websites to block now with Youtube-Enabler.";
                    ecrivain.Write(cmdforenable);
                    lblEtat.Text = "Etat actuel: activé";
                }

            }
            //Vider le cache DNS:
            Console.WriteLine("ipconfig/flushdns");
        }

        private void RdbChoixManuel_CheckedChanged(object sender, EventArgs e)
        {
            gereroptions();
        }
        private void RdbChoixTemps_CheckedChanged(object sender, EventArgs e)
        {
            gereroptions();
        }

        void gereroptions()
        {
            if (rdbChoixManuel.Checked)
            {
                //comme le choix est manuel.
                //tout activer coté choix manuel.
                cmdDesactiver.Enabled = true;
                cmdActiver.Enabled = true;

                //tout désactiver coté choix du temps.
                cmdDesactiverTemps.Enabled = false;
                txtChoixDuree.Enabled = false;

            }
            else
            {
                //Donc le choix est la durée.

                //tout activer coté choix manuel.
                cmdDesactiverTemps.Enabled = true;
                txtChoixDuree.Enabled = true;


                //tout désactiver coté choix du temps.
                cmdDesactiver.Enabled = false;
                cmdActiver.Enabled = false;

            }
        }



        private void TxtChoixDuree_TextChanged(object sender, EventArgs e)
        {
            float timetoblock;  //temps ä blocker.
            if (float.TryParse(txtChoixDuree.Text, out timetoblock))
            {
                txtChoixDuree.BackColor = Color.Chartreuse;
            }
            else
            {
                txtChoixDuree.BackColor = Color.IndianRed;
            }
        }
        DateTime timetoblock;
        string strngtimetoblock;
        bool autorizedactivation = false;

        bool tempsrestant()
        {
            string filecontent; //contient le contenu du fichier texte.
            StreamReader lecteur;
            bool found = false; //défini si le fichier a été trouvé et est valide, et quon peut prendre la valeur de timetoblock:

            //Chercher un fichier dans %appdata%/Youtube-Enabler:
            if (File.Exists("%appdata%\\Youtube-Enabler\\time.cnfg"))
            {
                try
                {
                    using (lecteur = new StreamReader("%appdata%\\Youtube-Enabler\\time.cnfg"))
                    {
                        filecontent = lecteur.ReadToEnd();
                    }
                    strngtimetoblock = filecontent.Substring(filecontent.IndexOf("\\") + 1, filecontent.Length - filecontent.IndexOf("\\") - 1);
                    //convertir strngtimetoblock en date pour timetoblock:
                    timetoblock= DateTime.Parse(strngtimetoblock);
                    MessageBox.Show(timetoblock.ToString());

                }
                catch (Exception)
                {
                    lblError.Text = "Erreur: fichier corrompu... désactivation impossible";
                }

            }
            else
            {
                //si le fichier n'existe pas
                autorizedactivation = true;
            }

            return found;
        }


    }
}

