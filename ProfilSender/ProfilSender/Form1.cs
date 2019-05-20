//Projet: Trombinoscope Samuel + Fabien. Dernier exo de Moodle.
//Auteur: Samuel Roland
//Date: mai 2019.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //permet d'écrire et de lire dans un fichier. mais pas que.   

namespace ProfilSender
{
    public partial class frmProfilSender : Form
    {
        int dejaecrit;  //définit si on a deja écrit un texte. permet d'envoyer le profil que quand tout rempli.

        public frmProfilSender()
        {
            InitializeComponent();
        }
        private void ecriredansunfichier()
        {
            //variables pour les choix, elles seront directement écrites dans le fichier.
            int presence;
            int humeur = 0;     // de 1 à 5 dans l'ordre: Content, Cool, Nerveux, Pas content, Angélique
            string commentaire;

            //Prendre les données:

            //Présence:
            if (chkPresent.Checked == false)
            {
                presence = 0;
            }
            else
            {
                presence = 1;
            }
            //Humeur:
            if (optContent.Checked == true)
            {
                humeur = 1;
            }
            if (optCool.Checked == true)
            {
                humeur = 2;
            }
            if (optNerveux.Checked == true)
            {
                humeur = 3;
            }
            if (optPasContent.Checked == true)
            {
                humeur = 4;
            }
            if (optAngelique.Checked == true)
            {
                humeur = 5;
            }


            //Texte commentaire:
            commentaire = txtMessage.Text;



            //Exemple pour lire dans un fichier:

            // Essai de lecture d'un fichier:
            // string ligne = null;
            // StreamReader fluxInfos = null;
            // 
            // 
            // using (fluxInfos = new StreamReader("infos.txt"))
            // {
            //     
            //     do
            //     {
            //         ligne = fluxInfos.ReadLine();
            //         txtMessage.Text += ligne + "\r\n";
            //     } while (ligne != null);
            // }

            //Ecriture dans un fichier:
            string ligne = null;
            StreamWriter fluxinfos = null;
            try
            {
                using (fluxinfos = new StreamWriter("infos.txt"))   // si on créé un fichier il écrase l'ancien du meme nom.
                {
                    //Ecrire les 3 infos:
                    fluxinfos.WriteLine(presence);
                    fluxinfos.WriteLine(humeur);
                    fluxinfos.WriteLine(commentaire);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur avec le fichier !");
            }

        }
        private void FrmProfilSender_Load(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            MessageBox.Show(username);
            this.Text = username;
        }

        private void ChkPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }
        }

        private void OptContent_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }
        }

        private void OptCool_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }
        }

        private void OptNerveux_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }
        }

        private void OptPasContent_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }
        }

        private void OptAngelique_CheckedChanged(object sender, EventArgs e)
        {
            if (dejaecrit == 1)
            {
                ecriredansunfichier();
            }

        }

        private void TxtMessage_Validated(object sender, EventArgs e)   //Au moment de la validationd du texte. pas pendant qu'on écrit.
        {
            dejaecrit = 1;
            ecriredansunfichier();
        }
    }

}