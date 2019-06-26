namespace Formative
{
    partial class frmCourses
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
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.cmdHaut = new System.Windows.Forms.Button();
            this.cmdBas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(25, 25);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(30, 20);
            this.txtQuantite.TabIndex = 0;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(25, 95);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(162, 199);
            this.lstCourses.TabIndex = 1;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(25, 51);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(162, 23);
            this.cmdAjouter.TabIndex = 2;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(25, 312);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(175, 23);
            this.cmdSupprimer.TabIndex = 3;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdSupprimer_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Location = new System.Drawing.Point(25, 341);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(175, 23);
            this.cmdImprimer.TabIndex = 4;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.CmdImprimer_Click);
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Location = new System.Drawing.Point(60, 24);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(127, 21);
            this.cboArticle.TabIndex = 5;
            // 
            // cmdHaut
            // 
            this.cmdHaut.Location = new System.Drawing.Point(25, 271);
            this.cmdHaut.Name = "cmdHaut";
            this.cmdHaut.Size = new System.Drawing.Size(50, 23);
            this.cmdHaut.TabIndex = 6;
            this.cmdHaut.Text = "Haut";
            this.cmdHaut.UseVisualStyleBackColor = true;
            this.cmdHaut.Click += new System.EventHandler(this.CmdHaut_Click);
            // 
            // cmdBas
            // 
            this.cmdBas.Location = new System.Drawing.Point(137, 271);
            this.cmdBas.Name = "cmdBas";
            this.cmdBas.Size = new System.Drawing.Size(50, 23);
            this.cmdBas.TabIndex = 7;
            this.cmdBas.Text = "Bas";
            this.cmdBas.UseVisualStyleBackColor = true;
            this.cmdBas.Click += new System.EventHandler(this.CmdBas_Click);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 376);
            this.Controls.Add(this.cmdBas);
            this.Controls.Add(this.cmdHaut);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.txtQuantite);
            this.Name = "frmCourses";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.FrmCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Button cmdHaut;
        private System.Windows.Forms.Button cmdBas;
    }
}

