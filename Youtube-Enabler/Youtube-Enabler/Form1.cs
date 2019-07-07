/*
 Programme: ce programme sert à désactiver l'accès à youtube selon les envies. Pour cela, il rajoute ou enlève une ligne dans le fichier hosts de l'ordinateur.
 Auteur: Samuel Roland
 Date: 07.07.2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Youtube_Enabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdDesactiver_Click(object sender, EventArgs e)
        {
            //test dupliquer:
            //File.Copy(@"C:\Users\PC_Samuel_01\Documents\test.txt", @"C:\Windows\System32\drivers\etc\test.txt");

            //MessageBox.Show("stop fichier copié !");

            StreamWriter ecrivain = null;

            using (ecrivain = new StreamWriter("C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\test.txt"))
            {
                StreamReader lecteur = null;
                string ligneinrun = "#";


            }
            MessageBox.Show("attention ä la suppression.");
            if (File.Exists(@"C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\test.txt"))
            {
                File.Delete(@"C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\test.txt");
            }

        }

    }
}

