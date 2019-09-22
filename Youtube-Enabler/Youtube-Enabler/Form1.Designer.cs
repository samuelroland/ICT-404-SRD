namespace Youtube_Enabler
{
    partial class frmYoutubeEnabler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoutubeEnabler));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.cmdDesactiver = new System.Windows.Forms.Button();
            this.cmdActiver = new System.Windows.Forms.Button();
            this.rdbChoixManuel = new System.Windows.Forms.RadioButton();
            this.rdbChoixTemps = new System.Windows.Forms.RadioButton();
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
            this.cmdDesactiverTemps = new System.Windows.Forms.Button();
            this.lblChoixDuree = new System.Windows.Forms.Label();
            this.txtChoixDuree = new System.Windows.Forms.TextBox();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrTempsRestant = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grpConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(425, 112);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(12, 301);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(83, 17);
            this.lblEtat.TabIndex = 1;
            this.lblEtat.Text = "Etat actuel: ";
            // 
            // cmdDesactiver
            // 
            this.cmdDesactiver.Location = new System.Drawing.Point(6, 44);
            this.cmdDesactiver.Name = "cmdDesactiver";
            this.cmdDesactiver.Size = new System.Drawing.Size(75, 23);
            this.cmdDesactiver.TabIndex = 3;
            this.cmdDesactiver.Text = "Désactiver";
            this.cmdDesactiver.UseVisualStyleBackColor = true;
            this.cmdDesactiver.Click += new System.EventHandler(this.CmdDesactiver_Click);
            // 
            // cmdActiver
            // 
            this.cmdActiver.Location = new System.Drawing.Point(6, 73);
            this.cmdActiver.Name = "cmdActiver";
            this.cmdActiver.Size = new System.Drawing.Size(75, 23);
            this.cmdActiver.TabIndex = 4;
            this.cmdActiver.Text = "Activer";
            this.cmdActiver.UseVisualStyleBackColor = true;
            this.cmdActiver.Click += new System.EventHandler(this.CmdActiver_Click);
            // 
            // rdbChoixManuel
            // 
            this.rdbChoixManuel.AutoSize = true;
            this.rdbChoixManuel.Location = new System.Drawing.Point(3, 19);
            this.rdbChoixManuel.Name = "rdbChoixManuel";
            this.rdbChoixManuel.Size = new System.Drawing.Size(88, 17);
            this.rdbChoixManuel.TabIndex = 5;
            this.rdbChoixManuel.TabStop = true;
            this.rdbChoixManuel.Text = "Choix manuel";
            this.rdbChoixManuel.UseVisualStyleBackColor = true;
            this.rdbChoixManuel.CheckedChanged += new System.EventHandler(this.RdbChoixManuel_CheckedChanged);
            // 
            // rdbChoixTemps
            // 
            this.rdbChoixTemps.AutoSize = true;
            this.rdbChoixTemps.Location = new System.Drawing.Point(201, 19);
            this.rdbChoixTemps.Name = "rdbChoixTemps";
            this.rdbChoixTemps.Size = new System.Drawing.Size(146, 17);
            this.rdbChoixTemps.TabIndex = 6;
            this.rdbChoixTemps.TabStop = true;
            this.rdbChoixTemps.Text = "Choix limité avec le temps";
            this.rdbChoixTemps.UseVisualStyleBackColor = true;
            this.rdbChoixTemps.CheckedChanged += new System.EventHandler(this.RdbChoixTemps_CheckedChanged);
            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Controls.Add(this.cmdDesactiverTemps);
            this.grpConfiguration.Controls.Add(this.cmdActiver);
            this.grpConfiguration.Controls.Add(this.lblChoixDuree);
            this.grpConfiguration.Controls.Add(this.cmdDesactiver);
            this.grpConfiguration.Controls.Add(this.txtChoixDuree);
            this.grpConfiguration.Controls.Add(this.rdbChoixTemps);
            this.grpConfiguration.Controls.Add(this.rdbChoixManuel);
            this.grpConfiguration.Location = new System.Drawing.Point(12, 161);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Size = new System.Drawing.Size(425, 108);
            this.grpConfiguration.TabIndex = 7;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration:";
            // 
            // cmdDesactiverTemps
            // 
            this.cmdDesactiverTemps.Location = new System.Drawing.Point(321, 74);
            this.cmdDesactiverTemps.Name = "cmdDesactiverTemps";
            this.cmdDesactiverTemps.Size = new System.Drawing.Size(75, 23);
            this.cmdDesactiverTemps.TabIndex = 10;
            this.cmdDesactiverTemps.Text = "Désactiver";
            this.cmdDesactiverTemps.UseVisualStyleBackColor = true;
            this.cmdDesactiverTemps.Click += new System.EventHandler(this.CmdDesactiverTemps_Click);
            // 
            // lblChoixDuree
            // 
            this.lblChoixDuree.AutoSize = true;
            this.lblChoixDuree.Location = new System.Drawing.Point(198, 58);
            this.lblChoixDuree.Name = "lblChoixDuree";
            this.lblChoixDuree.Size = new System.Drawing.Size(101, 13);
            this.lblChoixDuree.TabIndex = 8;
            this.lblChoixDuree.Text = "Durée en h (ex: 1.5)";
            // 
            // txtChoixDuree
            // 
            this.txtChoixDuree.Location = new System.Drawing.Point(201, 74);
            this.txtChoixDuree.Name = "txtChoixDuree";
            this.txtChoixDuree.Size = new System.Drawing.Size(100, 20);
            this.txtChoixDuree.TabIndex = 7;
            this.txtChoixDuree.Text = "1.5";
            this.txtChoixDuree.TextChanged += new System.EventHandler(this.TxtChoixDuree_TextChanged);
            // 
            // lblTempsRestant
            // 
            this.lblTempsRestant.AutoSize = true;
            this.lblTempsRestant.Location = new System.Drawing.Point(210, 301);
            this.lblTempsRestant.Name = "lblTempsRestant";
            this.lblTempsRestant.Size = new System.Drawing.Size(80, 13);
            this.lblTempsRestant.TabIndex = 9;
            this.lblTempsRestant.Text = "Temps restant: ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(195, 272);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // tmrTempsRestant
            // 
            this.tmrTempsRestant.Interval = 2000;
            this.tmrTempsRestant.Tick += new System.EventHandler(this.TmrTempsRestant_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Encore bloqué pour un certain temps...";
            // 
            // frmYoutubeEnabler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.lblTempsRestant);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpConfiguration);
            this.Name = "frmYoutubeEnabler";
            this.Text = "YoutubeEnabler désactive l\'accès à youtube.";
            this.Load += new System.EventHandler(this.FrmYoutubeEnabler_Load);
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Button cmdDesactiver;
        private System.Windows.Forms.Button cmdActiver;
        private System.Windows.Forms.RadioButton rdbChoixManuel;
        private System.Windows.Forms.RadioButton rdbChoixTemps;
        private System.Windows.Forms.GroupBox grpConfiguration;
        private System.Windows.Forms.Label lblChoixDuree;
        private System.Windows.Forms.TextBox txtChoixDuree;
        private System.Windows.Forms.Button cmdDesactiverTemps;
        private System.Windows.Forms.Label lblTempsRestant;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrTempsRestant;
        private System.Windows.Forms.Label label1;
    }
}

