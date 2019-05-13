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
            textBoxRevenueAnnuel.Focus();   //Pour avoir le curseur dans la zone.
        }

        //Fonction pour calculer le revenu imposable:
        private void calculer_revenu_imposable()
        {
            //Sinon on peut faire les calculs:
            //Définir les variables et convertir les valeurs en string dans des int ou float:
            int revenubrut = 0;
            float coefficientfamilial = 0;
            int deductionjeune = 0;
            int deductiontransport = 0;
            float rabais = 0;
            float revenuimposable = 0;

            //Calcul du Revenu imposable:

            //Si revenu annuel brut ou coefficient familial sont vides, msg erreur:
            if (textBoxRevenueAnnuel.Text == "" || textBoxCoefficient.Text == "")
            {
                lblRevenueImposable.Text = "Erreur! Remplissez les champs 1 et 2!";
            }
            else
            {
                //charger que si rempli
                if (textBoxCoefficient.Text != "")
                {
                    coefficientfamilial = float.Parse(textBoxCoefficient.Text);
                }
                if (textBoxRevenueAnnuel.Text != "")
                {
                    revenubrut = int.Parse(textBoxRevenueAnnuel.Text);
                }
                if (textBoxDeductionJeune.Text != "")
                {
                    deductionjeune = int.Parse(textBoxDeductionJeune.Text);
                }
                if (textBoxDeductionsTransport.Text != "")
                {
                    deductiontransport = int.Parse(textBoxDeductionsTransport.Text);
                }
                if (textBoxRabais.Text != "")
                {
                    rabais = float.Parse(textBoxRabais.Text);
                }


                //Attention. Pour rentrer une valeur de type float, il faut mettre une "," et pas un "."

                //Calcul:
                revenuimposable = revenubrut / coefficientfamilial;
                if (checkBoxRabais.CheckState == CheckState.Checked)
                {
                    revenuimposable -= revenuimposable * rabais / 100;
                }
                if (checkBoxDeductionJeune.CheckState == CheckState.Checked && checkBoxDeductionJeune.Enabled == true)    //si il est checké et activé.
                {
                    revenuimposable -= deductionjeune;
                }
                if (checkBoxDeductionTransport.CheckState == CheckState.Checked && checkBoxDeductionTransport.Enabled == true)
                {
                    revenuimposable -= deductiontransport;
                }

                //convertir en revenuimposable en chaine de caractères pour l'afficher:
                lblRevenueImposable.Text = "Revenu imposable: fr. " + revenuimposable;

                //Si une déduction est inférieur à 10% du revenu annuel brut alors sa checkbox est désactivé:
                //Ca joue pas !!!! ca revient pas quand ca redevient inférieur. sans compter les erreurs à cause de valeurs invalides !
                if (deductionjeune > revenubrut / 10)
                {
                    checkBoxDeductionJeune.Enabled = false;
                }
                else
                {
                    checkBoxDeductionTransport.Enabled = true;
                }
                if (deductiontransport > revenubrut / 10)
                {
                    checkBoxDeductionTransport.Enabled = false;
                }
                else
                {
                    checkBoxDeductionTransport.Enabled = true;
                }


            }
            //verification du domaine de valeur:

            if (coefficientfamilial < 1 || coefficientfamilial > 10)
            {
                textBoxCoefficient.Text = "";
            }
            if (deductionjeune > revenubrut / coefficientfamilial || deductionjeune < 0)
            {
                textBoxDeductionJeune.Text = "";
            }
            if (deductiontransport > revenubrut / coefficientfamilial || deductiontransport < 0)
            {
                textBoxDeductionsTransport.Text = "";
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

        private void textBoxRevenueAnnuel_Validated(object sender, EventArgs e) //Validated = à quand on quitte le champ en question.
        {
            int revenubrut = int.Parse(textBoxRevenueAnnuel.Text);

            if (textBoxRevenueAnnuel.Text != "")
            {
                if (revenubrut < 2000)
                {
                    textBoxRevenueAnnuel.Text = "";
                }
            }
        }
    }
}
