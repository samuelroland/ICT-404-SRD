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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLancer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cmdLancer
            // 
            this.cmdLancer.Location = new System.Drawing.Point(424, 86);
            this.cmdLancer.Name = "cmdLancer";
            this.cmdLancer.Size = new System.Drawing.Size(75, 23);
            this.cmdLancer.TabIndex = 1;
            this.cmdLancer.Text = "Lancer !";
            this.cmdLancer.UseVisualStyleBackColor = true;
            this.cmdLancer.Click += new System.EventHandler(this.CmdLancer_Click);
            // 
            // frmFileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLancer);
            this.Controls.Add(this.label1);
            this.Name = "frmFileRenamer";
            this.Text = "File Renamer - renommer selon une structure des fichiers de notes nommés par défa" +
    "ut";
            this.Load += new System.EventHandler(this.FrmFileRenamer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLancer;
    }
}

