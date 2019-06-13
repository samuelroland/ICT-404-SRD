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
    public partial class Form1 : Form
    {
        bool numnb = true; //numéro du nb entré. si true => l
        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int firstnb=0;
            int secondnb=0;
            
            //Le texte du bouton est la valeur qu'il faut prendre, donc il faut le convertir en int:
            //Selon le numnb:
            if (numnb == true)
            {
                firstnb = int.Parse(btn.Text);
                lblNbEntier1.Text = btn.Text;
            }
            else
            {
                secondnb = int.Parse(btn.Text);
                lblNbEntier2.Text = btn.Text;
            }
            
            numnb = !numnb;
        }

        private void Operateurs_Click(object sender, EventArgs e)
        {
            Button btnOperateur = sender as Button;

            switch (btnOperateur.Text)
            {
                case "+":
                    
                    break;
                case "-":

                    break;
                case "/":

                    break;
                case "*":

                    break;
                default:
                    break;
            }
        }
    }
}
