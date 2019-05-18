//Exo 04-FenetreBleuRouge
//Samuel Roland
//mai 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _04_FenetreBleuRouge
{
    public partial class frmFenetreBleuRouge : Form
    {
        //Variables pour compter le nombre de déplacements et de changements de couleur:
        private int deplacement = 0;
        private int changcolor = 0;
        private int screensizewidth;
        private int screensizeheight;
        int longueurfrm = 482;
        int hauteurfrm = 498;


        public frmFenetreBleuRouge()
        {
            InitializeComponent();
        }

        private void cmdHautGauche_Click(object sender, EventArgs e)
        {
            SetBounds(0, 0, longueurfrm, hauteurfrm);
            deplacement++;
        }

        private void cmdHautDroite_Click(object sender, EventArgs e)
        {


            SetBounds(screensizewidth - longueurfrm, 0, longueurfrm, hauteurfrm);
            deplacement++;
        }

        private void cmdBasGauche_Click(object sender, EventArgs e)
        {
            SetBounds(0, screensizeheight - hauteurfrm, longueurfrm, hauteurfrm);
            deplacement++;
        }

        private void cmdBasDroite_Click(object sender, EventArgs e)
        {
            SetBounds(screensizewidth - longueurfrm, screensizeheight - hauteurfrm, longueurfrm, hauteurfrm);
            deplacement++;
        }

        private void cmdBleu_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Blue;
            changcolor++;
        }

        private void cmdRouge_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Red;
            changcolor++;
        }

        private void frmFenetreBleuRouge_Load(object sender, EventArgs e)
        {
            //charger la taille de l'écran:
            screensizewidth = Screen.PrimaryScreen.Bounds.Width;
            screensizeheight = Screen.PrimaryScreen.Bounds.Height;
        }

        private void cmdStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deplacement + " déplacement(s), " + changcolor + " changement(s) de couleur.");
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}