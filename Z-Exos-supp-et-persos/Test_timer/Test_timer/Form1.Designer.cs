namespace Test_timer
{
    partial class frmTimers
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
            this.tmrSecondes = new System.Windows.Forms.Timer(this.components);
            this.tmrCursor = new System.Windows.Forms.Timer(this.components);
            this.sldVitesseTimerCursor = new System.Windows.Forms.TrackBar();
            this.lblSecondes = new System.Windows.Forms.Label();
            this.lblSecondesCounter = new System.Windows.Forms.Label();
            this.cmdSecondes = new System.Windows.Forms.Button();
            this.lblCursorInfo = new System.Windows.Forms.Label();
            this.lblCursor = new System.Windows.Forms.Label();
            this.lblLent = new System.Windows.Forms.Label();
            this.lblRapide = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sldVitesseTimerCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSecondes
            // 
            this.tmrSecondes.Interval = 2000;
            this.tmrSecondes.Tick += new System.EventHandler(this.TmrSecondes_Tick);
            // 
            // tmrCursor
            // 
            this.tmrCursor.Tick += new System.EventHandler(this.TmrCursor_Tick);
            // 
            // sldVitesseTimerCursor
            // 
            this.sldVitesseTimerCursor.Location = new System.Drawing.Point(12, 115);
            this.sldVitesseTimerCursor.Maximum = 100;
            this.sldVitesseTimerCursor.Name = "sldVitesseTimerCursor";
            this.sldVitesseTimerCursor.Size = new System.Drawing.Size(384, 45);
            this.sldVitesseTimerCursor.TabIndex = 0;
            this.sldVitesseTimerCursor.Value = 50;
            this.sldVitesseTimerCursor.Scroll += new System.EventHandler(this.SldVitesseTimerCursor_Scroll);
            // 
            // lblSecondes
            // 
            this.lblSecondes.AutoSize = true;
            this.lblSecondes.Location = new System.Drawing.Point(12, 21);
            this.lblSecondes.Name = "lblSecondes";
            this.lblSecondes.Size = new System.Drawing.Size(156, 13);
            this.lblSecondes.TabIndex = 1;
            this.lblSecondes.Text = "Timer et tick chaque secondes:";
            // 
            // lblSecondesCounter
            // 
            this.lblSecondesCounter.AutoSize = true;
            this.lblSecondesCounter.Location = new System.Drawing.Point(383, 26);
            this.lblSecondesCounter.Name = "lblSecondesCounter";
            this.lblSecondesCounter.Size = new System.Drawing.Size(13, 13);
            this.lblSecondesCounter.TabIndex = 2;
            this.lblSecondesCounter.Text = "?";
            // 
            // cmdSecondes
            // 
            this.cmdSecondes.Location = new System.Drawing.Point(255, 21);
            this.cmdSecondes.Name = "cmdSecondes";
            this.cmdSecondes.Size = new System.Drawing.Size(75, 23);
            this.cmdSecondes.TabIndex = 3;
            this.cmdSecondes.Text = "Start";
            this.cmdSecondes.UseVisualStyleBackColor = true;
            this.cmdSecondes.Click += new System.EventHandler(this.CmdSecondes_Click);
            // 
            // lblCursorInfo
            // 
            this.lblCursorInfo.AutoSize = true;
            this.lblCursorInfo.Location = new System.Drawing.Point(12, 82);
            this.lblCursorInfo.Name = "lblCursorInfo";
            this.lblCursorInfo.Size = new System.Drawing.Size(262, 13);
            this.lblCursorInfo.TabIndex = 4;
            this.lblCursorInfo.Text = "Timer selon la valeur du curseur (tourne constamment)";
            // 
            // lblCursor
            // 
            this.lblCursor.AutoSize = true;
            this.lblCursor.Location = new System.Drawing.Point(383, 99);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(13, 13);
            this.lblCursor.TabIndex = 5;
            this.lblCursor.Text = "?";
            // 
            // lblLent
            // 
            this.lblLent.AutoSize = true;
            this.lblLent.Location = new System.Drawing.Point(12, 147);
            this.lblLent.Name = "lblLent";
            this.lblLent.Size = new System.Drawing.Size(86, 13);
            this.lblLent.TabIndex = 6;
            this.lblLent.Text = "Lent, 1/seconde";
            // 
            // lblRapide
            // 
            this.lblRapide.AutoSize = true;
            this.lblRapide.Location = new System.Drawing.Point(284, 147);
            this.lblRapide.Name = "lblRapide";
            this.lblRapide.Size = new System.Drawing.Size(112, 13);
            this.lblRapide.TabIndex = 7;
            this.lblRapide.Text = "Rapide 1/milliseconde";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(199, 147);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(12, 13);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "x";
            // 
            // frmTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 207);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblRapide);
            this.Controls.Add(this.lblLent);
            this.Controls.Add(this.lblCursor);
            this.Controls.Add(this.lblCursorInfo);
            this.Controls.Add(this.cmdSecondes);
            this.Controls.Add(this.lblSecondesCounter);
            this.Controls.Add(this.lblSecondes);
            this.Controls.Add(this.sldVitesseTimerCursor);
            this.Name = "frmTimers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timers et compagnies";
            this.Load += new System.EventHandler(this.FrmTimers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sldVitesseTimerCursor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSecondes;
        private System.Windows.Forms.Timer tmrCursor;
        private System.Windows.Forms.TrackBar sldVitesseTimerCursor;
        private System.Windows.Forms.Label lblSecondes;
        private System.Windows.Forms.Label lblSecondesCounter;
        private System.Windows.Forms.Button cmdSecondes;
        private System.Windows.Forms.Label lblCursorInfo;
        private System.Windows.Forms.Label lblCursor;
        private System.Windows.Forms.Label lblLent;
        private System.Windows.Forms.Label lblRapide;
        private System.Windows.Forms.Label lblInterval;
    }
}

