//Programme: Implémentation de Machine à calculer, exo documenté par Benoit Pierrehumbert à partir de l'exo sur Moodle du même nom.
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

namespace _13_MachineACalculer_Implementation
{
    public partial class frmMachineACalculer : Form
    {
        bool numnb = true; //numéro du nb entré. si true => l
        public frmMachineACalculer()
        {
            InitializeComponent();
        }
        float firstnb = 0;
        float secondnb = 0;
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Le texte du bouton est la valeur qu'il faut prendre, donc il faut le convertir en int:
            //Selon le numnb:
            if (numnb == true)
            {
                firstnb = float.Parse(btn.Text);
                lblNbEntier1.Text = btn.Text;
                if (dejapremiercalcul==true)
                {
                    resultcalcul();
                }
            }
            else
            {
                secondnb = float.Parse(btn.Text);
                lblNbEntier2.Text = btn.Text;
                //Puisque c'est le second nombre, il faut directement calculer le resultat:
                resultcalcul();
            }

            numnb = !numnb;
        }
        Button btnOperateur;
        private void Operateurs_Click(object sender, EventArgs e)
        {
            btnOperateur = sender as Button;
            btnOperateur = sender as Button;
            //Afficher le symbole entre les deux nombres entiers:
            lblOperateurs.Text = btnOperateur.Text;

        }

        bool dejapremiercalcul=false; //indique si il y a déjà eu un premier calcul 
        private void resultcalcul()
        {
            
            float result = 0;
            switch (btnOperateur.Text)
            {
                case "+":
                    if (dejapremiercalcul == false)
                    {
                        result = firstnb + secondnb;
                    }
                    else
                    {
                        result += firstnb;
                    }
                    break;
                case "-":
                    if (dejapremiercalcul == false)
                    {
                        result = firstnb - secondnb;
                    }
                    else
                    {
                        result -= firstnb;

                    }
                    
                    break;
                case "/":
                    result = firstnb / secondnb;
                    dejapremiercalcul = true;
                    break;
                case "*":
                    result = firstnb * secondnb;
                    dejapremiercalcul = false;
                    break;
                default:
                    break;
            }
            lblResult.Text = string.Format("Résultat ({0:F2})", result);
        }
    }
}
