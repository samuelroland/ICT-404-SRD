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
        string placeholderchoixrepertoire = "Exemple: \"P:\\2eme année\"";
        string newname; //nouveau nom que le fichier aura.
        string coursname;   //nom du cours correspondant aux notes.
        string typecours;   //type du cours, MA ou ICT.
        string numcours;    //numéro du cours, ex: 114.
        string useracronyme;    //acronyme du user.
        int numsemaine = 1; //numéro de la semaine en cours.
        string intro;
        string fileinrunpath;   //chemin accès au fichier en cours.
        int indextypemodule = 0;
        int numerofin = 0;  //si 0 alors c'est le numero de la semaine, et si 1 alors numéro dans le nom du fichier
        DateTime[] listsofmondaythisyear = new DateTime[300];   //tableau des lundis de cette année scolaire.
        string[,] Logs = new string[,]
        {
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"},
            {"null", "null"}
        };   //logs du renommage.

        private void CmdLancer_Click(object sender, EventArgs e)
        {
            folderpath = txtChoixRepertoire.Text;
            folder = new DirectoryInfo(folderpath);
            //test pour début de renommer un fichier:
            StreamWriter ecrivain = null;
            int i = 0;

            //Initialisation of the tables for logs
            //for (int f = 0; f < 25; f++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Logs[f, j] = "null";
            //    }
            //}


            //charger searchfile:
            switch (cboPositionTxtSearchFilename.SelectedItem)
            {
                case "commencant par":
                    searchfile = txtTxtSearchFilename.Text + "*"; //texte possible que après
                    break;
                case "contenant":
                    searchfile = "*" + txtTxtSearchFilename.Text + "*"; //texte possible avant et après.
                    break;
                case "se terminant par":
                    searchfile = "*" + txtTxtSearchFilename.Text;   //texte possible que avant
                    break;
                default:
                    searchfile = txtTxtSearchFilename.Text + "*"; //par défaut que au commencant par.
                    break;
            }
            if (cboChoixTypeFilename.SelectedIndex < 0)   //si il est sélectionné et qu'il n'est pas sur Toutes.
            {
                searchfile += cboChoixTypeFilename.SelectedItem;
            }
            int m = 0;  //index du tableau logs
            //Scann de tous les fichiers du répértoire:
            foreach (var fileinrun in Directory.GetFiles(folderpath, searchfile, SearchOption.AllDirectories))
            {
                string filename = fileinrun.ToString();
                fileinrunpath = fileinrun;  //attribuer le fullname au path
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);    //ne prendre que le nom à la fin du path avec extension
                string fileinrunext = filename.Substring(filename.LastIndexOf("."));    //l'extension du fichier en cours avec ses différentes variantes (docx, doc, ...).

                if (filename.Contains(txtTxtSearchFilename.Text))   //WIP de toute facon avec searchfile déjà bon !
                {
                    i++;

                    //Définition du noms du cours 
                    //Pour simplifier la tache pour retrouver le nom du cours avec le nom du dossier. On prend déjà le parent pour avoir le path du dossier du cours.
                    coursname = Directory.GetParent(fileinrunpath).ToString();
                    //On prend ICT ou MA:
                    indextypemodule = coursname.IndexOf("\\", coursname.LastIndexOf("\\") - 6);
                    typecours = coursname.Substring(indextypemodule + 1, coursname.LastIndexOf("\\") - indextypemodule - 1);   //nb de chars = différence de pos des deux "/"

                    //On prend le numéro du module la fin après le "/" :
                    if (typecours == "ma" || typecours == "MA" || typecours == "Ma" || typecours == "IEL" || typecours == "Iel" || typecours == "iel")
                    {
                        numcours = coursname.Substring(coursname.LastIndexOf("\\") + 1, 2);
                    }
                    else
                    {
                        numcours = coursname.Substring(coursname.LastIndexOf("\\") + 1, 3);
                    }
                    coursname = typecours + numcours;


                    //construire le lbl Result Structure.
                    newname = "";    //vider le nouveau nom du fichier précédent

                    //Générer le nouveau nom selon les paramètres:
                    newname = createnewfilname(false, filename, File.GetCreationTime(fileinrun));

                    //ajouter l'extension de ce fichier:
                    newname += fileinrunext;

                    //TODO: créer le dossier "Notes" si il n'existe pas:
                    // Directory.CreateDirectory();
                    lstHistorique.Items.Add(filename + " dont le cours est " + coursname + " a été renommé en " + newname);

                    string oldfileinrunpath = txtChoixRepertoire.Text + "\\" + typecours + "\\" + numcours + "\\" + filename;
                    Logs[m, 0] = oldfileinrunpath;  //ancien chemin du fichier: fichier inclus.
                    Logs[m, 1] = txtChoixRepertoire.Text + "\\" + typecours + "\\" + numcours + "\\" + newname;    //nouveau chemin du fichier: fichier inclus
                    if (File.Exists(Logs[m, 1]))
                    {
                        //ne rien faire.   
                    }
                    else
                    {
                        File.Move(Logs[m, 0], Logs[m, 1]);

                        //File.Copy(Logs[m,0], Logs[m, 1]);
                        //File.Delete(Logs[m, 0]);
                    }

                    //show logs for testings:
                    label1.Text += "\n " + Logs[m, 0] + "  EN  " + Logs[m, 1];
                    m++;
                    //label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;
                    //label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;

                    //supprimer l'ancien fichier nom renommé encore à l'emplacement dans le dossier du module:

                    //label1.Text += "\nFichier base supprimé: " + filename;

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

        string createnewfilname(bool fictivename, string currentname, DateTime dateofcreation) //créer le nouveau nom du fichier selon les paramètres et sans extension.
        {
            string newfilename = "";
            if (chkIntro.Checked && intro != "")    //si intro coché et rempli
            {
                newfilename += intro;   //ajouter l'introduction
            }
            if (cboSeparateur1.SelectedIndex > 0)   //si separateur est sélectionné et n'est pas aucun.
            {
                newfilename += cboSeparateur1.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 1
            }
            if (chkAcronyme.Checked && useracronyme != "")      //si acronyme coché et rempli
            {
                newfilename += useracronyme;   //on ajoute l'acronyme
            }
            if (cboSeparateur2.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
            {
                newfilename += cboSeparateur2.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 2
            }
            if (chkInclureNomCours.Checked)
            {
                if (fictivename == true)
                {
                    newfilename += "ICT114";    //on ajoute un nom de cours fictif
                }
                else
                {
                    newfilename += coursname;   //on ajoute le vrai nom du cours.
                }

            }
            if (cboSeparateur3.SelectedIndex > 0)  //si separateur est sélectionné et n'est pas aucun.
            {
                newfilename += cboSeparateur3.SelectedItem.ToString().Substring(0, 1);  //prendre le premier caractères de l'item qui est le séparateur 3
            }

            if (cboIntroSemaine.SelectedIndex >= 0) //slt si un item est sélectionné
            {
                newfilename += cboIntroSemaine.SelectedItem;    //on ajoute l'introduction de la semaine ou numéro
            }
            if (cboChoixNumeroFin.SelectedIndex >= 0)
            {
                if (cboChoixNumeroFin.SelectedItem.ToString() == "Numéro de semaine auto") //choix du numéro (semaine ou nom du fichier).
                {
                    if (fictivename == true)
                    {
                        newfilename += "6"; //numéro de semaine imaginaire
                    }
                    else
                    {
                        numsemaine = wichweek(dateofcreation);
                        newfilename += numsemaine;
                    }
                    numerofin = 0;

                }
                else
                {

                    if (fictivename == true)
                    {
                        newfilename += "5"; //numéro dans le fichier.
                    }
                    else
                    {
                        int numberinside;
                        //WIP todo
                        newfilename += numsemaine;
                    }
                    numerofin = 1;
                }
            }

            return newfilename; //retourne le nom généré.
        }

        int wichweek(DateTime dategiven)  //permet de trouver à quel semaine du cycle CPNV correspond une date donnée
        {
            int numweek = 0;
            int compare = -1;   //si négatif = date est avant, et si positif = date est après.

            DateTime dateinrun = listsofmondaythisyear[numweek];    //prend les dates des lundis des semaines CPNV

            while (compare < 0)
            {
                numweek++;  //prend la semaine suivante.
                dateinrun = listsofmondaythisyear[numweek];
                compare = dateinrun.CompareTo(dategiven);
            }
            numweek -= 1;   //c'est la semaine précédente.

            //On a le numéro de la semaine mais on doit %9 pour avoir le cycle de 9 semaines.


            while (numweek > 9)
            {
                numweek -= 9;
            }

            return numweek;
        }

        void lblResultStructureChange()     //changement des données lance un changement de la structure d'exemple
        {
            //recharge variables
            useracronyme = txtAcronyme.Text;    //acronyme du user.
            intro = txtIntro.Text;

            //construire le lbl Result Structure.
            string structureex = "de ";
            string namefictive = "";    //contient le nom fictive de départ.
            //nom avant:
            switch (cboPositionTxtSearchFilename.SelectedItem)
            {
                case "commencant par":
                    namefictive += txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
                case "contenant":
                    namefictive += "test-" + txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
                case "se terminant par":
                    namefictive += "test-" + "5" + txtTxtSearchFilename.Text + cboChoixTypeFilename.Text;
                    break;
                default:
                    namefictive += txtTxtSearchFilename.Text + "5" + cboChoixTypeFilename.Text;
                    break;
            }
            structureex += namefictive;
            structureex += " renommé en ";

            structureex += createnewfilname(true, namefictive, new DateTime(2019, 10, 04));    //nouveau nom fictif généré avec une date fictive

            structureex += cboChoixTypeFilename.SelectedItem;   //ajout de l'extension:

            lblResultStructure.Text = structureex;
        }

        private void FrmFileRenamer_Load(object sender, EventArgs e)
        {
            //Au chargement du formulaire, charger les préconfigurations.
            //TODO: chercher fichiers de configuration, si trouve affiche dans le combobox en selectionnant le dernier utilisé(selon la date de derniere utilisation dans le fichier).

            //init variables
            useracronyme = txtAcronyme.Text;    //acronyme du user.
            intro = txtIntro.Text;
            listsofmondaythisyear[0] = new DateTime(1900, 1, 9);

            txtChoixRepertoire.Text = placeholderchoixrepertoire;
            cmdLancer.Focus();  //????????
            lblCheckRepertoire.Visible = false;

            //Charger les dates des lundis:
            StreamReader lecteur = null;
            int nbmondaysinlist = 0;
            using (lecteur = new StreamReader("listofmonday.txt"))
            {
                string ligneinrun = ""; //ligne lue en cours

                while (ligneinrun != "## END")  //tant que la dernière ligne du fichier n'est pas atteinte
                {
                    ligneinrun = lecteur.ReadLine();    //lire la ligne suivante
                    if (ligneinrun.StartsWith("#") == false && ligneinrun != "") //traiter la valeur de la ligne si commence pas avec # pour ne pas traiter les commentaires
                    {
                        listsofmondaythisyear[nbmondaysinlist + 1] = DateTime.Parse(ligneinrun);   //mettre dans le tableau de lundis à la case suivante, la ligne convertie en datetime
                        nbmondaysinlist++;
                    }
                }
            }

            //Valeurs par défaut pour les tests:
            cboPositionTxtSearchFilename.SelectedIndex = 0;
            cboChoixTypeFilename.SelectedIndex = 1;
            cboSeparateur1.SelectedIndex = 1;
            cboSeparateur2.SelectedIndex = 3;
            cboSeparateur3.SelectedIndex = 2;
            cboIntroSemaine.SelectedIndex = 1;
            cboChoixNumeroFin.SelectedIndex = 0;

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


            lblResultStructureChange();
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



        private void cboSeparateur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void CboChoixTypeFilename_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void TxtTxtSearchFilename_TextChanged(object sender, EventArgs e)
        {
            lblResultStructureChange();
        }

        private void CmdClearLogs_Click(object sender, EventArgs e)
        {
            lstHistorique.Items.Clear();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstHistorique.Items.Count; i++)
            {
                File.Move(Logs[i, 1], Logs[i, 0]);  //renommer du nouveau nom avec l'ancien. (move dans le meme dossier avec un autre nom)
            }
        }
    }
}
