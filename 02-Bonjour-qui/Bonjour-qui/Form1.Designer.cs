﻿namespace Bonjour_qui
{
    partial class frmBonjourQui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonjourQui));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblBonjourNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.btBienvenue = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblNom.Location = new System.Drawing.Point(21, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(92, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Votre nom";
            // 
            // lblBonjourNom
            // 
            this.lblBonjourNom.AutoSize = true;
            this.lblBonjourNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBonjourNom.Location = new System.Drawing.Point(21, 91);
            this.lblBonjourNom.Name = "lblBonjourNom";
            this.lblBonjourNom.Size = new System.Drawing.Size(24, 20);
            this.lblBonjourNom.TabIndex = 1;
            this.lblBonjourNom.Text = "...";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(127, 22);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(237, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // btBienvenue
            // 
            this.btBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btBienvenue.Location = new System.Drawing.Point(127, 142);
            this.btBienvenue.Name = "btBienvenue";
            this.btBienvenue.Size = new System.Drawing.Size(150, 42);
            this.btBienvenue.TabIndex = 4;
            this.btBienvenue.Text = "Bienvenue";
            this.btBienvenue.UseVisualStyleBackColor = true;
            this.btBienvenue.Click += new System.EventHandler(this.btBienvenue_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btQuitter.BackgroundImage")));
            this.btQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuitter.Location = new System.Drawing.Point(318, 142);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(46, 46);
            this.btQuitter.TabIndex = 5;
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 212);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btBienvenue);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblBonjourNom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmBonjourQui";
            this.Text = "Bonjour Qui?";
            this.Load += new System.EventHandler(this.frmBonjourQui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBonjourNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button btBienvenue;
        private System.Windows.Forms.Button btQuitter;
    }
}

