namespace _07_ArcheDeNoe
{
    partial class frmArcheDeNoe
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
            this.lstATerre = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstABord = new System.Windows.Forms.ListBox();
            this.cmdMettreABord = new System.Windows.Forms.Button();
            this.cmdMettreATerre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstATerre
            // 
            this.lstATerre.FormattingEnabled = true;
            this.lstATerre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinnelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.lstATerre.Location = new System.Drawing.Point(33, 48);
            this.lstATerre.MultiColumn = true;
            this.lstATerre.Name = "lstATerre";
            this.lstATerre.Size = new System.Drawing.Size(183, 316);
            this.lstATerre.TabIndex = 0;
            this.lstATerre.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encore à terre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "A bord";
            // 
            // lstABord
            // 
            this.lstABord.FormattingEnabled = true;
            this.lstABord.Location = new System.Drawing.Point(315, 48);
            this.lstABord.Name = "lstABord";
            this.lstABord.Size = new System.Drawing.Size(183, 316);
            this.lstABord.TabIndex = 4;
            // 
            // cmdMettreABord
            // 
            this.cmdMettreABord.Location = new System.Drawing.Point(229, 131);
            this.cmdMettreABord.Name = "cmdMettreABord";
            this.cmdMettreABord.Size = new System.Drawing.Size(75, 23);
            this.cmdMettreABord.TabIndex = 5;
            this.cmdMettreABord.Text = "=======>";
            this.cmdMettreABord.UseVisualStyleBackColor = true;
            this.cmdMettreABord.Click += new System.EventHandler(this.cmdMettreABord_Click);
            // 
            // cmdMettreATerre
            // 
            this.cmdMettreATerre.Location = new System.Drawing.Point(229, 201);
            this.cmdMettreATerre.Name = "cmdMettreATerre";
            this.cmdMettreATerre.Size = new System.Drawing.Size(75, 23);
            this.cmdMettreATerre.TabIndex = 6;
            this.cmdMettreATerre.Text = "<=======";
            this.cmdMettreATerre.UseVisualStyleBackColor = true;
            // 
            // frmArcheDeNoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 424);
            this.Controls.Add(this.cmdMettreATerre);
            this.Controls.Add(this.cmdMettreABord);
            this.Controls.Add(this.lstABord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstATerre);
            this.Name = "frmArcheDeNoe";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Arche de Noé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstATerre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstABord;
        private System.Windows.Forms.Button cmdMettreABord;
        private System.Windows.Forms.Button cmdMettreATerre;
    }
}

