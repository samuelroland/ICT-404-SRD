namespace FileRenamer
{
    partial class frmFileRenamer
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
            this.cmdLancer = new System.Windows.Forms.Button();
            this.lblChoixRepertoire = new System.Windows.Forms.Label();
            this.txtChoixRepertoire = new System.Windows.Forms.TextBox();
            this.cmdParcourir = new System.Windows.Forms.Button();
            this.fbdChoixRepertoire = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCheckRepertoire = new System.Windows.Forms.Label();
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.txtAcronyme = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.cmdUseUniqueNames = new System.Windows.Forms.Button();
            this.cmdNotTraiter = new System.Windows.Forms.Button();
            this.cmdEcraser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.chkAppliquerttserros = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHistorique = new System.Windows.Forms.ListBox();
            this.lblHistorique = new System.Windows.Forms.Label();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.chkAcronyme = new System.Windows.Forms.CheckBox();
            this.lblResultStructureInfo = new System.Windows.Forms.Label();
            this.lblResultStructure = new System.Windows.Forms.Label();
            this.cboSeparateur1 = new System.Windows.Forms.ComboBox();
            this.lblDepartInfo = new System.Windows.Forms.Label();
            this.lblGestionErreursInfo = new System.Windows.Forms.Label();
            this.lblTxtSearchFilename = new System.Windows.Forms.Label();
            this.cboPositionTxtSearchFilename = new System.Windows.Forms.ComboBox();
            this.txtTxtSearchFilename = new System.Windows.Forms.TextBox();
            this.lblChoixTypeFilename = new System.Windows.Forms.Label();
            this.cboChoixTypeFilename = new System.Windows.Forms.ComboBox();
            this.chkInclureNomCours = new System.Windows.Forms.CheckBox();
            this.cboSeparateur2 = new System.Windows.Forms.ComboBox();
            this.cboSeparateur3 = new System.Windows.Forms.ComboBox();
            this.cboIntroSemaine = new System.Windows.Forms.ComboBox();
            this.cboChoixNumeroFin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValidationCours = new System.Windows.Forms.Button();
            this.cmdClearLogs = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdLancer
            // 
            this.cmdLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLancer.Location = new System.Drawing.Point(821, 8);
            this.cmdLancer.Name = "cmdLancer";
            this.cmdLancer.Size = new System.Drawing.Size(78, 32);
            this.cmdLancer.TabIndex = 2;
            this.cmdLancer.Text = "Lancer !";
            this.cmdLancer.UseVisualStyleBackColor = true;
            this.cmdLancer.Click += new System.EventHandler(this.CmdLancer_Click);
            // 
            // lblChoixRepertoire
            // 
            this.lblChoixRepertoire.AutoSize = true;
            this.lblChoixRepertoire.Location = new System.Drawing.Point(32, 78);
            this.lblChoixRepertoire.Name = "lblChoixRepertoire";
            this.lblChoixRepertoire.Size = new System.Drawing.Size(263, 13);
            this.lblChoixRepertoire.TabIndex = 2;
            this.lblChoixRepertoire.Text = "Répertoire de recherche (les sous-dossiers sont inclus)";
            // 
            // txtChoixRepertoire
            // 
            this.txtChoixRepertoire.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChoixRepertoire.Location = new System.Drawing.Point(301, 75);
            this.txtChoixRepertoire.Name = "txtChoixRepertoire";
            this.txtChoixRepertoire.Size = new System.Drawing.Size(517, 20);
            this.txtChoixRepertoire.TabIndex = 6;
            this.txtChoixRepertoire.Text = "C:\\Users\\samuel.roland\\Documents\\Github\\ICT-404-SRD\\Z-Exos-supp-et-persos\\FileRen" +
    "amer\\FileRenamer\\bin\\Debug\\2emeanneetest";
            this.txtChoixRepertoire.TextChanged += new System.EventHandler(this.TxtChoixRepertoire_TextChanged);
            this.txtChoixRepertoire.Enter += new System.EventHandler(this.TxtChoixRepertoire_Enter);
            this.txtChoixRepertoire.Leave += new System.EventHandler(this.TxtChoixRepertoire_Leave);
            // 
            // cmdParcourir
            // 
            this.cmdParcourir.Location = new System.Drawing.Point(824, 74);
            this.cmdParcourir.Name = "cmdParcourir";
            this.cmdParcourir.Size = new System.Drawing.Size(75, 23);
            this.cmdParcourir.TabIndex = 7;
            this.cmdParcourir.Text = "Parcourir";
            this.cmdParcourir.UseVisualStyleBackColor = true;
            this.cmdParcourir.Click += new System.EventHandler(this.CmdParcourir_Click);
            // 
            // fbdChoixRepertoire
            // 
            this.fbdChoixRepertoire.SelectedPath = "C:\\Users\\samuel.roland\\Documents\\Github\\ICT-404-SRD\\Z-Exos-supp-et-persos\\FileRen" +
    "amer\\FileRenamer\\bin\\Debug\\2emeanneetest - Copie";
            // 
            // lblCheckRepertoire
            // 
            this.lblCheckRepertoire.AutoSize = true;
            this.lblCheckRepertoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckRepertoire.ForeColor = System.Drawing.Color.Red;
            this.lblCheckRepertoire.Location = new System.Drawing.Point(767, 55);
            this.lblCheckRepertoire.Name = "lblCheckRepertoire";
            this.lblCheckRepertoire.Size = new System.Drawing.Size(132, 13);
            this.lblCheckRepertoire.TabIndex = 5;
            this.lblCheckRepertoire.Text = "Répertoire inexistant !";
            // 
            // txtIntro
            // 
            this.txtIntro.Location = new System.Drawing.Point(83, 101);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(85, 20);
            this.txtIntro.TabIndex = 9;
            this.txtIntro.Text = "Notes";
            this.txtIntro.TextChanged += new System.EventHandler(this.txtIntro_TextChanged);
            // 
            // txtAcronyme
            // 
            this.txtAcronyme.Location = new System.Drawing.Point(356, 102);
            this.txtAcronyme.Name = "txtAcronyme";
            this.txtAcronyme.Size = new System.Drawing.Size(63, 20);
            this.txtAcronyme.TabIndex = 11;
            this.txtAcronyme.Text = "SRD";
            this.txtAcronyme.TextChanged += new System.EventHandler(this.txtAcronyme_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enregistrer une nouvelle préconfiguration à partir des infos choisies ci-dessous",
            "Renommer la préconfiguration selectionnée",
            "Supprimer la préconfiguration selectionnée",
            "---------------------------------------------------------------------------------" +
                "---",
            "préconfig1 SRD pour docx"});
            this.comboBox1.Location = new System.Drawing.Point(366, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(449, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Préconfiguration choisie: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Erreurs à gérer:";
            // 
            // lstErrors
            // 
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.Items.AddRange(new object[] {
            "error: fichier .... existe déjà.",
            "impossible d\'écrire dans cette endroit",
            "ajkslfsafsasa",
            "f",
            "sa",
            "s",
            "sa",
            "sfafasgags"});
            this.lstErrors.Location = new System.Drawing.Point(35, 518);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(753, 121);
            this.lstErrors.TabIndex = 16;
            // 
            // cmdUseUniqueNames
            // 
            this.cmdUseUniqueNames.Location = new System.Drawing.Point(414, 643);
            this.cmdUseUniqueNames.Name = "cmdUseUniqueNames";
            this.cmdUseUniqueNames.Size = new System.Drawing.Size(150, 23);
            this.cmdUseUniqueNames.TabIndex = 17;
            this.cmdUseUniqueNames.Text = "Utiliser des noms uniques";
            this.cmdUseUniqueNames.UseVisualStyleBackColor = true;
            this.cmdUseUniqueNames.Click += new System.EventHandler(this.CmdUseUniqueNames_Click);
            // 
            // cmdNotTraiter
            // 
            this.cmdNotTraiter.Location = new System.Drawing.Point(570, 643);
            this.cmdNotTraiter.Name = "cmdNotTraiter";
            this.cmdNotTraiter.Size = new System.Drawing.Size(134, 23);
            this.cmdNotTraiter.TabIndex = 18;
            this.cmdNotTraiter.Text = "Ne pas traiter ce fichier";
            this.cmdNotTraiter.UseVisualStyleBackColor = true;
            this.cmdNotTraiter.Click += new System.EventHandler(this.CmdNotTraiter_Click);
            // 
            // cmdEcraser
            // 
            this.cmdEcraser.Location = new System.Drawing.Point(710, 643);
            this.cmdEcraser.Name = "cmdEcraser";
            this.cmdEcraser.Size = new System.Drawing.Size(78, 23);
            this.cmdEcraser.TabIndex = 19;
            this.cmdEcraser.Text = "Ecraser...";
            this.cmdEcraser.UseVisualStyleBackColor = true;
            this.cmdEcraser.Click += new System.EventHandler(this.CmdEcraser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Action pour le fichier selectionné:";
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuitter.Location = new System.Drawing.Point(713, 688);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 21;
            this.cmdQuitter.Text = "Quitter...";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // chkAppliquerttserros
            // 
            this.chkAppliquerttserros.AutoSize = true;
            this.chkAppliquerttserros.Location = new System.Drawing.Point(35, 647);
            this.chkAppliquerttserros.Name = "chkAppliquerttserros";
            this.chkAppliquerttserros.Size = new System.Drawing.Size(138, 17);
            this.chkAppliquerttserros.TabIndex = 22;
            this.chkAppliquerttserros.Text = "Appliquer l\'action à tous";
            this.chkAppliquerttserros.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 92);
            this.label4.TabIndex = 23;
            this.label4.Text = "Explication des actions:\r\n...........\r\n..........\r\n.....\r\n.\r\n.\r\n.\r\n.\r\n.\r\n";
            // 
            // lstHistorique
            // 
            this.lstHistorique.FormattingEnabled = true;
            this.lstHistorique.Items.AddRange(new object[] {
            "pris doc1.docx et mis dans Répertoire\\ict\\123\\notes\\ sous meme nom",
            "pris doc1.docx et mis dans Répertoire\\ict\\123\\notes\\ sous .....-2.docx"});
            this.lstHistorique.Location = new System.Drawing.Point(35, 254);
            this.lstHistorique.Name = "lstHistorique";
            this.lstHistorique.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstHistorique.Size = new System.Drawing.Size(753, 199);
            this.lstHistorique.TabIndex = 24;
            // 
            // lblHistorique
            // 
            this.lblHistorique.AutoSize = true;
            this.lblHistorique.Location = new System.Drawing.Point(32, 238);
            this.lblHistorique.Name = "lblHistorique";
            this.lblHistorique.Size = new System.Drawing.Size(191, 13);
            this.lblHistorique.TabIndex = 25;
            this.lblHistorique.Text = "Historique des fichiers traités à l\'instant:";
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Checked = true;
            this.chkIntro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntro.Location = new System.Drawing.Point(35, 101);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(47, 17);
            this.chkIntro.TabIndex = 8;
            this.chkIntro.Text = "Intro";
            this.chkIntro.UseVisualStyleBackColor = true;
            this.chkIntro.CheckedChanged += new System.EventHandler(this.ChkIntro_CheckedChanged);
            // 
            // chkAcronyme
            // 
            this.chkAcronyme.AutoSize = true;
            this.chkAcronyme.Checked = true;
            this.chkAcronyme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAcronyme.Location = new System.Drawing.Point(244, 104);
            this.chkAcronyme.Name = "chkAcronyme";
            this.chkAcronyme.Size = new System.Drawing.Size(109, 17);
            this.chkAcronyme.TabIndex = 11;
            this.chkAcronyme.Text = "Acronyme/Auteur";
            this.chkAcronyme.UseVisualStyleBackColor = true;
            this.chkAcronyme.CheckedChanged += new System.EventHandler(this.ChkAcronyme_CheckedChanged);
            // 
            // lblResultStructureInfo
            // 
            this.lblResultStructureInfo.AutoSize = true;
            this.lblResultStructureInfo.Location = new System.Drawing.Point(32, 171);
            this.lblResultStructureInfo.Name = "lblResultStructureInfo";
            this.lblResultStructureInfo.Size = new System.Drawing.Size(225, 13);
            this.lblResultStructureInfo.TabIndex = 28;
            this.lblResultStructureInfo.Text = "Exemple de la structure avec ces paramètres: ";
            // 
            // lblResultStructure
            // 
            this.lblResultStructure.AutoSize = true;
            this.lblResultStructure.Location = new System.Drawing.Point(263, 171);
            this.lblResultStructure.Name = "lblResultStructure";
            this.lblResultStructure.Size = new System.Drawing.Size(241, 13);
            this.lblResultStructure.TabIndex = 29;
            this.lblResultStructure.Text = "de docnotes2.docx à Ntes-SRD_ICT114-S2.docx";
            // 
            // cboSeparateur1
            // 
            this.cboSeparateur1.FormattingEnabled = true;
            this.cboSeparateur1.Items.AddRange(new object[] {
            "aucun",
            "- tiret",
            "_ tiret bas",
            ". point",
            " espace"});
            this.cboSeparateur1.Location = new System.Drawing.Point(178, 101);
            this.cboSeparateur1.Name = "cboSeparateur1";
            this.cboSeparateur1.Size = new System.Drawing.Size(57, 21);
            this.cboSeparateur1.TabIndex = 10;
            this.cboSeparateur1.Text = "Séparateur";
            this.cboSeparateur1.SelectedIndexChanged += new System.EventHandler(this.cboSeparateur1_SelectedIndexChanged);
            // 
            // lblDepartInfo
            // 
            this.lblDepartInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblDepartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartInfo.Location = new System.Drawing.Point(32, 14);
            this.lblDepartInfo.Name = "lblDepartInfo";
            this.lblDepartInfo.Size = new System.Drawing.Size(196, 55);
            this.lblDepartInfo.TabIndex = 31;
            this.lblDepartInfo.Text = "Choisissez une préconfiguration ou entrez les paramètres.";
            // 
            // lblGestionErreursInfo
            // 
            this.lblGestionErreursInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblGestionErreursInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionErreursInfo.Location = new System.Drawing.Point(341, 484);
            this.lblGestionErreursInfo.Name = "lblGestionErreursInfo";
            this.lblGestionErreursInfo.Size = new System.Drawing.Size(447, 22);
            this.lblGestionErreursInfo.TabIndex = 32;
            this.lblGestionErreursInfo.Text = "Gérez les erreurs provoquées par des fichiers déjà existants";
            // 
            // lblTxtSearchFilename
            // 
            this.lblTxtSearchFilename.AutoSize = true;
            this.lblTxtSearchFilename.Location = new System.Drawing.Point(234, 51);
            this.lblTxtSearchFilename.Name = "lblTxtSearchFilename";
            this.lblTxtSearchFilename.Size = new System.Drawing.Size(136, 13);
            this.lblTxtSearchFilename.TabIndex = 33;
            this.lblTxtSearchFilename.Text = "Nom des fichiers (sans ext.)";
            // 
            // cboPositionTxtSearchFilename
            // 
            this.cboPositionTxtSearchFilename.FormattingEnabled = true;
            this.cboPositionTxtSearchFilename.Items.AddRange(new object[] {
            "commencant par",
            "contenant",
            "se terminant par"});
            this.cboPositionTxtSearchFilename.Location = new System.Drawing.Point(347, 48);
            this.cboPositionTxtSearchFilename.Name = "cboPositionTxtSearchFilename";
            this.cboPositionTxtSearchFilename.Size = new System.Drawing.Size(90, 21);
            this.cboPositionTxtSearchFilename.TabIndex = 3;
            this.cboPositionTxtSearchFilename.SelectedIndexChanged += new System.EventHandler(this.donneesmodifiees);
            // 
            // txtTxtSearchFilename
            // 
            this.txtTxtSearchFilename.Location = new System.Drawing.Point(443, 49);
            this.txtTxtSearchFilename.Name = "txtTxtSearchFilename";
            this.txtTxtSearchFilename.Size = new System.Drawing.Size(85, 20);
            this.txtTxtSearchFilename.TabIndex = 4;
            this.txtTxtSearchFilename.Text = "docnotes";
            this.txtTxtSearchFilename.TextChanged += new System.EventHandler(this.TxtTxtSearchFilename_TextChanged);
            // 
            // lblChoixTypeFilename
            // 
            this.lblChoixTypeFilename.AutoSize = true;
            this.lblChoixTypeFilename.Location = new System.Drawing.Point(534, 51);
            this.lblChoixTypeFilename.Name = "lblChoixTypeFilename";
            this.lblChoixTypeFilename.Size = new System.Drawing.Size(96, 13);
            this.lblChoixTypeFilename.TabIndex = 36;
            this.lblChoixTypeFilename.Text = "de type (extension)";
            // 
            // cboChoixTypeFilename
            // 
            this.cboChoixTypeFilename.FormattingEnabled = true;
            this.cboChoixTypeFilename.Items.AddRange(new object[] {
            "Toutes",
            ".doc_",
            ".txt",
            ".odt_",
            ".pdf"});
            this.cboChoixTypeFilename.Location = new System.Drawing.Point(636, 47);
            this.cboChoixTypeFilename.Name = "cboChoixTypeFilename";
            this.cboChoixTypeFilename.Size = new System.Drawing.Size(90, 21);
            this.cboChoixTypeFilename.TabIndex = 5;
            this.cboChoixTypeFilename.SelectedIndexChanged += new System.EventHandler(this.CboChoixTypeFilename_SelectedIndexChanged);
            // 
            // chkInclureNomCours
            // 
            this.chkInclureNomCours.AutoSize = true;
            this.chkInclureNomCours.Checked = true;
            this.chkInclureNomCours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInclureNomCours.Location = new System.Drawing.Point(487, 102);
            this.chkInclureNomCours.Name = "chkInclureNomCours";
            this.chkInclureNomCours.Size = new System.Drawing.Size(125, 17);
            this.chkInclureNomCours.TabIndex = 13;
            this.chkInclureNomCours.Text = "Inclure nom du cours";
            this.chkInclureNomCours.UseVisualStyleBackColor = true;
            this.chkInclureNomCours.CheckedChanged += new System.EventHandler(this.chkInclureNomCours_CheckedChanged);
            // 
            // cboSeparateur2
            // 
            this.cboSeparateur2.FormattingEnabled = true;
            this.cboSeparateur2.Items.AddRange(new object[] {
            "aucun",
            "- tiret",
            "_ tiret bas",
            ". point",
            " espace"});
            this.cboSeparateur2.Location = new System.Drawing.Point(425, 100);
            this.cboSeparateur2.Name = "cboSeparateur2";
            this.cboSeparateur2.Size = new System.Drawing.Size(57, 21);
            this.cboSeparateur2.TabIndex = 12;
            this.cboSeparateur2.Text = "Séparateur";
            this.cboSeparateur2.SelectedIndexChanged += new System.EventHandler(this.cboSeparateur2_SelectedIndexChanged);
            // 
            // cboSeparateur3
            // 
            this.cboSeparateur3.FormattingEnabled = true;
            this.cboSeparateur3.Items.AddRange(new object[] {
            "aucun",
            "- tiret",
            "_ tiret bas",
            ". point",
            " espace"});
            this.cboSeparateur3.Location = new System.Drawing.Point(618, 100);
            this.cboSeparateur3.Name = "cboSeparateur3";
            this.cboSeparateur3.Size = new System.Drawing.Size(57, 21);
            this.cboSeparateur3.TabIndex = 14;
            this.cboSeparateur3.Text = "Séparateur";
            this.cboSeparateur3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboIntroSemaine
            // 
            this.cboIntroSemaine.FormattingEnabled = true;
            this.cboIntroSemaine.Items.AddRange(new object[] {
            "Aucun",
            "S",
            "Sem",
            "Semaine",
            "W",
            "Week",
            "N",
            "Numéro",
            "Numero",
            "Num"});
            this.cboIntroSemaine.Location = new System.Drawing.Point(713, 101);
            this.cboIntroSemaine.Name = "cboIntroSemaine";
            this.cboIntroSemaine.Size = new System.Drawing.Size(87, 21);
            this.cboIntroSemaine.TabIndex = 15;
            this.cboIntroSemaine.Text = "Intro";
            this.cboIntroSemaine.SelectedIndexChanged += new System.EventHandler(this.cboIntroSemaine_SelectedIndexChanged);
            // 
            // cboChoixNumeroFin
            // 
            this.cboChoixNumeroFin.FormattingEnabled = true;
            this.cboChoixNumeroFin.Items.AddRange(new object[] {
            "Numéro de semaine auto",
            "Numéro avant extension"});
            this.cboChoixNumeroFin.Location = new System.Drawing.Point(806, 101);
            this.cboChoixNumeroFin.Name = "cboChoixNumeroFin";
            this.cboChoixNumeroFin.Size = new System.Drawing.Size(179, 21);
            this.cboChoixNumeroFin.TabIndex = 16;
            this.cboChoixNumeroFin.Text = "A choisir";
            this.cboChoixNumeroFin.SelectedIndexChanged += new System.EventHandler(this.CboChoixNumeroFin_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Différents cours trouvés: ";
            // 
            // btnValidationCours
            // 
            this.btnValidationCours.Location = new System.Drawing.Point(617, 203);
            this.btnValidationCours.Name = "btnValidationCours";
            this.btnValidationCours.Size = new System.Drawing.Size(171, 23);
            this.btnValidationCours.TabIndex = 17;
            this.btnValidationCours.Text = "Valider et lancer le processus";
            this.btnValidationCours.UseVisualStyleBackColor = true;
            // 
            // cmdClearLogs
            // 
            this.cmdClearLogs.Location = new System.Drawing.Point(617, 458);
            this.cmdClearLogs.Name = "cmdClearLogs";
            this.cmdClearLogs.Size = new System.Drawing.Size(171, 23);
            this.cmdClearLogs.TabIndex = 45;
            this.cmdClearLogs.Text = "Clear logs";
            this.cmdClearLogs.UseVisualStyleBackColor = true;
            this.cmdClearLogs.Click += new System.EventHandler(this.CmdClearLogs_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(526, 459);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(85, 23);
            this.cmdCancel.TabIndex = 46;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(795, 171);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 350);
            this.label1.TabIndex = 47;
            // 
            // frmFileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 734);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdClearLogs);
            this.Controls.Add(this.btnValidationCours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboChoixNumeroFin);
            this.Controls.Add(this.cboIntroSemaine);
            this.Controls.Add(this.cboSeparateur3);
            this.Controls.Add(this.cboSeparateur2);
            this.Controls.Add(this.chkInclureNomCours);
            this.Controls.Add(this.cboChoixTypeFilename);
            this.Controls.Add(this.lblChoixTypeFilename);
            this.Controls.Add(this.txtTxtSearchFilename);
            this.Controls.Add(this.cboPositionTxtSearchFilename);
            this.Controls.Add(this.lblTxtSearchFilename);
            this.Controls.Add(this.lblGestionErreursInfo);
            this.Controls.Add(this.lblDepartInfo);
            this.Controls.Add(this.cboSeparateur1);
            this.Controls.Add(this.lblResultStructure);
            this.Controls.Add(this.lblResultStructureInfo);
            this.Controls.Add(this.chkAcronyme);
            this.Controls.Add(this.chkIntro);
            this.Controls.Add(this.lblHistorique);
            this.Controls.Add(this.lstHistorique);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAppliquerttserros);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdEcraser);
            this.Controls.Add(this.cmdNotTraiter);
            this.Controls.Add(this.cmdUseUniqueNames);
            this.Controls.Add(this.lstErrors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAcronyme);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.lblCheckRepertoire);
            this.Controls.Add(this.cmdParcourir);
            this.Controls.Add(this.txtChoixRepertoire);
            this.Controls.Add(this.lblChoixRepertoire);
            this.Controls.Add(this.cmdLancer);
            this.Name = "frmFileRenamer";
            this.Text = "File Renamer - renommer des fichiers avec une structure particulière";
            this.Load += new System.EventHandler(this.FrmFileRenamer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdLancer;
        private System.Windows.Forms.Label lblChoixRepertoire;
        private System.Windows.Forms.TextBox txtChoixRepertoire;
        private System.Windows.Forms.Button cmdParcourir;
        private System.Windows.Forms.FolderBrowserDialog fbdChoixRepertoire;
        private System.Windows.Forms.Label lblCheckRepertoire;
        private System.Windows.Forms.TextBox txtIntro;
        private System.Windows.Forms.TextBox txtAcronyme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstErrors;
        private System.Windows.Forms.Button cmdUseUniqueNames;
        private System.Windows.Forms.Button cmdNotTraiter;
        private System.Windows.Forms.Button cmdEcraser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.CheckBox chkAppliquerttserros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstHistorique;
        private System.Windows.Forms.Label lblHistorique;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.CheckBox chkAcronyme;
        private System.Windows.Forms.Label lblResultStructureInfo;
        private System.Windows.Forms.Label lblResultStructure;
        private System.Windows.Forms.ComboBox cboSeparateur1;
        private System.Windows.Forms.Label lblDepartInfo;
        private System.Windows.Forms.Label lblGestionErreursInfo;
        private System.Windows.Forms.Label lblTxtSearchFilename;
        private System.Windows.Forms.ComboBox cboPositionTxtSearchFilename;
        private System.Windows.Forms.TextBox txtTxtSearchFilename;
        private System.Windows.Forms.Label lblChoixTypeFilename;
        private System.Windows.Forms.ComboBox cboChoixTypeFilename;
        private System.Windows.Forms.CheckBox chkInclureNomCours;
        private System.Windows.Forms.ComboBox cboSeparateur2;
        private System.Windows.Forms.ComboBox cboSeparateur3;
        private System.Windows.Forms.ComboBox cboIntroSemaine;
        private System.Windows.Forms.ComboBox cboChoixNumeroFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValidationCours;
        private System.Windows.Forms.Button cmdClearLogs;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox label1;
    }
}

