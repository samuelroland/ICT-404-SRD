namespace Youtube_Enabler
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDesactiver = new System.Windows.Forms.Button();
            this.cmdActiver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu passes trop de temps sur youtube ?\r\nLaisse toi 30 minutes sans Youtube pour av" +
    "ancer dans un projet qui te tient à coeur...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // cmdDesactiver
            // 
            this.cmdDesactiver.Location = new System.Drawing.Point(281, 95);
            this.cmdDesactiver.Name = "cmdDesactiver";
            this.cmdDesactiver.Size = new System.Drawing.Size(75, 23);
            this.cmdDesactiver.TabIndex = 3;
            this.cmdDesactiver.Text = "Désactiver";
            this.cmdDesactiver.UseVisualStyleBackColor = true;
            this.cmdDesactiver.Click += new System.EventHandler(this.CmdDesactiver_Click);
            // 
            // cmdActiver
            // 
            this.cmdActiver.Location = new System.Drawing.Point(362, 95);
            this.cmdActiver.Name = "cmdActiver";
            this.cmdActiver.Size = new System.Drawing.Size(75, 23);
            this.cmdActiver.TabIndex = 4;
            this.cmdActiver.Text = "Activer";
            this.cmdActiver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 158);
            this.Controls.Add(this.cmdActiver);
            this.Controls.Add(this.cmdDesactiver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDesactiver;
        private System.Windows.Forms.Button cmdActiver;
    }
}

