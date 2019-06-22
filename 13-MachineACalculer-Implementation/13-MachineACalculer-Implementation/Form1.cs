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

        bool sup10=false;   //définit si le label 2 contient un nombre > 10. donc à plusieurs chiffres.
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Le texte du bouton est la valeur qu'il faut prendre, donc il faut le convertir en int:
            //Selon le numnb:
            if (numnb == true)
            {
                if (dejapremiercalcul==false)
                {
lblNbEntier1.Text += btn.Text;
                firstnb = float.Parse(lblNbEntier1.Text);
                }
                else
                {   //si on fait des calculs successif.
                    if (sup10==false)   //si le nb est sup10, en fait on se trouve au moment ou on vient de taper le 3eme nombre. il faut donc vider celui du calcul d'avant.
                    {
                        lblNbEntier2.Text = "";
                        sup10=true;
                    }
                    
                    lblNbEntier1.Text = resultopm.ToString();
                    lblNbEntier2.Text += btn.Text;
                    secondnb = float.Parse(lblNbEntier2.Text);
                    firstnb = float.Parse(lblNbEntier1.Text);
                }
                
            }
            else
            {
               
                lblNbEntier2.Text += btn.Text;
                secondnb = float.Parse(lblNbEntier2.Text);
            }
            resultcalcul();

        }
        Button btnOperateur;
        private void Operateurs_Click(object sender, EventArgs e)
        {
            btnOperateur = sender as Button;
            
            //Afficher le symbole entre les deux nombres entiers:
            lblOperateurs.Text = btnOperateur.Text;
            numnb = !numnb;
            resultcalcul();
        }

        bool dejapremiercalcul = false; //indique si il y a déjà eu un premier calcul 


float result = 0;
        float resultopm = 0;    //résultat d'une opération multiple.
        private void resultcalcul()
        {
            if (lblNbEntier1.Text=="" || lblNbEntier2.Text=="")
            {
                lblResult.Text = "En attente...";
            }
            else
            {

                
                switch (lblOperateurs.Text)
                {
                    case "+":
                        if (dejapremiercalcul == false)
                        {
                            result = firstnb + secondnb;
                        }
                        else
                        {
                            
                            result = firstnb + secondnb;
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
                        resultopm = result;
                        dejapremiercalcul = true;
                        break;
                    case "*":
                        result = firstnb * secondnb;
                        resultopm = result;
                        dejapremiercalcul = true;
                        break;
                    default:
                        break;
                }
                lblResult.Text = string.Format("Résultat ({0:F2})", result);
            }
        }

        private void frmMachineACalculer_Load(object sender, EventArgs e)
        {
            lblNbEntier1.Text = "";
            lblNbEntier2.Text = "";
        }
    }
}
