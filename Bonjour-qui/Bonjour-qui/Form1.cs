//Exercice Bonjour, Moodle
//Samuel Roland
//06.05.2019

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
        {
            lblBonjourNom.Text = "Bonjour " + textBoxNom.Text;
            textBoxNom.Text = "";
            btBienvenue.Enabled = false;
        }

        private void textBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            btBienvenue.Enabled = true;
        }

        private void frmBonjourQui_Load(object sender, EventArgs e)
        {
            btBienvenue.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // clic sur bouton Quitter - on quitte l'application
            Application.Exit();
        }
    }
}
