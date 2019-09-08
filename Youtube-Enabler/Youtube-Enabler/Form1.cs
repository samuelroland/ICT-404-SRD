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
            //si le fichier qui contient le datetime à laquelle l'accès à youtube est bloqué, existe:
            
            //lire le temps pour savoir si c'est fini.

            activation(false);
        }

        void activation(bool stateactivited)
        {
            StreamWriter ecrivain = null;

            using (ecrivain = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts"))
            {
                if (stateactivited == false)    //si on veut que l'état activité soit faux (donc desactivé) on écrit une ligne dans le fichier hosts.
                {
                    string cmdforenable = "127.0.0.1	www.youtube.com";
                    ecrivain.Write(cmdforenable);
                    lblEtat.Text = "Etat actuel: désactivé";
                }
                else
                {
                    string cmdforenable = "127.0.0.1	www.youtube.com";
                    ecrivain.Write(cmdforenable);
                    lblEtat.Text = "Etat actuel: désactivé";
                }

            }
            //Vider le cache DNS:
            Console.WriteLine("ipconfig/flushdns");
        }
    }
}

