﻿namespace _09_Combobox
{
    partial class frmListComboBox
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
            this.cboOperateurs = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lstEcoles = new System.Windows.Forms.ListBox();
            this.lblEcolesselected = new System.Windows.Forms.Label();
            this.lstFinale = new System.Windows.Forms.ListBox();
            this.lblNbEcolesSelected = new System.Windows.Forms.Label();
            this.cboGymnase = new System.Windows.Forms.ComboBox();
            this.grpNbEcolesSelected = new System.Windows.Forms.GroupBox();
            this.grpNbEcolesSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboOperateurs
            // 
            this.cboOperateurs.ForeColor = System.Drawing.Color.DarkRed;
            this.cboOperateurs.FormattingEnabled = true;
            this.cboOperateurs.Items.AddRange(new object[] {
            "Orange",
            "Salt",
            "Sunrise",
            "Swisscom"});
            this.cboOperateurs.Location = new System.Drawing.Point(39, 36);
            this.cboOperateurs.Name = "cboOperateurs";
            this.cboOperateurs.Size = new System.Drawing.Size(121, 21);
            this.cboOperateurs.Sorted = true;
            this.cboOperateurs.TabIndex = 0;
            this.cboOperateurs.Enter += new System.EventHandler(this.CboOperateurs_Enter);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(212, 34);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAjouter.TabIndex = 1;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(212, 116);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(75, 23);
            this.cmdEffacer.TabIndex = 2;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            this.cmdEffacer.Click += new System.EventHandler(this.CmdEffacer_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(212, 208);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 3;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdSupprimer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(212, 325);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lstEcoles
            // 
            this.lstEcoles.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstEcoles.FormattingEnabled = true;
            this.lstEcoles.Items.AddRange(new object[] {
            "CEPM",
            "CPNV",
            "ECL",
            "EPCL",
            "EPSIC",
            "ETML"});
            this.lstEcoles.Location = new System.Drawing.Point(39, 85);
            this.lstEcoles.Name = "lstEcoles";
            this.lstEcoles.Size = new System.Drawing.Size(120, 212);
            this.lstEcoles.Sorted = true;
            this.lstEcoles.TabIndex = 5;
            this.lstEcoles.Enter += new System.EventHandler(this.LstEcoles_Enter);
            // 
            // lblEcolesselected
            // 
            this.lblEcolesselected.Location = new System.Drawing.Point(362, 305);
            this.lblEcolesselected.Name = "lblEcolesselected";
            this.lblEcolesselected.Size = new System.Drawing.Size(123, 17);
            this.lblEcolesselected.TabIndex = 6;
            this.lblEcolesselected.Text = "écoles sélectionnées";
            // 
            // lstFinale
            // 
            this.lstFinale.FormattingEnabled = true;
            this.lstFinale.Location = new System.Drawing.Point(365, 36);
            this.lstFinale.Name = "lstFinale";
            this.lstFinale.Size = new System.Drawing.Size(120, 264);
            this.lstFinale.TabIndex = 7;
            // 
            // lblNbEcolesSelected
            // 
            this.lblNbEcolesSelected.AutoSize = true;
            this.lblNbEcolesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbEcolesSelected.Location = new System.Drawing.Point(51, 8);
            this.lblNbEcolesSelected.Name = "lblNbEcolesSelected";
            this.lblNbEcolesSelected.Size = new System.Drawing.Size(18, 20);
            this.lblNbEcolesSelected.TabIndex = 8;
            this.lblNbEcolesSelected.Text = "0";
            // 
            // cboGymnase
            // 
            this.cboGymnase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGymnase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGymnase.ForeColor = System.Drawing.Color.Violet;
            this.cboGymnase.FormattingEnabled = true;
            this.cboGymnase.Items.AddRange(new object[] {
            "Gymnasse de Bugon",
            "Gymnase de Beaulieu",
            "Gymnase d\'Yverdon"});
            this.cboGymnase.Location = new System.Drawing.Point(39, 327);
            this.cboGymnase.Name = "cboGymnase";
            this.cboGymnase.Size = new System.Drawing.Size(121, 21);
            this.cboGymnase.TabIndex = 9;
            this.cboGymnase.Enter += new System.EventHandler(this.CboGymnase_Enter);
            // 
            // grpNbEcolesSelected
            // 
            this.grpNbEcolesSelected.Controls.Add(this.lblNbEcolesSelected);
            this.grpNbEcolesSelected.Location = new System.Drawing.Point(365, 325);
            this.grpNbEcolesSelected.Name = "grpNbEcolesSelected";
            this.grpNbEcolesSelected.Size = new System.Drawing.Size(120, 30);
            this.grpNbEcolesSelected.TabIndex = 10;
            this.grpNbEcolesSelected.TabStop = false;
            // 
            // frmListComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.cboGymnase);
            this.Controls.Add(this.lstFinale);
            this.Controls.Add(this.lblEcolesselected);
            this.Controls.Add(this.lstEcoles);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cboOperateurs);
            this.Controls.Add(this.grpNbEcolesSelected);
            this.Name = "frmListComboBox";
            this.Text = "ListBox et ComboBox avec des styles différents";
            this.Load += new System.EventHandler(this.FrmListComboBox_Load);
            this.grpNbEcolesSelected.ResumeLayout(false);
            this.grpNbEcolesSelected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOperateurs;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ListBox lstEcoles;
        private System.Windows.Forms.Label lblEcolesselected;
        private System.Windows.Forms.ListBox lstFinale;
        private System.Windows.Forms.Label lblNbEcolesSelected;
        private System.Windows.Forms.ComboBox cboGymnase;
        private System.Windows.Forms.GroupBox grpNbEcolesSelected;
    }
}

