﻿//Programme: Trombinoscope dynamique, exo de Moodle. Programme d'envoi des données ProfilSender dans le même dossier racine.
//Auteur: Samuel Roland
//Date: codé sur le 22 (tte après-midi) et 23 juin 2019 (matin). Environ 6-7 heures de travail pour ce programme (c'est à dire sans compter ProfilSender).

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

namespace Trombinoscope
{
    public partial class frmTrombinoscope : Form
    {
        string username = Environment.UserName;
        
        public frmTrombinoscope()
        {
            InitializeComponent();
        }
        const int margin = 20;
        const int widthpersonne = 90;
        const int heightpersonne = 170;
        int positionX = 0;
        int positionY = 0;

        private void frmTrombinoscope_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenue sur le trombinoscope dynamique. Pour info: les fichiers de profils sont stockés dans le dossier profils. Les deux programmes: Trombinoscope.exe et ProfilSender.exe doivent rester à cette emplacement!");
            tmrActualiser.Enabled=true;
            //Prendre le prénom de l'utilisateur:
            username= username.Substring(0, username.IndexOf("."));
            this.Text = "Tous vu par " + username;
        }
        string ligne = null;
        StreamReader fluxInfos = null;
        DirectoryInfo folder = new DirectoryInfo("Profils");
        string presenceencours = "cas";
        int humeurencours = 0;   //Humeur du fichier en cours de traitement.
        string msgencours = "msg en cours ";
        string[] fichiersconnus = new string[50];    //contient les noms des fichiers connus.
        int nbfichiersaffiche = 0;  //nombre de fichiers affichés, donc aussi nombre de fichiers connus dans le tableau fichiersconnus.
        int nbpersononligne = 0;  //nombre de personnes affichée sur la ligne
        int nbligneaffiche = 0; //nombre de lignes affichées entière
        
        private bool estdejaaffiche(string filename)
        {
            //Cette fonction va répondre si le fichier est déjà connu, donc que la personne est déjà affiché.
            //... dans le but de savoir si le fichier est nouveau ou bien qu'il a déjà été affiché.

            if (fichiersconnus.Contains(filename) == true)
            {
                return true;
            }
            else
            {
                //si le fichier n'y est pas il faut l'ajouter puisque on va le traiter et l'afficher:
                fichiersconnus[nbfichiersaffiche] = filename;
            }
            return false;
            //Pour cela chaque fois il faut avoir à disposition un tableau des fichiers.
        }
        private void positionlabelscalcul()
        {
            //WIP ici
            //Incrémentation des compteurs:
            if (nbfichiersaffiche % 5 == 0)
            {
                if (nbfichiersaffiche >= 5)   //que a partir du bout de la ligne qu'il faut incrémenter.
                {
                    nbligneaffiche++;
                }
                nbpersononligne = 0;
            }
            //PositionX et PositionY à calculer selon le nbdefichiersaffiche
            positionX = nbpersononligne * (margin + widthpersonne) + margin;
            positionY = margin + nbligneaffiche * (margin + heightpersonne);

        }

