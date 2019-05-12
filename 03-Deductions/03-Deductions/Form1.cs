using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Deductions
{
    public partial class frmDeductions : Form
    {
        public frmDeductions()
        {
            InitializeComponent();
        }

        private void frmDeductions_Load(object sender, EventArgs e)
        {
            //Rendre invisible le résultat:
            lblRevenueImposable.Visible = false;
            //Décocher toutes les checkbox:
            checkBoxDeductionJeune.Checked = false;
            checkBoxDeductionTransport.Checked = false;
            checkBoxRabais.Checked = false;

            //Mettre 900, 650 et 4 comme valeur:
            textBoxDeductionJeune.Text = "900";
            textBoxDeductionsTransport.Text = "650";
            textBoxRabais.Text = "4";
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            //Calcul du Revenu imposable:

            //Si revenu annuel brut ou coefficient familial sont vides, msg erreur:
            if (textBoxRevenueAnnuel.Text=="" || textBoxCoefficient.Text=="")
            {
                lblRevenueImposable.Text = "Erreur! Remplissez les champs 1 et 2!";
            }
            else
            {   
                //Sinon on peut faire les calculs:
                //Définir les variables et convertir les valeurs en string dans des int ou float:
                int revenubrut=int.Parse(textBoxRevenueAnnuel.Text);
                float coefficientfamilial=float.Parse(textBoxCoefficient.Text);
                int deductionjeune = int.Parse(textBoxDeductionJeune.Text);
                int deductiontransport = int.Parse(textBoxDeductionsTransport.Text);
                float rabais = float.Parse(textBoxRabais.Text);
                float revenuimposable;

                //Attention. Pour rentrer une valeur de type float, il faut mettre une "," et pas un "."

                //Calcul:
                revenuimposable = revenubrut / coefficientfamilial;
                if (checkBoxRabais.CheckState == CheckState.Checked)
                {
                    revenuimposable -= revenuimposable * rabais/100;
                }
                if (checkBoxDeductionJeune.CheckState == CheckState.Checked)
                {
                    revenuimposable -= deductionjeune;
                }
                if (checkBoxDeductionTransport.CheckState == CheckState.Checked)
                {
                    revenuimposable -= deductiontransport;
                }

                //convertir en revenuimposable en chaine de caractères pour l'afficher:
                lblRevenueImposable.Text = "Revenu imposable: fr. " + revenuimposable;
            }
            //Remettre visible le label de résultat:
            lblRevenueImposable.Visible = true;
        }
    }
}
