namespace Premierprojet
{
    partial class frmBienvenue
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.lblBienvenueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(36, 23);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(260, 25);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bonjour, nous sommes le ";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBienvenue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBienvenueDate
            // 
            this.lblBienvenueDate.AutoSize = true;
            this.lblBienvenueDate.Location = new System.Drawing.Point(38, 67);
            this.lblBienvenueDate.Name = "lblBienvenueDate";
            this.lblBienvenueDate.Size = new System.Drawing.Size(35, 13);
            this.lblBienvenueDate.TabIndex = 1;
            this.lblBienvenueDate.Text = "label1";
            this.lblBienvenueDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(333, 270);
            this.Controls.Add(this.lblBienvenueDate);
            this.Controls.Add(this.lblBienvenue);
            this.Name = "frmBienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cours C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblBienvenueDate;
    }
}

