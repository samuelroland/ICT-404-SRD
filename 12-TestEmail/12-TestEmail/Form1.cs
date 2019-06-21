//Programme: 12-TestEmail exo de Moodle
//Samuel Roland
//juin 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TestEmail
{
    public partial class frmTestEmail : Form
    {
        public frmTestEmail()
        {
            InitializeComponent();
        }

        private void CmdVerifier_Click(object sender, EventArgs e)
        {
            int nbcondtrue = 0; //nb de conditions correctes. si ==4 alors l'email est valide.
            if (txtEmail.Text=="")
            {
                lblEmailAVerif.ForeColor = Color.Red;
                MessageBox.Show("Veuillez remplir le champ Email afin de procéder à sa vérification, svp", "Champ Email Vide", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                //Calculer l'index du @:
                int indexate = txtEmail.Text.IndexOf("@");
                if (indexate!=-1)
                {
                    nbcondtrue++;
                    chkAtePresent.Checked=true;
                }
                if (indexate>0)
                {
                    txtCharsAvant.Text = indexate.ToString();
                }
            }
        }

        private void FrmTestEmail_Load(object sender, EventArgs e)
        {
            //Initialisation du formulaire au démarrage:
            txtCharsAvant.Text = "2";
            txtCharsApres.Text = "4";
            //champ lblUsername:
            lblUsername.Text = "";
            lblUsername.Enabled = false;
            lblUsername.ForeColor = Color.Black;
            lblUsername.BackColor = Color.White;
        }
    }
}
