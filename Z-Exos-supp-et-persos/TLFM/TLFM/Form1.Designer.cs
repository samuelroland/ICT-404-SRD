namespace TLFM
{
    partial class frmTLFM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNomRepertoire = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chklstFilesFound = new System.Windows.Forms.CheckedListBox();
            this.txtChoixRepertoire = new System.Windows.Forms.TextBox();
            this.fbdChoixRepertoire = new System.Windows.Forms.FolderBrowserDialog();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.lblFileInRun = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.lblResultLogs = new System.Windows.Forms.Label();
            this.lstLogsManagement = new System.Windows.Forms.ListBox();
            this.lblLogsManagement = new System.Windows.Forms.Label();
            this.lblGestionInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkProtegerExtension = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(654, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "TooLongFileManager est comme son nom l\'indique, un moyen de gérer les fichiers av" +
    "ec des noms trop longs et qui posent des problèmes.";
            // 
            // lblNomRepertoire
            // 
            this.lblNomRepertoire.AutoSize = true;
            this.lblNomRepertoire.Location = new System.Drawing.Point(9, 45);
            this.lblNomRepertoire.Name = "lblNomRepertoire";
            this.lblNomRepertoire.Size = new System.Drawing.Size(269, 13);
            this.lblNomRepertoire.TabIndex = 1;
            this.lblNomRepertoire.Text = "Choix du répertoire de recherche (sous dossiers inclus): ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 551);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // chklstFilesFound
            // 
            this.chklstFilesFound.CheckOnClick = true;
            this.chklstFilesFound.FormattingEnabled = true;
            this.chklstFilesFound.Items.AddRange(new object[] {
            "fichier machin à la\'dresse machin....",
            "fichier machin à la\'dresse machin.... 456465",
            "fichier machin à la\'dresse machin.... 45132",
            "fichier machin à la\'dresse machin....af sdfsadf"});
            this.chklstFilesFound.Location = new System.Drawing.Point(12, 271);
            this.chklstFilesFound.Name = "chklstFilesFound";
            this.chklstFilesFound.Size = new System.Drawing.Size(1559, 154);
            this.chklstFilesFound.TabIndex = 3;
            // 
            // txtChoixRepertoire
            // 
            this.txtChoixRepertoire.Location = new System.Drawing.Point(284, 42);
            this.txtChoixRepertoire.Name = "txtChoixRepertoire";
            this.txtChoixRepertoire.Size = new System.Drawing.Size(379, 20);
            this.txtChoixRepertoire.TabIndex = 4;
            this.txtChoixRepertoire.Text = "D:\\zttes sauvegardes temp";
            // 
            // fbdChoixRepertoire
            // 
            this.fbdChoixRepertoire.Description = "Choix du répertoire de scan";
            this.fbdChoixRepertoire.SelectedPath = "C:\\";
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(679, 40);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(109, 23);
            this.btnParcourir.TabIndex = 5;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.BtnExplorateur_Click);
            // 
            // lblFileInRun
            // 
            this.lblFileInRun.AutoSize = true;
            this.lblFileInRun.Location = new System.Drawing.Point(12, 91);
            this.lblFileInRun.Name = "lblFileInRun";
            this.lblFileInRun.Size = new System.Drawing.Size(167, 13);
            this.lblFileInRun.TabIndex = 6;
            this.lblFileInRun.Text = "Recherche sur : NomDuFichier.txt";
            // 
            // lstLogs
            // 
            this.lstLogs.ForeColor = System.Drawing.Color.DarkBlue;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.HorizontalScrollbar = true;
            this.lstLogs.Items.AddRange(new object[] {
            "nomfichier",
            "asdfsdaf",
            "asd",
            "f",
            "sdaf",
            "sda",
            "h"});
            this.lstLogs.Location = new System.Drawing.Point(15, 107);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(1556, 134);
            this.lstLogs.TabIndex = 7;
            // 
            // btnLancer
            // 
            this.btnLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLancer.Location = new System.Drawing.Point(623, 69);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(165, 32);
            this.btnLancer.TabIndex = 8;
            this.btnLancer.Text = "Lancer la recherche";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.BtnLancer_Click);
            // 
            // lblResultLogs
            // 
            this.lblResultLogs.AutoSize = true;
            this.lblResultLogs.Location = new System.Drawing.Point(12, 244);
            this.lblResultLogs.Name = "lblResultLogs";
            this.lblResultLogs.Size = new System.Drawing.Size(98, 13);
            this.lblResultLogs.TabIndex = 9;
            this.lblResultLogs.Text = "nbs fichiers trouvés";
            // 
            // lstLogsManagement
            // 
            this.lstLogsManagement.ForeColor = System.Drawing.Color.DarkBlue;
            this.lstLogsManagement.FormattingEnabled = true;
            this.lstLogsManagement.HorizontalScrollbar = true;
            this.lstLogsManagement.Items.AddRange(new object[] {
            "fichier xxx.txt renommé en xx.txt",
            "répertoire asjkfdlsajdfjklas fjkslad fjklsadf renommé en salut",
            "repertoire tjasklfdjskaldf jskladf jskladf jsakldf temp supprimé",
            "fichier asdfjklasfdsa djklsjkldfjasfsadf sajfkadsj fklsjda.cool supprimé"});
            this.lstLogsManagement.Location = new System.Drawing.Point(15, 580);
            this.lstLogsManagement.Name = "lstLogsManagement";
            this.lstLogsManagement.Size = new System.Drawing.Size(1556, 134);
            this.lstLogsManagement.TabIndex = 11;
            this.toolTip1.SetToolTip(this.lstLogsManagement, "salut cool depuis propriö");
            // 
            // lblLogsManagement
            // 
            this.lblLogsManagement.AutoSize = true;
            this.lblLogsManagement.Location = new System.Drawing.Point(12, 564);
            this.lblLogsManagement.Name = "lblLogsManagement";
            this.lblLogsManagement.Size = new System.Drawing.Size(93, 13);
            this.lblLogsManagement.TabIndex = 10;
            this.lblLogsManagement.Text = "Logs de la gestion";
            this.lblLogsManagement.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblGestionInfo
            // 
            this.lblGestionInfo.Location = new System.Drawing.Point(12, 456);
            this.lblGestionInfo.Name = "lblGestionInfo";
            this.lblGestionInfo.Size = new System.Drawing.Size(765, 29);
            this.lblGestionInfo.TabIndex = 12;
            this.lblGestionInfo.Text = "Gestion des cas\r\nLes actions s\'appliquent au cas sélectionnés. On peut supprimer," +
    " renommer un répertoire particulier ou le fichier, mais aussi ouvrir dans l\'expl" +
    "oreur.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Supprimer ...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1119, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Renommer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ouvrir dans l\'explorateur";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Tout sélectionner";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Tout déselectionner";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Renommage: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fichier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dossier";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(703, 520);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 20);
            this.textBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "P:",
            "Test",
            "sadfsa"});
            this.comboBox1.Location = new System.Drawing.Point(435, 520);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "en";
            // 
            // chkProtegerExtension
            // 
            this.chkProtegerExtension.AutoSize = true;
            this.chkProtegerExtension.Location = new System.Drawing.Point(431, 493);
            this.chkProtegerExtension.Name = "chkProtegerExtension";
            this.chkProtegerExtension.Size = new System.Drawing.Size(114, 17);
            this.chkProtegerExtension.TabIndex = 26;
            this.chkProtegerExtension.Text = "Protéger extension";
            this.chkProtegerExtension.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1119, 516);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Renommer";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImage = global::TLFM.Properties.Resources.fleche_2_gauche;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(637, 514);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 27);
            this.button7.TabIndex = 28;
            this.toolTip1.SetToolTip(this.button7, "Changer de dossier à renommer. Passer au dossier parent.");
            this.button7.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmTLFM
            // 
            this.AccessibleDescription = "TLFM";
            this.AccessibleName = "TooLongFileManager";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 726);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.chkProtegerExtension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGestionInfo);
            this.Controls.Add(this.lstLogsManagement);
            this.Controls.Add(this.lblLogsManagement);
            this.Controls.Add(this.lblResultLogs);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.lblFileInRun);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.txtChoixRepertoire);
            this.Controls.Add(this.chklstFilesFound);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblNomRepertoire);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmTLFM";
            this.Text = "TLFM - TooLongFileManager";
            this.Load += new System.EventHandler(this.FrmTLFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNomRepertoire;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox chklstFilesFound;
        private System.Windows.Forms.TextBox txtChoixRepertoire;
        private System.Windows.Forms.FolderBrowserDialog fbdChoixRepertoire;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Label lblFileInRun;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Label lblResultLogs;
        private System.Windows.Forms.ListBox lstLogsManagement;
        private System.Windows.Forms.Label lblLogsManagement;
        private System.Windows.Forms.Label lblGestionInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkProtegerExtension;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

