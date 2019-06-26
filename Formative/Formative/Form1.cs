//Exo de formative, donnée à la racine du dossier.
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
using System.IO;

namespace Formative
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {
            cboArticle.Items.Add("Pain");
            cboArticle.Items.Add("Beurre");
            cboArticle.Items.Add("Lait");
            cboArticle.Items.Add("Confiture");
            cboArticle.Items.Add("Fromage");
            cboArticle.Items.Add("Oeufs");
            cboArticle.Items.Add("Farine");
            cboArticle.Items.Add("Sucre");
            cboArticle.Items.Add("Viande");
            
        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            if (cboArticle.SelectedIndex==-1)
            {
                MessageBox.Show("Sélectionnez un article");
            }
            else
            {
                if (txtQuantite.Text=="")
                {
                    MessageBox.Show("Introduisez une quantité");
                }
                else
                {
                    lstCourses.Items.Add(cboArticle.SelectedItem + " : " + txtQuantite.Text);
                    cboArticle.Items.RemoveAt(cboArticle.SelectedIndex);
                }
            }
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex!=-1)
            {
                cboArticle.Items.Add(lstCourses.SelectedItem.ToString().Substring(0, lstCourses.SelectedItem.ToString().IndexOf(" ")));
                lstCourses.Items.RemoveAt(lstCourses.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Sélectionnez un article à supprimer");
            }
        }

        private void CmdImprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore disponible");
        }

        private void CmdHaut_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex!=-1)
            {
                lstCourses.SelectedIndex--;
            }
        }

        private void CmdBas_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex != -1)
            {
                lstCourses.Items.Insert(lstCourses.SelectedItem, lstCourses.SelectedIndex + 2);
            }
        }
    }
}
