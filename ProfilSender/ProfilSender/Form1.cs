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
        string username = Environment.UserName;
        
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
        if (optContent.Checked)
        {
            humeur = 1;
        }
        if (optCool.Checked)
        {
            humeur = 2;
        }
        if (optNerveux.Checked)
        {
            humeur = 3;
        }
        if (optPasContent.Checked)
        {
            humeur = 4;
        }
        if (optAngelique.Checked)
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
        //Création du fichier:

        try
        {
            using (fluxinfos = new StreamWriter(username + ".txt"))   // si on créé un fichier il écrase l'ancien du meme nom.
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

            //Traiter le nom d'utilisateur:
            //Enlever jusqu'au '.':

            //Trouver la position du point:
            for (int i = 0; i < username.Length; i++)
            {
                //WIP ici.
            }
            

            //Le texte du frm prendra la valeur de username:
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

    private void TxtMessage_Validated(object sender, EventArgs e)   //Au moment de la validation du texte. pas pendant qu'on écrit.
    {
        dejaecrit = 1;
        ecriredansunfichier();
    }
}

}