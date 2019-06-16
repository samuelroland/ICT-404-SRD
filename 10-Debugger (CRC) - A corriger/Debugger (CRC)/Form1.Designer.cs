namespace Debugger__CRC_
{
    partial class frmCRC
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
            this.lblSource = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cmdCheckCRC = new System.Windows.Forms.Button();
            this.rbtVerif = new System.Windows.Forms.RadioButton();
            this.rbtCalcul = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(147, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Numéro de carte:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(15, 35);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(281, 29);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "0000-0000-0000-0000-0000";
            // 
            // cmdCheckCRC
            // 
            this.cmdCheckCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheckCRC.Location = new System.Drawing.Point(135, 94);
            this.cmdCheckCRC.Name = "cmdCheckCRC";
            this.cmdCheckCRC.Size = new System.Drawing.Size(83, 23);
            this.cmdCheckCRC.TabIndex = 6;
            this.cmdCheckCRC.Text = "Effectuer";
            this.cmdCheckCRC.UseVisualStyleBackColor = true;
            this.cmdCheckCRC.Click += new System.EventHandler(this.cmdCheckCRC_Click);
            // 
            // rbtVerif
            // 
            this.rbtVerif.AutoSize = true;
            this.rbtVerif.Checked = true;
            this.rbtVerif.Location = new System.Drawing.Point(16, 87);
            this.rbtVerif.Name = "rbtVerif";
            this.rbtVerif.Size = new System.Drawing.Size(77, 17);
            this.rbtVerif.TabIndex = 7;
            this.rbtVerif.TabStop = true;
            this.rbtVerif.Text = "Vérification";
            this.rbtVerif.UseVisualStyleBackColor = true;
            // 
            // rbtCalcul
            // 
            this.rbtCalcul.AutoSize = true;
            this.rbtCalcul.Location = new System.Drawing.Point(16, 110);
            this.rbtCalcul.Name = "rbtCalcul";
            this.rbtCalcul.Size = new System.Drawing.Size(54, 17);
            this.rbtCalcul.TabIndex = 8;
            this.rbtCalcul.TabStop = true;
            this.rbtCalcul.Text = "Calcul";
            this.rbtCalcul.UseVisualStyleBackColor = true;
            // 
            // frmCRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 138);
            this.Controls.Add(this.rbtCalcul);
            this.Controls.Add(this.rbtVerif);
            this.Controls.Add(this.cmdCheckCRC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblSource);
            this.Name = "frmCRC";
            this.Text = "Vérificateur de Numéro de Carte de Crédit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button cmdCheckCRC;
        private System.Windows.Forms.RadioButton rbtVerif;
        private System.Windows.Forms.RadioButton rbtCalcul;
    }
}

