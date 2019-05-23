namespace Trombinoscope
{
    partial class frmTrombinoscope
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
            this.lblNomPersonne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonne1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomPersonne
            // 
            this.lblNomPersonne.BackColor = System.Drawing.Color.Green;
            this.lblNomPersonne.Location = new System.Drawing.Point(23, 117);
            this.lblNomPersonne.Name = "lblNomPersonne";
            this.lblNomPersonne.Size = new System.Drawing.Size(84, 13);
            this.lblNomPersonne.TabIndex = 0;
            this.lblNomPersonne.Text = "Prénom";
            this.lblNomPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 64);
            this.label2.TabIndex = 2;
            // 
            // lblPersonne1
            // 
            this.lblPersonne1.BackColor = System.Drawing.Color.Green;
            this.lblPersonne1.Image = global::Trombinoscope.Properties.Resources.content;
            this.lblPersonne1.Location = new System.Drawing.Point(20, 20);
            this.lblPersonne1.Name = "lblPersonne1";
            this.lblPersonne1.Size = new System.Drawing.Size(87, 110);
            this.lblPersonne1.TabIndex = 1;
            this.lblPersonne1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTrombinoscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomPersonne);
            this.Controls.Add(this.lblPersonne1);
            this.Name = "frmTrombinoscope";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Tous";
            this.Load += new System.EventHandler(this.frmTrombinoscope_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomPersonne;
        private System.Windows.Forms.Label lblPersonne1;
        private System.Windows.Forms.Label label2;
    }
}

