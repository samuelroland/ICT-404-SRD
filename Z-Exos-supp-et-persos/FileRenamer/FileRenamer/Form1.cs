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



        private void CmdLancer_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo("C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\ICT\\123");
            //test pour début de renommer un fichier:
            StreamWriter ecrivain = null;
            int i = 0;
            string newname; //nouveau nom que le fichier aura.
            string coursname = "ICT114";   //nom du cours correspondant aux notes.
            string typecours;   //type du cours, MA ou ICT.
            string numcours;    //numéro du cours, ex: 114.
            string useracronyme = "SRD";    //acronyme du user.
            int numsemaine = 1; //numéro de la semaine en cours.
            string fileinrunpath;   //chemin accès au fichier en cours.
            int indextypemodule = 0;
            //Scann de tous les fichiers du répértoire:
            foreach (var fileinrun in folder.GetFiles())
            {

                if (fileinrun.Name.Contains("doc"))
                {
                    fileinrunpath = fileinrun.FullName;
                    i++;
                    label1.Text += "\nFichier base supprimé: " + fileinrun.Name;

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
                    newname = String.Format("Nts-{0}_{1}-S{2}.docx", useracronyme, coursname, numsemaine);

                    //TODO: créer le dossier "Notes" si il n'existe pas:
                    // Directory.CreateDirectory();

                    string oldfileinrunpath = "C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\" + typecours + "\\" + numcours + "\\" + fileinrun.Name;
                    File.Copy(oldfileinrunpath, "C:\\Users\\PC_Samuel_01\\Documents\\TEMP\\testsFilerenamer\\2emeannee\\ICT\\123\\Notes\\" + newname);
                    label1.Text += " et fichier " + newname + " a été créé et posé à " + fileinrunpath;

                    //supprimer l'ancien fichier nom renommé encore à l'emplacement dans le dossier du module:
                    File.Delete(oldfileinrunpath);


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





            //vider les résultats:
            label1.Text = "";
        }
    }
}
