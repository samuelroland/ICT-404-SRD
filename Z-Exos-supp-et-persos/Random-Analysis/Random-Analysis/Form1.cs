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

namespace Random_Analysis
{
    public partial class frmRandomAnalysis : Form
    {
        //Définition des constantes du programme:
        int nbmax = 50;//nombre max généré random.
        int esptkb = 10;//espace en pixel entre les trackbar
        int margebord = 29;
        int xfornum = 29;   //pos x de base en horizontal pour lblNum
        int yfornum=413;   //pos y de base en horizontal pour lblNum
        int xfornb = 29;    //idem pour lblNb
        int yfornb = 437;   //idem pour lblNb
        int xtaillenumnb = 22;  //taille en x des objets lblNum et lblNb
        int ytaillenumnb = 15;  //taille en y des objets lblNum et lblNb

        public frmRandomAnalysis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value++;
        }
    }
}
