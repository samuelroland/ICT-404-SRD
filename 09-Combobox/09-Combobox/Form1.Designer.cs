namespace _09_Combobox
{
    partial class frmComboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(212, 34);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAjouter.TabIndex = 1;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(212, 104);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(75, 23);
            this.cmdEffacer.TabIndex = 2;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(212, 170);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 3;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(212, 243);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 5;
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmComboBox";
            this.Text = "ListBox et ComboBox avec des styles différents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ListBox listBox1;
    }
}