        List<Label> labelscollection = new List<Label>();
        private void lireactuaff()
        {   //fonction qui lit actualise les données et les affiche.

            string userinrun = "personne";  //nom du user en cours de traitement

            foreach (var file in folder.GetFiles()) //scan de tous les fichiers
            {
                using (fluxInfos = new StreamReader("Profils\\" + file.Name))
                {
                    userinrun = file.Name.Substring(0, file.Name.IndexOf("."));
                    //si le tableau de fichiers connus ne contient pas le nom de fichier en cours.
                    if (estdejaaffiche(file.Name) == false)
                    {
                        //On créé dynamiquement une nouvelle personne:
                        this.lblMsg = new System.Windows.Forms.Label();
                        this.lblNom = new System.Windows.Forms.Label();
                        this.lblIcon = new System.Windows.Forms.Label();

                        // 
                        // lblMsg
                        // 
                        this.lblMsg.BackColor = System.Drawing.Color.White;
                        this.lblMsg.Location = new System.Drawing.Point(20, 130);
                        this.lblMsg.Name = "lblMsg" + userinrun;
                        this.lblMsg.Size = new System.Drawing.Size(widthpersonne, 64);
                        this.lblMsg.TabIndex = 7;
                        this.lblMsg.Text = "msg à remplir";
                        lblNomsLabels.Text += "  " + lblMsg.Name;
                        // 
                        // lblNom
                        // 
                        this.lblNom.BackColor = System.Drawing.Color.Green;
                        this.lblNom.Location = new System.Drawing.Point(20, 117);
                        this.lblNom.Name = "lblNom" + userinrun;
                        this.lblNom.Size = new System.Drawing.Size(widthpersonne, 13);
                        this.lblNom.TabIndex = 5;
                        this.lblNom.Text = "Prénom !";
                        this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        lblNomsLabels.Text += "  " + lblNom.Name;
                        // 
                        // lblIcon
                        // 
                        this.lblIcon.BackColor = System.Drawing.Color.Green;
                        this.lblIcon.Image = global::Trombinoscope.Properties.Resources.content;
                        this.lblIcon.Location = new System.Drawing.Point(20, 20);
                        this.lblIcon.Name = "lblIcon" + userinrun;
                        this.lblIcon.Size = new System.Drawing.Size(widthpersonne, 110);
                        this.lblIcon.TabIndex = 6;
                        lblNomsLabels.Text += "  " + lblIcon.Name;

                        //Calcul des positions de l'icone de la personne et déductions des 2 autres labels.
                        positionlabelscalcul();
                        //On la positionne sur le formulaire:
                        this.lblMsg.Location = new Point(positionX, positionY + 110);
                        this.lblNom.Location = new Point(positionX, positionY + 97);
                        this.lblIcon.Location = new Point(positionX, positionY);

                        //On ajoute les labels de la personne à la collection "labelscollection"

                        labelscollection.Add(lblMsg);
                        labelscollection.Add(lblNom);
                        labelscollection.Add(lblIcon);
                        //On les ajoute au formulaire:
                        Controls.Add(lblMsg);
                        Controls.Add(lblNom);
                        Controls.Add(lblIcon);

                        //changer les noms si vrm besoin (?WIP)
                        this.lblMsg.Name = "lblMsg" + userinrun;
                        this.lblNom.Name = "lblNom" + userinrun;
                        this.lblIcon.Name = "lblIcon" + userinrun;
                        //Il y a un fichier affiché de plus:
                        nbpersononligne++;
                        nbfichiersaffiche++;
                    }
                    //Puis on le charge ou recharge le fichier (aucune différence dans la procédure):

                    ligne = fluxInfos.ReadLine();
                    presenceencours = ligne;
                    ligne = fluxInfos.ReadLine();
                    humeurencours = int.Parse(ligne);
                    ligne = fluxInfos.ReadLine();
                    msgencours = ligne;

                }//on a plus besoin du fichier en cours alors on peut le fermer.

                //Une fois les données prises, l'affichage ou la recharge peut arriver (aucune différence dans la procédure):

                foreach (Label labelinrun in labelscollection) //scan de tous les labels qui se trouvent dans la collection "labelscollection".
                {

                    if (labelinrun.Name.Contains(userinrun))
                    {
                        if (labelinrun.Name.Contains("lblMsg"))
                        {
                            labelinrun.Text = msgencours;   //le msg
                        }

                        if (labelinrun.Name.Contains("lblNom"))
                        {
                            labelinrun.Text = userinrun;   //le prénom de la personne, avec le nom de fichier.

                            if (presenceencours == "1")
                            {
                                labelinrun.BackColor = Color.Green;
                            }
                            else
                            {
                                labelinrun.BackColor = Color.Red;
                            }
                        }

                        if (labelinrun.Name.Contains("lblIcon"))
                        {
                            switch (humeurencours)  //L'humeur va de 1 à 5.
                            {
                                case 1:
                                    labelinrun.Image = Properties.Resources.content;
                                    break;
                                case 2:
                                    labelinrun.Image = Properties.Resources.cool;
                                    break;
                                case 3:
                                    labelinrun.Image = Properties.Resources.nerveux;
                                    break;
                                case 4:
                                    labelinrun.Image = Properties.Resources.pascontent;
                                    break;
                                case 5:
                                    labelinrun.Image = Properties.Resources.angelique;
                                    break;
                                default:
                                    MessageBox.Show("Humeur corrompue... avez vous bidouillé le fichier ?");
                                    break;
                            }
                            //la présence:
                            if (presenceencours == "0")
                            {
                                labelinrun.BackColor = Color.Red;
                            }
                            else
                            {
                                labelinrun.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }

        private void TmrActualiser_Tick(object sender, EventArgs e)
        {
            lireactuaff();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lireactuaff();
        }
    }
}
