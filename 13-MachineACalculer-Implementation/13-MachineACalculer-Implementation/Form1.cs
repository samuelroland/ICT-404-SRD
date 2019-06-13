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
        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int firstnb;
            int secondnb;
            bool numnb = true; //numéro du nb entré. si true => l
            //Le texte du bouton est la valeur qu'il faut prendre, donc il faut le convertir en int:
            //Selon le numnb:
            if (numnb == true)
            {
                firstnb = int.Parse(btn.Text);
            }
            else
            {
                secondnb = int.Parse(btn.Text);
            }
            MessageBox.Show("first nb est " + firstnb.ToString() + "second nb est " + secondnb.ToString());

        }
    }
}
