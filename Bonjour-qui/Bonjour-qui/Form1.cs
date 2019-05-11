//Exercice Bonjour, Moodle
//Samuel Roland
//05.2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonjour_qui
{
    public partial class frmBonjourQui : Form
    {
        public frmBonjourQui()
        {
            InitializeComponent();
        }

        private void btBienvenue_Click(object sender, EventArgs e)
        {   //au clic sur btBienvenue, écrire Bonjour +texte entré, vidé le texte entré, désactivé le bt
            lblBonjourNom.Text = "Bonjour " + textBoxNom.Text;
            textBoxNom.Text = "";
            btBienvenue.Enabled = false;
        }

       

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {   //Quand le texte change, si il est vide alors btBienvenue desactivé.
            if (textBoxNom.Text=="")
            {
                btBienvenue.Enabled = false;
            }
            else
            {   //Sinon le btBienvenue est activé.
              btBienvenue.Enabled = true;  
            }
        }

        private void frmBonjourQui_Load(object sender, EventArgs e)
        {   //Au chargement du programme, désactiver le btBienvenue.
            btBienvenue.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // clic sur bouton Quitter - on quitte l'application
            Application.Exit();
        }
    }
}
