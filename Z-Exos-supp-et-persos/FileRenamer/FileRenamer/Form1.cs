//Programme: FileRenamer, sert à renommer des fichiers de notes avec une structure particulière, comme son nom l'indique. Il suffit de rentrer qqes infos et choisir la structure, puis il renomme tous les fichiers dans un repertoire, nommé par défaut d'une certaine manière.
//Auteur: Samuel Roland
//Date: aout 2019.


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

namespace FileRenamer
{
    public partial class frmFileRenamer : Form
    {
        public frmFileRenamer()
        {
            InitializeComponent();
        }

        DirectoryInfo folder = new DirectoryInfo("C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\ICT\\123");
        string placeholderchoixrepertoire = "Exemple: P:\\2eme année";
        private void CmdLancer_Click(object sender, EventArgs e)
        {

            //test pour début de renommer un fichier:
            StreamWriter ecrivain = null;
            int i = 0;
            string newname; //nouveau nom que le fichier aura.
            string coursname = "ICT114";   //nom du cours correspondant aux notes.9
            string typecours;   //type du cours, MA ou ICT.
            string numcours;    //numéro du cours, ex: 114.
            string useracronyme = "SRD";    //acronyme du user.
            int numsemaine = 1; //numéro de la semaine en cours.
            string intro = "Nts";
            string fileinrunpath;   //chemin accès au fichier en cours.
            int indextypemodule = 0;
            //Scann de tous les fichiers du répértoire:
            foreach (var fileinrun in folder.GetFiles())
            {

                if (fileinrun.Name.Contains("doc"))
                {
                    fileinrunpath = fileinrun.FullName;
                    i++;

                    //Définition du noms du cours 
                    //Pour simplifier la tache pour retrouver le nom du cours avec le nom du dossier. On prend déjà le parent pour avoir le path du dossier du cours.
                    coursname = Directory.GetParent(fileinrunpath).ToString();
                    //On prend ICT ou MA:
                    MessageBox.Show(coursname.LastIndexOf("\\") - 4 + " second is " + coursname.IndexOf("\\", coursname.LastIndexOf("\\") - 6) + " " + coursname);
                    indextypemodule = coursname.IndexOf("\\", coursname.LastIndexOf("\\") - 6);
                    typecours = coursname.Substring(indextypemodule + 1, coursname.LastIndexOf("\\") - indextypemodule - 1);   //nb de chars = différence de pos des deux "/"
                    //On prend le numéro du module la fin après le "/" :
                    numcours = coursname.Substring(coursname.LastIndexOf("\\") + 1, 3);
                    coursname = typecours + numcours;

                    //Définition du nouveau nom du fichier avec les infos prises précedemment.
                    newname = String.Format("{0}-{1}_{2}-S{3}.docx", intro, useracronyme, coursname, numsemaine);

                    //TODO: créer le dossier "Notes" si il n'existe pas:
                    // Directory.CreateDirectory();

                    string oldfileinrunpath = "C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\" + typecours + "\\" + numcours + "\\" + fileinrun.Name;
                    File.Copy(oldfileinrunpath, "C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\ICT\\123\\Notes\\" + newname);
                    label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;
                    label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;

                    //supprimer l'ancien fichier nom renommé encore à l'emplacement dans le dossier du module:
                    File.Delete(oldfileinrunpath);
                    label1.Text += "\nFichier base supprimé: " + fileinrun.Name;

                }
            }

            try
            {
                using (ecrivain = new StreamWriter("C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\saluttest.txt"))
                {

                }
            }
            catch (Exception)
            {

            }
        }

        private void FrmFileRenamer_Load(object sender, EventArgs e)
        {
            //Au chargement du formulaire, charger les préconfigurations.
            //TODO: chercher fichiers de configuration, si trouve affiche dans le combobox en selectionnant le dernier utilisé(selon la date de derniere utilisation dans le fichier).

            txtChoixRepertoire.Text = placeholderchoixrepertoire;
            cmdLancer.Focus();  //????????
            lblCheckRepertoire.Visible = false;
            //vider les résultats:
            label1.Text = "";
        }

        private void CmdParcourir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtChoixRepertoire.Text))  //si le repertoire existe dans le champ texte, alors prendre ce départ pour parcourir.
            {
                fbdChoixRepertoire.SelectedPath = txtChoixRepertoire.Text;
            }
            //ouvrir et à la fermeture, reprendre le path.
            fbdChoixRepertoire.ShowDialog();
            txtChoixRepertoire.Text = fbdChoixRepertoire.SelectedPath;
        }

        private void TxtChoixRepertoire_TextChanged(object sender, EventArgs e)
        {

            if (Directory.Exists(txtChoixRepertoire.Text))
            {
                cmdLancer.Enabled = true;
                lblCheckRepertoire.Visible = false;
            }
            else
            {
                cmdLancer.Enabled = false;
                lblCheckRepertoire.Visible = true;
            }

        }

        private void TxtChoixRepertoire_Enter(object sender, EventArgs e)
        {
            //au moment où on entre, il faut vider le placeholder si il y est.
            if (txtChoixRepertoire.Text == placeholderchoixrepertoire)
            {
                txtChoixRepertoire.Text = "";
               
            }
        }

        private void TxtChoixRepertoire_Leave(object sender, EventArgs e)
        {
            //au moment où on quitte, il faut remettre le placeholder si c'est vide.
            if (txtChoixRepertoire.Text == "")
            {
                txtChoixRepertoire.Text = placeholderchoixrepertoire;
            }
        }

        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            if (lstErrors.Items.Count==0)   //il n'y a plus d'erreurs à gérer.
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Il reste encore des erreurs à gérer ! Ne quitter pas avant d'avoir tout géré !");
            }
        }

        private void CmdEcraser_Click(object sender, EventArgs e)
        {
            //TODO: msg attention avec oui ou non à choix.
            //TODO: une fois traité, retirer l'erreur de la liste.

        }

        private void CmdUseUniqueNames_Click(object sender, EventArgs e)
        {
            //TODO: coller le fichier avec le nom -2, -3 selon ce qui existe déjà. si -2.docx existe, ne pas mettre-2-1.docx mais plutot -3.docx
            //TODO: une fois traité, retirer l'erreur de la liste.
        }

        private void CmdNotTraiter_Click(object sender, EventArgs e)
        {
            //Ne rien faire.
            //TODO: une fois traité, retirer l'erreur de la liste.
        }
    }
}
