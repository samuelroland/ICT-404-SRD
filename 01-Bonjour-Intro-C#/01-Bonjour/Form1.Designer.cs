namespace _01_Bonjour
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
            this.lblBienvenueTexte = new System.Windows.Forms.Label();
            this.lblBienvenueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenueTexte
            // 
            this.lblBienvenueTexte.AutoSize = true;
            this.lblBienvenueTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueTexte.Location = new System.Drawing.Point(37, 35);
            this.lblBienvenueTexte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBienvenueTexte.Name = "lblBienvenueTexte";
            this.lblBienvenueTexte.Size = new System.Drawing.Size(255, 24);
            this.lblBienvenueTexte.TabIndex = 0;
            this.lblBienvenueTexte.Text = "Bienvenue, nous sommes le ";
            // 
            // lblBienvenueDate
            // 
            this.lblBienvenueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueDate.Location = new System.Drawing.Point(37, 112);
            this.lblBienvenueDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBienvenueDate.Name = "lblBienvenueDate";
            this.lblBienvenueDate.Size = new System.Drawing.Size(270, 24);
            this.lblBienvenueDate.TabIndex = 1;
            this.lblBienvenueDate.Text = "...";
            this.lblBienvenueDate.Click += new System.EventHandler(this.lblBienvenueDate_Click);
            // 
            // frmBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(365, 309);
            this.Controls.Add(this.lblBienvenueDate);
            this.Controls.Add(this.lblBienvenueTexte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBienvenue";
            this.Text = "Cours C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenueTexte;
        private System.Windows.Forms.Label lblBienvenueDate;
    }
}

