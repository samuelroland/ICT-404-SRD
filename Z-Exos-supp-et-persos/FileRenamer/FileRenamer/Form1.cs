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
        string searchfile;  //nom des fichiers à rechercher avec *
        string folderpath;  //path du folder.
        DirectoryInfo folder = null;
        string placeholderchoixrepertoire = "Exemple: P:\\2eme année";

        int numerofin = 0;  //si 0 alors c'est le numero de la semaine, et si 1 alors numéro dans le nom du fichier
        private void CmdLancer_Click(object sender, EventArgs e)
        {
            folderpath = txtChoixRepertoire.Text;
            folder = new DirectoryInfo(folderpath);
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

            //charger searchfile:
            switch (cboPositionTxtSearchFilename.SelectedItem)
            {
                case "commencant par":
                    searchfile = txtTxtSearchFilename.Text + "*.*";
                    break;
                case "contenant":
                    searchfile = "*" + txtTxtSearchFilename.Text + "*.*";
                    break;
                case "se terminant par":
                    searchfile = "*" + txtTxtSearchFilename.Text + ".*";
                    break;
                default:
                    searchfile = "*" + txtTxtSearchFilename.Text + "*.*";
                    break;
            }

            //Scann de tous les fichiers du répértoire:
            foreach (var fileinrun in Directory.GetFiles(folderpath, searchfile, SearchOption.AllDirectories))
            {
                string filename = fileinrun.ToString();
                fileinrunpath = fileinrun;  //attribuer le fullname au path
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);    //ne prendre que le nom à la fin du path;
                if (filename.Contains(txtTxtSearchFilename.Text))
                {
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


                    //construire le lbl Result Structure.
                    newname = "";    //vider le nouveau nom ancien

                    if (chkIntro.Checked && txtIntro.Text != "")    //si intro coché et rempli
                    {
                        newname += txtIntro.Text;   //ajouter l'introduction
                    }
                    if (cboSeparateur1.SelectedIndex > 0)   //si separateur est sélectionné et n'est pas aucun.
                    {
                        newname += cboSeparateur1.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 1
                    }
                    if (chkAcronyme.Checked && txtAcronyme.Text != "")      //si acronyme coché et rempli
                    {
                        newname += txtAcronyme.Text;    //on ajoute l'acronyme trouvé plus haut
                    }
                    if (cboSeparateur2.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
                    {
                        newname += cboSeparateur2.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 2
                    }
                    if (chkInclureNomCours.Checked)
                    {
                        newname += coursname;    //on ajoute un nom de cours pour ce fichier
                    }
                    if (cboSeparateur3.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
                    {
                        newname += cboSeparateur3.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 3
                    }

                    if (cboIntroSemaine.SelectedIndex > 0)
                    {
                        newname += cboIntroSemaine.SelectedItem;    //on ajoute l'introduction de la semaine ou numéro
                    }
                    if (cboChoixNumeroFin.SelectedIndex >= 0)
                    {
                        if (cboChoixNumeroFin.SelectedItem == "Numéro de semaine auto") //choix du numéro (semaine ou nom du fichier).
                        {
                            numerofin = 0;

                            //Trouver le numéro de la semaine
                            DateTime timeofcreation = File.GetCreationTime(fileinrun);
                            MessageBox.Show(timeofcreation.ToString());

                            newname += "6"; //numéro de semaine imaginaire
                        }
                        else
                        {
                            newname += "5"; //numéro dans le fichier.
                        }
                    }






                    //TODO: créer le dossier "Notes" si il n'existe pas:
                    // Directory.CreateDirectory();

                    string oldfileinrunpath = txtChoixRepertoire.Text + "\\" + typecours + "\\" + numcours + "\\" + filename;
                    //File.Copy(oldfileinrunpath, txtChoixRepertoire.Text + \\Notes\\" + newname);
                    label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;
                    label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;

                    //supprimer l'ancien fichier nom renommé encore à l'emplacement dans le dossier du module:
                    //File.Delete(oldfileinrunpath);
                    label1.Text += "\nFichier base supprimé: " + filename;

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
            if (lstErrors.Items.Count == 0)   //il n'y a plus d'erreurs à gérer.
            {
                Application.Exit();
            }
            else
            {
                //Pour les tests:
                Application.Exit();
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

        private void donneesmodifiees(object sender, EventArgs e)
        {
            //ajouter "MODIFIé !" au nom de la préconfig:

            //importer les données du formulaire:
            importdataform();

        }
        void importdataform()   //sert à importer les données du formulaire dans les variables du programme.
        {

        }
        void importdatafile(string filepath)   //sert à importer les données d'un fichier dans les variables du programme.
        {

        }
        void afficherdataonform()   //sert à afficher les données du programme sur le formulaire.
        {

        }
        void sauverpreconfig(string nomchoisi)  //sert à enregistrer une nouvelle préconfiguration.
        {
            if (datachecker())
            {

            }
            else
            {
                //il y a des données invalides. msg d'erreur car ne peut pas sauver:
                MessageBox.Show("Il y a des données invalides dans le formulaire. Corrigez les avant de sauver la préconfiguration.", "Données invalides...");
            }
            //TODO:
        }
        bool datachecker()  //sert à vérifier toutes les données présentes sur le formulaire.
        {



            return true;
        }

        private void ChkIntro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntro.Checked)
            {
                txtIntro.Enabled = true;

            }
            else
            {
                txtIntro.Enabled = false;
            }
            lblResultStructureChange();
        }



        private void CboChoixNumeroFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoixNumeroFin.SelectedIndex == 1)    //donc que c'est sur Numéro semaine auto.
            {

            }
            lblResultStructureChange();
        }

        private void ChkAcronyme_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcronyme.Checked)
            {
                txtAcronyme.Enabled = true;
            }
            else
            {
                txtAcronyme.Enabled = false;
            }
            lblResultStructureChange();
        }

        private void txtIntro_TextChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }


        private void txtAcronyme_TextChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void cboSeparateur2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void chkInclureNomCours_CheckedChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void cboIntroSemaine_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        void lblResultStructureChange()
        {
            //construire le lbl Result Structure.
            string structureex = "de ";

            //nom avant:
            switch (cboPositionTxtSearchFilename.SelectedItem)
            {
                case "commencant par":
                    structureex += txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
                case "contenant":
                    structureex += "test-" + txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
                case "se terminant par":
                    structureex += "test-" + txtTxtSearchFilename.Text + cboChoixTypeFilename.Text;
                    break;
                default:
                    structureex += txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
            }

            structureex += " renommé en ";

            if (chkIntro.Checked && txtIntro.Text != "")    //si intro coché et rempli
            {
                structureex += txtIntro.Text;   //ajouter l'introduction
            }
            if (cboSeparateur1.SelectedIndex > 0)   //si separateur est sélectionné et n'est pas aucun.
            {
                structureex += cboSeparateur1.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 1
            }
            if (chkAcronyme.Checked && txtAcronyme.Text != "")      //si acronyme coché et rempli
            {
                structureex += txtAcronyme.Text;    //on ajoute l'acronyme
            }
            if (cboSeparateur2.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
            {
                structureex += cboSeparateur2.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 2
            }
            if (chkInclureNomCours.Checked)
            {
                structureex += "ICT114";    //on ajoute un nom de cours fictif
            }
            if (cboSeparateur3.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
            {
                structureex += cboSeparateur3.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 3
            }

            if (cboIntroSemaine.SelectedIndex > 0)
            {
                structureex += cboIntroSemaine.SelectedItem;    //on ajoute l'introduction de la semaine ou numéro
            }
            if (cboChoixNumeroFin.SelectedIndex >= 0)
            {
                if (cboChoixNumeroFin.SelectedItem == "Numéro de semaine auto") //choix du numéro (semaine ou nom du fichier).
                {
                    numerofin = 0;
                    structureex += "6"; //numéro de semaine imaginaire
                }
                else
                {
                    structureex += "5"; //numéro dans le fichier.
                }
            }


            lblResultStructure.Text = structureex;
        }

        private void cboSeparateur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }
    }
}
