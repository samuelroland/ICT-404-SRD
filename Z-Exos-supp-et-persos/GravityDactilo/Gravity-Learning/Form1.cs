//Programme: Travail personnel appelé GravityDactylo, voir documentation en .docx .
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
        const int hghtast=61;

        //Déclarations des variables globales:
        int numerogalaxie = 1;  //numéro de la galaxie en cours. correspond aux photos et aux niveaux.
        bool inrun = false; //définit si le programme est en cours ou pas.

        public frmGravityDactylo()
        {
            InitializeComponent();
        }

        private void FrmGravityDactylo_Load(object sender, EventArgs e)
        {
            
            //Mettre tous les labels au départ en haut 
            pctAst1.Location = new Point(x: 491, y: -50);
            lblAst1.Location = new Point(x: 491, y: -50 + hghtast);

            pctAst2.Location = new Point(x: 491, y: -50);
            lblAst2.Location = new Point(x: 491, y: -50 + hghtast);

            pctAst3.Location = new Point(x: 491, y: -50);
            lblAst3.Location = new Point(x: 491, y: -50 + hghtast);

            pctAst4.Location = new Point(x: 491, y: -50);
            lblAst4.Location = new Point(x: 491, y: -50 + hghtast);

            pctAst5.Location = new Point(x: 491, y: -50);
            lblAst5.Location = new Point(x: 491, y: -50 + hghtast);

            pctAst6.Location = new Point(x: 491, y: -50);
            lblAst6.Location = new Point(x: 491, y: -50 + hghtast);
        }

        private void TmrVitesse_Tick(object sender, EventArgs e)
        {
            //Pour les positions du pctAst
            int pcty = pctAst1.Location.Y;
            int pctx = pctAst1.Location.X;
            //... et du lblAst:
            int lblx = lblAst1.Location.X;
            int lbly = lblAst1.Location.Y;

            pctAst1.Location = new Point(x: pctx + 0, y: pcty + 1);
            lblAst1.Location = new Point(x: lblx + 0, y: lbly + 1);


            // plus tard:  prgProgressionJeu.Value = y / 5;
        }

        private void CmdReDemarrer_Click(object sender, EventArgs e)
        {
            cmdReDemarrer.Text = "Redémmarer ?";
            play();
        }

        private void play()
        {
            //charger les mots...
            string[] mots = { "salut", "bonjour", "asdf", "poiuz", "tchao", " ademin" };
            lblAst1.Text = mots[0];
            lblAst2.Text = mots[1];
            lblAst3.Text = mots[2];
            lblAst4.Text = mots[3];
            lblAst5.Text = mots[4];
            lblAst6.Text = mots[5];

            //Une fois que les 6 premiers astéroides sont chargés, on peut lancer le timer:
            tmrVitesse.Enabled = true;
        }

        //Fonction pour changer de galaxie, changer l'image de fond:
        private void changergalaxie()
        {
            numerogalaxie++;
            MessageBox.Show(numerogalaxie.ToString());
            switch (numerogalaxie)
            {
                case 2:
                    grpEspace.BackgroundImage = Properties.Resources.espace2;
                    break;
                case 3:
                    grpEspace.BackgroundImage = Properties.Resources.espace3;
                    break;
                case 4:
                    grpEspace.BackgroundImage = Properties.Resources.espace4;
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
                inrun = false;
                //Mettre le timer en pause:
                tmrVitesse.Enabled = false;
                //Mettre le champ de texte désactivé (pour qu'on ne puisse pas écrire quand c'est en pause):
                txtZoneFrappe.Enabled = false;   
            }
            else
            {
                cmdPause.Text = "Pause";
                inrun = true;
                //Mettre le timer actif:
                tmrVitesse.Enabled = true;
                //Mettre le champ de texte activé:
                txtZoneFrappe.Enabled = true;
                //Mettre le focus sur le champ pour pouvoir réécrire directement la suite.
                txtZoneFrappe.Focus();
            }
        }
    }
}
