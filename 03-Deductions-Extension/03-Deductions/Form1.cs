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
        
        //Fonction pour calculer le revenu imposable:
        private void calculer_revenu_imposable()
        {
            //Sinon on peut faire les calculs:
            //Définir les variables et convertir les valeurs en string dans des int ou float:
            int revenubrut;
            float coefficientfamilial;
            int deductionjeune;
            int deductiontransport;
            float rabais;
            float revenuimposable;
            //Calcul du Revenu imposable:

            //Si revenu annuel brut ou coefficient familial sont vides, msg erreur:
            if (textBoxRevenueAnnuel.Text == "" || textBoxCoefficient.Text == "")
            {
                lblRevenueImposable.Text = "Erreur! Remplissez les champs 1 et 2!";
            }
            else
            {
                //charger que si rempli
                revenubrut = int.Parse(textBoxRevenueAnnuel.Text);
                coefficientfamilial = float.Parse(textBoxCoefficient.Text);
                deductionjeune = int.Parse(textBoxDeductionJeune.Text);
                deductiontransport = int.Parse(textBoxDeductionsTransport.Text);
                rabais = float.Parse(textBoxRabais.Text);

                //Attention. Pour rentrer une valeur de type float, il faut mettre une "," et pas un "."

                //Calcul:
                revenuimposable = revenubrut / coefficientfamilial;
                if (checkBoxRabais.CheckState == CheckState.Checked)
                {
                    revenuimposable -= revenuimposable * rabais / 100;
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
                
                //Si une déduction est inférieur à 10% du revenu annuel brut alors sa checkbox est désactivé:
                //Ca joue pas !!!! ca revient pas quand ca redevient inférieur. sans compter les erreurs à cause de valeurs invalides !
                if (deductionjeune>revenubrut/10)
                {
                    checkBoxDeductionJeune.Enabled = false;
                }
                if (deductiontransport > revenubrut / 10)
                {
                    checkBoxDeductionTransport.Enabled = false;
                }
            }
            //Remettre visible le label de résultat:
            lblRevenueImposable.Visible = true;

           
            
            
        }

        //Si le texte change dans une des textBox, il faut recalculer:
        private void textBoxRevenueAnnuel_TextChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void textBoxCoefficient_TextChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void textBoxDeductionJeune_TextChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void textBoxDeductionsTransport_TextChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void textBoxRabais_TextChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void checkBoxDeductionJeune_KeyDown(object sender, KeyEventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void checkBoxDeductionTransport_KeyPress(object sender, KeyPressEventArgs e)
        {
            calculer_revenu_imposable();
        }

        private void checkBoxRabais_CheckedChanged(object sender, EventArgs e)
        {
            calculer_revenu_imposable();
        }
    }
}
