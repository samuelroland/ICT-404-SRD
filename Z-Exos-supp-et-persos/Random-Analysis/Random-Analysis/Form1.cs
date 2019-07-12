//Programme perso: Random-Analysis permet de voir visuellement les nombres générés aléatoirement entre 1 et nbmax (voir constantes). 
//Détails: Des trackbar montrent combien de fois les nombres ont été choisis et un label affiche la valeur.
//Auteur: Samuel Roland
//Date: juillet 2019
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

namespace Random_Analysis
{
    public partial class frmRandomAnalysis : Form
    {
        //Définition des constantes du programme:
        const int nbmax = 50;//nombre max généré random.
        const int esptkb = 10;//espace en pixel entre les trackbar
        const int margebord = 29;
        const int margemilieutkb = 5;  //marge pour avoir la tkb au-dessus du label lblNum. 
        const int yfortkb = 81;

        const int xfornumnb = 29;   //pos x de base en horizontal pour lblNum et lblNb

        const int yfornum = 413;   //pos y de base en horizontal pour lblNum
        const int yfornb = 437;   //idem pour lblNb

        const int xtaillenumnb = 22;  //taille en x des objets lblNum et lblNb
        const int ytaillenumnb = 15;  //taille en y des objets lblNum et lblNb
        const int xtailletkb = 10;  //taille en x de tkb

        int maxdefois = 100;  //max de fois que le nombre peut etre tiré. = à la hauteur des trackbar
        int nbrandomparsec = 1; //paramètre pour generer() donc nb de fois quon génére par millisecondes. déduit selon maximun pour avoir 20 secondes environ.

        Random generator = new Random();
        Label pasdobjet;   //pas d'objet, donc si la fonction retourne cette objet c'est que il n'y a pas d'objet.
        TrackBar pasdobjettkb;  //idem pour trackbar
        bool[] nbsaffiche = new bool[nbmax + 1];  //tableau pour savoir quel nombre sont déjà affiché. à l'emplacement du numéro: false or true. commence de 1 ! --> nbmax
        int nbnbsaffiche = 0;


        //Collection de tkb
        List<Label> labelscollection = new List<Label>();
        List<TrackBar> tkbcollection = new List<TrackBar>();
        List<Label> lblcollection = new List<Label>();


        public frmRandomAnalysis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Mettre le tableau de nbsaffiche à 0 partout jusqu'à nbmax:
            for (int i = 1; i <= nbmax; i++)
            {
                nbsaffiche[i] = false;
            }
        }

