﻿//Programme: Travail personnel appelé GravityDactylo, voir documentation en .docx .
//Samuel Roland
//juin 2019

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gravity_Learning
{
    public partial class frmGravityDactylo : Form
    {
        //Constantes:
        const int hghtast = 61;
        const int hghtmot = 19;
        const int wdthast = 52;
        const int wdthmot = 161; //A vérifier que ca n'a pas changé!
        const int nbtotmots = 72;    //nombre total de mots disponible, défini dans la doc de projet.
        int hghtesp;    //hauteur de l'espace
        int wghtesp;    //largeur de l'espace

        //Déclarations des variables globales:
        int numerogalaxie = 1;  //numéro de la galaxie en cours. correspond aux photos et aux niveaux.
        bool inrun = false; //définit si le programme est en cours ou pas.
        int yforast = -hghtmot - hghtast;   //position y de départ pour les astéroides.
        int yformot = -hghtmot; //position y de départ pour les mots sous les astéroides.
        int numAst = 1; //Numéro du premier mot actuellement utilisé (de 1 à 72) dans le fichier pour l'astéroide affiché et disparu. utile pour scanner les mots. dernier mot= numAst + 6
        string[] mots = { "", "mot 1", "mot 2", "mot 3", "mot 4", "mot 5", "mot 6", "mot 7", "mot 8", "mot 9", "mot 10", "mot 11", "mot 12", "mot 13", "mot 14", "mot 15", "mot 16", "mot 1", "mot 1", "mot 1", "mot 1", "fille", "topla", "affiche-toi", "astéroide étrange", "commentaire?", "jklé?", "pfoue?", "rotter?", "deigner?", "policeer?", "parleren publi?", "love for me", "testabilité", "asdf", "harr", "hello friends", "hello woeld" };
        //Attention les mots partent à 1 !

        int nbechec = 0;    //nb d'astéroide non explosé.

        int numTick = 0;    //numéro du tick du timer.
        public frmGravityDactylo()
        {
            InitializeComponent();
        }

        private void FrmGravityDactylo_Load(object sender, EventArgs e)
        {
            //Charger. ne changera pas durant la partie.
            hghtesp = grpEspace.Height;
            wghtesp = grpEspace.Height;

            //Lancer les règles du jeu: (second formulaire ?)


        }
        private void placerasthaut()    //placer les astéroides en haut caché avant de lancer le jeu.
        {


            //Choisir par random les position en x des astéroides, entre 0 et 500. Attention à la longueur du mot et de l'Ast
            //Attention, le point 0,0 correspond en haut à gauche de l'espace et non du formulaire !

            //Mettre tous les labels au départ en haut 
            pctAst1.Location = new Point(x: 0, y: yforast);
            lblAst1.Location = new Point(x: 0, y: yformot);

            pctAst2.Location = new Point(x: 450, y: yforast);
            lblAst2.Location = new Point(x: 450, y: yformot);

            pctAst3.Location = new Point(x: 300, y: yforast);
            lblAst3.Location = new Point(x: 300, y: yformot);

            pctAst4.Location = new Point(x: 150, y: yforast);
            lblAst4.Location = new Point(x: 150, y: yformot);

            pctAst5.Location = new Point(x: 120, y: yforast);
            lblAst5.Location = new Point(x: 120, y: yformot);

            pctAst6.Location = new Point(x: 430, y: yforast);
            lblAst6.Location = new Point(x: 430, y: yformot);
        }


        private void CmdReDemarrer_Click(object sender, EventArgs e)
        {
            if (inrun == false)
            {
                cmdReDemarrer.Text = "Redémmarer ?";
                inrun = true;
                //Mettre le timer actif:
                tmrVitesse.Enabled = true;
                txtZoneFrappe.Enabled = true;
            }
            else
            {
                //Alors c'est que la partie est en cours, et qu'il faut remettre les valeurs comme au départ.
                placerasthaut();

            }

            playstart(); //lancer le jeu.
        }

        private void playstart()
        {
            //charger les mots...

            lblAst1.Text = mots[1];
            lblAst2.Text = mots[2];
            lblAst3.Text = mots[3];
            lblAst4.Text = mots[4];
            lblAst5.Text = mots[5];
            lblAst6.Text = mots[6];

            //Une fois que les 6 premiers astéroides sont chargés, on peut lancer le timer:
            //tmrVitesse.Enabled = true;
            inrun = true;
        }

        //Fonction pour changer d'espace, changer l'image de fond:
        private void changergalaxie()
        {
            numerogalaxie++;
            switch (numerogalaxie)
            {
                case 2:
                    grpEspace.BackgroundImage = Properties.Resources.espace2;
                    lblNomEspace.Text = "Espace Interstellaire - Voix lactée";
                    break;
                case 3:
                    grpEspace.BackgroundImage = Properties.Resources.espace3;
                    lblNomEspace.Text = "Espace Interstellaire - Symbiose universique";
                    break;
                case 4:
                    grpEspace.BackgroundImage = Properties.Resources.espace4;
                    lblNomEspace.Text = "Espace Interstellaire - Le système solaire";
                    break;
                default:
                    break;
            }
        }

        private void CmdPause_Click(object sender, EventArgs e)
        {
            if (inrun == true)
            {
                cmdPause.Text = "Reprendre";

                cmdPause.Width = 98;
                inrun = false;
                //Mettre le timer en pause:
                tmrVitesse.Enabled = false;
                //Mettre le champ de texte désactivé (pour qu'on ne puisse pas écrire quand c'est en pause):
                txtZoneFrappe.Enabled = false;
            }
            else
            {
                cmdPause.Text = "Pause";
                cmdPause.Width = 65;
                inrun = true;
                //Mettre le timer actif:
                tmrVitesse.Enabled = true;
                //Mettre le champ de texte activé:
                txtZoneFrappe.Enabled = true;
                //Mettre le focus sur le champ pour pouvoir réécrire directement la suite.
                txtZoneFrappe.Focus();
            }
        }

        private void analysetextefrappe(object sender, EventArgs e)
        {
            int numObj;

            for (int i = 0; i < numAst + 6; i++)
            {


                if (txtZoneFrappe.Text == mots[i])
                {
                    //initialisation de numObj:
                    if (i > 6)
                    {
                        numObj = (i % 6) + 1;
                    }
                    else
                    {
                        numObj = i - numAst + 1;
                    }
                    switch (numObj) //pour viser le 
                    {
                        //Selon l'astéroide trouvé, il faut le cacher (mot + photo) et le remettre en bas, ce qui déclenchera la remontée de celui-ci.
                        //Précision: en bas à gauche car sera de toute facon à une autre position x après et qu'on le voit plus.
                        case 1:
                            lblAst1.Visible = false;
                            pctAst1.Visible = false;
                            pctAst1.Location = new Point(0, wghtesp);
                            break;
                        case 2:
                            lblAst2.Visible = false;
                            pctAst2.Visible = false;
                            pctAst2.Location = new Point(0, wghtesp);

                            break;
                        case 3:
                            lblAst3.Visible = false;
                            pctAst3.Visible = false;
                            pctAst3.Location = new Point(0, wghtesp);
                            break;
                        case 4:
                            lblAst4.Visible = false;
                            pctAst4.Visible = false;
                            pctAst4.Location = new Point(0, wghtesp);
                            break;
                        case 5:
                            lblAst5.Visible = false;
                            pctAst5.Visible = false;
                            pctAst5.Location = new Point(0, wghtesp);
                            break;
                        case 6:
                            lblAst6.Visible = false;
                            pctAst6.Visible = false;
                            pctAst6.Location = new Point(0, wghtesp);
                            break;
                        default:
                            break;
                    }
                    txtZoneFrappe.Text = "";        //vider la zone de texte, le focus reste dessus.
                }
            }
        }
        private void TmrVitesse_Tick(object sender, EventArgs e)
        {
            numTick++;
            Label lbl = lblAst1 as Label;
            PictureBox pct = pctAst1 as PictureBox;
            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        lbl = lblAst1 as Label;
                        pct = pctAst1 as PictureBox;
                        break;
                    case 2:
                        lbl = lblAst2 as Label;
                        pct = pctAst2 as PictureBox;
                        break;
                    case 3:
                        lbl = lblAst3 as Label;
                        pct = pctAst3 as PictureBox;
                        break;
                    case 4:
                        lbl = lblAst4 as Label;
                        pct = pctAst4 as PictureBox;
                        break;
                    case 5:
                        lbl = lblAst5 as Label;
                        pct = pctAst5 as PictureBox;
                        break;
                    case 6:
                        lbl = lblAst6 as Label;
                        pct = pctAst6 as PictureBox;
                        break;
                    default:
                        break;
                }

                pct.Location = new Point(x: pct.Location.X, y: pct.Location.Y + 1);
                lbl.Location = new Point(x: lbl.Location.X, y: lbl.Location.Y + 1);

                if (pct.Location.Y > wghtesp) //quand l'ast arrive en dessous du cadre de l'espace.
                {
                    pct.Location = new Point(x: 450, y: yforast);
                    lbl.Location = new Point(x: 450, y: yformot);

                    if (pct.Visible == false)
                    {
                        //charger le mot suivant:
                        if ((numAst + 6) % 24 == 0)
                        {
                            changergalaxie();
                        }
                        lbl.Text = mots[numAst + 6];  // le tableau commence à 1 !
                        numAst++;   //le premier mot utilisé est donc le suivant.
                    }
                    else //sinon il n'est pas explosé.
                    {
                        nbechec++;
                        pct.BackColor = Color.Red;
                        if (nbechec>5)
                        {
                            echecafficher();
                        }
                    }
                }

                // plus tard:  prgProgressionJeu.Value = y / 5;

            }


        }
        private void echecafficher()
        {
            inrun = false;
            tmrVitesse.Enabled = false;
            MessageBox.Show("Fin du jeu: vous avez fait " + nbechec + " astéroides ! La terre n'a pas résisté et a explosé. vous avez fini avec " + " points.");
            Application.Exit();
        }
    }
}
