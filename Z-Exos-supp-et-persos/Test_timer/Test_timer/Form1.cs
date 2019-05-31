//Projet: Tests perso différentes utilisation d'un timer
//Samuel Roland
//31.05.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_timer
{
    public partial class frmTimers : Form
    {
        int counter = 0;    //Compteur de secondes:
        int counter2 = 0;     //Compteur selon la vitesse donnée par le cursor
        int interval;       //Calcul l'intervalle avant de la mettre dans le timer.
        public frmTimers()
        {
            InitializeComponent();
        }
        private void FrmTimers_Load(object sender, EventArgs e)
        {
            //Mettre counter dans le texte du compteur:
            lblSecondesCounter.Text = counter.ToString();
            cmdSecondes.Text = "Start !";

            //Enclencher le timer 2 Cursor:
            tmrCursor.Enabled = true;

            //Executer une fois pour avoir interval:
            ChangerFrequenceTimerCursor();
            lblInterval.Text = "Interval timer: " + interval;
        }
        private void CmdSecondes_Click(object sender, EventArgs e)
        {
            if (tmrSecondes.Enabled)
            {
                tmrSecondes.Enabled = false;
                cmdSecondes.Text = "Start !";
            }
            else
            {
                tmrSecondes.Enabled = true;
                cmdSecondes.Text = "Stop !";
            }
        }

        private void TmrSecondes_Tick(object sender, EventArgs e)
        {
            //A l'évenement Tick du tmrSecondes il faut afficher la nouvelle valeur de counter:
            counter++;
            lblSecondesCounter.Text = counter.ToString();
        }

        private void ChangerFrequenceTimerCursor()
        {
            //Changer la fréquence du timer:
            
            interval = (100 - (sldVitesseTimerCursor.Value)) * 10;
            //Traiter interval selon les cas:
            switch (interval)
            {
                case 0:
                    //Intervalle de 0 interdite:
                    interval += 10;
                    break;
                case 1000:
                    //Ne rien faire: 1000 accepté comme intervalle. = à 1 seconde
                default:
                    //Ne pas traiter interval
                    break;
            }
            lblInterval.Text = "Interval timer: " + interval;
            tmrCursor.Interval = interval;
        }

        private void TmrCursor_Tick(object sender, EventArgs e)
        {
            counter2++;
            lblCursor.Text = counter2.ToString();
        }

        private void SldVitesseTimerCursor_Scroll(object sender, EventArgs e)
        {
            ChangerFrequenceTimerCursor();
        }
    }
}
