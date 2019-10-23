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
using System.Threading;

namespace TLFM
{
    public partial class frmTLFM : Form
    {
        public frmTLFM()
        {
            InitializeComponent();
        }
        //Variables et constantes:
        string directorypath;   //chemin d'accès au répertoire de base
        string filename;


        private void BtnExplorateur_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtChoixRepertoire.Text))  //si le repertoire existe dans le champ texte, alors prendre ce départ pour parcourir.
            {
                fbdChoixRepertoire.SelectedPath = txtChoixRepertoire.Text;
            }
            //ouvrir et à la fermeture, reprendre le path.
            fbdChoixRepertoire.ShowDialog();
            txtChoixRepertoire.Text = fbdChoixRepertoire.SelectedPath;
        }

        private void FrmTLFM_Load(object sender, EventArgs e)
        {
            //nettoyer les logs:
            lstLogs.Items.Clear();
            chklstFilesFound.Items.Clear();





        }

        private void BtnLancer_Click(object sender, EventArgs e)
        {
            btnLancer.Enabled = false;
            int numfile = 0;
            int nbtoolongfiles = 0;
            if (Directory.Exists(txtChoixRepertoire.Text))
            {
                directorypath = txtChoixRepertoire.Text;
            }
            else
            {
                MessageBox.Show("Répertoire inexistant: modifier le !");
            }

            foreach (string filepath in Directory.GetFiles(directorypath, "*.*", SearchOption.AllDirectories))
            {
                numfile++;
                filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);   //prend le nom du fichier après le dernier slash.

               
                //On ajoute le log une fois que tout est calculé:
                lstLogs.Items.Add("File " + numfile + ": \"" + filename + "\" à " + filepath.Substring(0, filepath.LastIndexOf("\\") + 1));
                lblFileInRun.Text = "Recherche sur : " + filename;

                if (filename.Length >= 100)
                {
                    chklstFilesFound.Items.Add("Fichier TL! " + filename.Length + " : File " + numfile + ": \"" + filename + "\" à " + filepath.Substring(0, filepath.LastIndexOf("\\") + 1));
                    nbtoolongfiles++;
                }

                if (filepath.Length >= 248)
                {
                    chklstFilesFound.Items.Add("Répert. TL! " + filepath.Length + " : File " + numfile + ": \"" + filename + "\" à " + filepath.Substring(0, filepath.LastIndexOf("\\") + 1));
                    nbtoolongfiles++;
                }
            }
            lblResultLogs.Text = numfile + " fichiers trouvés dans ce répertoire. " + nbtoolongfiles + " dont le nom ou le chemin est trop long...";

            //lstLogs.Items.AddRange(Directory.GetFiles(directorypath, "*.txt", SearchOption.AllDirectories));
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

   
    
    }
}