        int nblignestxt = 0;
        private void generer(int repetition)
        {
            for (int i = 0; i < repetition; i++)
            {
                int rand = 0;
                //On le désactive pour ne pas pouvoir l'activer.
                //cmdLancer.Enabled = false;

                //Génération random:
                rand = generator.Next(1, nbmax + 1);

                //Est-il déjà affiché sur le formulaire ? pour cela on regarde dans le tableau de nbsaffiche:
                if (nbsaffiche[rand] == false)
                {
                    //Créer les 3 objets pour le numéro:
                    TrackBar tkbNum = new TrackBar();
                    Label lblNum = new Label();
                    Label lblNb = new Label();

                    // 
                    // lblNb
                    // 
                    lblNb.BorderStyle = BorderStyle.FixedSingle;
                    lblNb.Location = new Point(xfornumnb + (rand - 1) * xtaillenumnb, yfornb);
                    lblNb.Name = "lblNb" + rand;
                    lblNb.Size = new Size(xtaillenumnb, ytaillenumnb);
                    lblNb.Text = "1";
                    // 
                    // lblNum
                    // 
                    lblNum.BorderStyle = BorderStyle.FixedSingle;
                    lblNum.Location = new Point(xfornumnb + (rand - 1) * xtaillenumnb, yfornum);
                    lblNum.Name = "lblNum" + rand;
                    lblNum.Size = new Size(xtaillenumnb, ytaillenumnb);
                    lblNum.Text = rand.ToString();
                    lblNum.TextAlign = ContentAlignment.MiddleRight;
                    // 
                    // tkbNum
                    // 
                    tkbNum.AutoSize = false;
                    tkbNum.LargeChange = 0;
                    tkbNum.Location = new Point(lblNum.Location.X + margemilieutkb, yfortkb);    //marge du bord + marge au dessus du milieu de lblNum + nbnbsaffiche * (espacetkb + xtailletkb)
                    tkbNum.Maximum = maxdefois;
                    tkbNum.Name = "tkbNum" + rand;
                    tkbNum.Orientation = Orientation.Vertical;
                    tkbNum.Size = new Size(xtailletkb, 306);
                    tkbNum.SmallChange = 0;

                    //Ajout des 3 objets au frm:
                    Controls.Add(tkbNum);
                    Controls.Add(lblNum);
                    Controls.Add(lblNb);

                    //Ajout à la collection:
                    tkbcollection.Add(tkbNum);
                    lblcollection.Add(lblNum);
                    lblcollection.Add(lblNb);

                    nbnbsaffiche++;
                    nbsaffiche[rand] = true;
                }
                else
                {
                    //Si il est déjà affiché, prendre la tkb du numéro et incrémenter sa valeur.
                    //INFO: 3 objets pour un numéro: le tkbNum (tkb.value = nbfois que numéro tirés), le lblNum (numéro) et lblNb (nb de fois tirés)

                    TrackBar tkbinrun = scantkb(("tkbNum" + rand).ToString()) as TrackBar;
                    Label lblinrun = scanlbl("lblNb" + rand) as Label;
                    if (tkbinrun.Value < maxdefois)
                    {
                        tkbinrun.Value++;
                        lblinrun.Text = tkbinrun.Value.ToString();
                        if (tkbinrun.Value == maxdefois)
                        {
                            lblinrun.BackColor = Color.Red;
                        }
                    }

                }


                //Est-ce que plusieurs fois le meme nombre sort à la suite ?
                txtRandomResult.Text += rand + ", ";
                if (rand == 4)
                {
                    txtRandomResult.Text += "\r\n";
                    nblignestxt++;

                }

            }
        }
        public TrackBar scantkb(string name)
        {
            foreach (TrackBar tkbinrun in tkbcollection)
            {
                if (tkbinrun.Name == name)
                {
                    return tkbinrun;
                }

            }
            return pasdobjettkb;
        }
        Label scanlbl(string name)
        {
            foreach (Label lblinrun in lblcollection)
            {
                if (lblinrun.Name == name)
                {
                    return lblinrun;
                }
            }
            return pasdobjet;
        }

        private void TmrRandomGenerator_Tick(object sender, EventArgs e)
        {
            //lancer la génération:
            generer(maxdefois);

            //Extension: La plus grande différence (entre le point le plus haut et le point le plus bas) des tkb actuellement affichées:
            int nbplushaut = 0;
            int nbplusbas = maxdefois;
            foreach (TrackBar tkbinrun in tkbcollection)
            {
                if (tkbinrun.Value > nbplushaut)
                {
                    nbplushaut = tkbinrun.Value;
                }
                if (tkbinrun.Value < nbplusbas)
                {
                    nbplusbas = tkbinrun.Value;
                }
            }
            lblDifferenceMax.Text = "Différence entre sommet et plus bas: " + (nbplushaut - nbplusbas).ToString();

        }
        bool inrun = false;
        private void CmdLancer_Click(object sender, EventArgs e)
        {
            if (txtMaxNbFois.Text != "")
            {
                if (inrun == false)
                {
                    tmrRandomGenerator.Enabled = true;
                    cmdLancer.Text = "Pause...";
                    inrun = true;
                }
                else
                {
                    tmrRandomGenerator.Enabled = false;
                    cmdLancer.Text = "Relancer !";
                    inrun = false;
                }
                //Définir max de fois avec la donnée de la txt
                maxdefois = int.Parse(txtMaxNbFois.Text);
                //Déduire la vitesse:
                nbrandomparsec = maxdefois / 50; //Attention la puissance...
            }
            else
            {
                MessageBox.Show("Erreur. Donner un maximun !");
            }


        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            int numerolabel = 1;
            StreamWriter ecrivain = null;
            try
            {
                using (ecrivain = new StreamWriter("resultats.csv"))
                {
                    //Intro en-tête du fichier:
                    ecrivain.WriteLine("Numéros;Nombres de fois tirés");
                    foreach (Label lblinrun in lblcollection)
                    {
                        ecrivain.WriteLine(numerolabel + ";" + lblinrun.Text);  //; pour le format csv
                        numerolabel++;
                    }
                }
                MessageBox.Show("Correctement sauvé !");
            }
            catch (Exception)
            {
                MessageBox.Show("Problème avec le fichier ! pas pu sauver les résultats...", "Erreur de fichier");
            }
        }

        private void TmrEcriture_Tick(object sender, EventArgs e)
        {
            CmdSave_Click(sender, e);
        }
    }

}
