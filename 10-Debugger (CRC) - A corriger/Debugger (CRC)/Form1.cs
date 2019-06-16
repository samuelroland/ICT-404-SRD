using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Programme: Calcul de CRC sur un numéro de carte de crédit
// Auteur:    X. Carrel
// Date:      Mars 2013

//Correction de 3 bugs (exo 10-Debugger): Samuel Roland
//Date: 16.06.2019

namespace Debugger__CRC_
{
    public partial class frmCRC : Form
    {
        const int NbChiffresBase = 18;    // Le nombre de chiffres dans le numéro sans CRC
        long CRCVal = 0; // CRC (cumul)

        public frmCRC()
        {
            InitializeComponent();
        }

        private long CRC(string Donnée)
        // Méthode qui calcule le CRC d'une donnée.
        {
            int     NbChiffres = 0; // Pour compter le nombre de chiffres dans le numéro fourni
            //ERREUR: Oublié de remettre le CRCVal à 0. donc on continue avec la somme d'avant. rajouter CRCVal=0
            CRCVal = 0;

            // Parcourir la donnée
            for (int i = 0; i < Donnée.Length; i++)
            {
                char c = Donnée[i];
                //if ((c > '0') && (c < '9')) // C'est un chiffre
                //ERREUR: Cette condition n'inclut pas le 0 ni le 9, il faut mettre des >= et des <= donc dès qu'il y a 0 ou 9 il ne les prend pas et ce n'est donc pas valide.
                if ((c >= '0') && (c <= '9'))
                {
                    NbChiffres++;
                    CRCVal = CRCVal + ((int)c - (int)'0');

                    //ERREUR: comme dessus on n'inclut pas 100 donc si CRCVal vaut 100 ca ne fonctionne pas. on a donc 100 pas égal à 0. donc on l'inclut avec >=
                    //if (CRCVal > 100) // On ne peut pas dépasser 100 parce qu'on n'a que deux chiffres pour le CRC
                    if (CRCVal >= 100)
                        CRCVal = CRCVal - 100;
                }
            }
            if (NbChiffres != NbChiffresBase)
            {
                MessageBox.Show(string.Format("Erreur: un numéro de carte doit contenir {0} chiffres (sans le CRC)",NbChiffresBase));
                return -1;
            }
            return CRCVal;
        }

        private void cmdCheckCRC_Click(object sender, EventArgs e)
        {
            string Num = txtData.Text;

            if (Num == "")
            {
                MessageBox.Show("Introduisez un numéro de carte SVP");
                return;
            }

            long CRCVal;

            if (rbtCalcul.Checked) // On cherche à calculer un CRC
            {
                CRCVal = CRC(Num); // Calcul du CRC
                if (CRCVal >= 0)
                    MessageBox.Show("Le CRC vaut: " + CRCVal.ToString());
            }
            else // On vérifie un numéro complet
            {
                int CRCIntro = 10 * ((int)Num[Num.Length - 2] - (int)'0') + ((int)Num[Num.Length - 1] - (int)'0'); // Le CRC inclus dans le numéro (deux derniers chiffres)
                Num = Num.Substring(0, Num.Length - 2); // On enlève les deux derniers chiffres
                CRCVal = CRC(Num); // et on calcule le CRC

                if (CRCIntro == CRCVal)
                    MessageBox.Show("Le numéro est valide");
                else
                    MessageBox.Show("Le numéro n'est pas valide");
            }
        }

    }
}
