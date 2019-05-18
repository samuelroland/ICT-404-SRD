namespace _04_FenetreBleuRouge
{
    partial class frmFenetreBleuRouge
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
            this.cmdHautGauche = new System.Windows.Forms.Button();
            this.cmdHautDroite = new System.Windows.Forms.Button();
            this.cmdBasGauche = new System.Windows.Forms.Button();
            this.cmdBasDroite = new System.Windows.Forms.Button();
            this.cmdBleu = new System.Windows.Forms.Button();
            this.cmdRouge = new System.Windows.Forms.Button();
            this.cmdStats = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdAller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHautGauche
            // 
            this.cmdHautGauche.Location = new System.Drawing.Point(0, 0);
            this.cmdHautGauche.Name = "cmdHautGauche";
            this.cmdHautGauche.Size = new System.Drawing.Size(83, 23);
            this.cmdHautGauche.TabIndex = 0;
            this.cmdHautGauche.Text = "Haut/Gauche";
            this.cmdHautGauche.UseVisualStyleBackColor = true;
            this.cmdHautGauche.Click += new System.EventHandler(this.cmdHautGauche_Click);
            // 
            // cmdHautDroite
            // 
            this.cmdHautDroite.Location = new System.Drawing.Point(390, 0);
            this.cmdHautDroite.Name = "cmdHautDroite";
            this.cmdHautDroite.Size = new System.Drawing.Size(75, 23);
            this.cmdHautDroite.TabIndex = 1;
            this.cmdHautDroite.Text = "Haut/Droite";
            this.cmdHautDroite.UseVisualStyleBackColor = true;
            this.cmdHautDroite.Click += new System.EventHandler(this.cmdHautDroite_Click);
            // 
            // cmdBasGauche
            // 
            this.cmdBasGauche.Location = new System.Drawing.Point(0, 427);
            this.cmdBasGauche.Name = "cmdBasGauche";
            this.cmdBasGauche.Size = new System.Drawing.Size(83, 23);
            this.cmdBasGauche.TabIndex = 2;
            this.cmdBasGauche.Text = "Bas/Gauche";
            this.cmdBasGauche.UseVisualStyleBackColor = true;
            this.cmdBasGauche.Click += new System.EventHandler(this.cmdBasGauche_Click);
            // 
            // cmdBasDroite
            // 
            this.cmdBasDroite.Location = new System.Drawing.Point(390, 427);
            this.cmdBasDroite.Name = "cmdBasDroite";
            this.cmdBasDroite.Size = new System.Drawing.Size(75, 23);
            this.cmdBasDroite.TabIndex = 3;
            this.cmdBasDroite.Text = "Bas/Droite";
            this.cmdBasDroite.UseVisualStyleBackColor = true;
            this.cmdBasDroite.Click += new System.EventHandler(this.cmdBasDroite_Click);
            // 
            // cmdBleu
            // 
            this.cmdBleu.Location = new System.Drawing.Point(196, 119);
            this.cmdBleu.Name = "cmdBleu";
            this.cmdBleu.Size = new System.Drawing.Size(75, 23);
            this.cmdBleu.TabIndex = 4;
            this.cmdBleu.Text = "Bleu";
            this.cmdBleu.UseVisualStyleBackColor = true;
            this.cmdBleu.Click += new System.EventHandler(this.cmdBleu_Click);
            // 
            // cmdRouge
            // 
            this.cmdRouge.Location = new System.Drawing.Point(196, 186);
            this.cmdRouge.Name = "cmdRouge";
            this.cmdRouge.Size = new System.Drawing.Size(75, 23);
            this.cmdRouge.TabIndex = 5;
            this.cmdRouge.Text = "Rouge";
            this.cmdRouge.UseVisualStyleBackColor = true;
            this.cmdRouge.Click += new System.EventHandler(this.cmdRouge_Click);
            // 
            // cmdStats
            // 
            this.cmdStats.Location = new System.Drawing.Point(196, 249);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(75, 23);
            this.cmdStats.TabIndex = 6;
            this.cmdStats.Text = "Stats";
            this.cmdStats.UseVisualStyleBackColor = true;
            this.cmdStats.Click += new System.EventHandler(this.cmdStats_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(196, 305);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 7;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 205);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 236);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(32, 202);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(27, 20);
            this.txtX.TabIndex = 10;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(32, 233);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(27, 20);
            this.txtY.TabIndex = 11;
            // 
            // cmdH
            // 
            this.cmdH.Location = new System.Drawing.Point(374, 185);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(27, 24);
            this.cmdH.TabIndex = 16;
            this.cmdH.Text = "H";
            this.cmdH.UseVisualStyleBackColor = true;
            this.cmdH.MouseHover += new System.EventHandler(this.cmdH_MouseHover);
            // 
            // cmdD
            // 
            this.cmdD.Location = new System.Drawing.Point(408, 215);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(27, 24);
            this.cmdD.TabIndex = 13;
            this.cmdD.Text = "D";
            this.cmdD.UseVisualStyleBackColor = true;
            this.cmdD.MouseHover += new System.EventHandler(this.cmdD_MouseHover);
            // 
            // cmdG
            // 
            this.cmdG.Location = new System.Drawing.Point(341, 215);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(27, 24);
            this.cmdG.TabIndex = 14;
            this.cmdG.Text = "G";
            this.cmdG.UseVisualStyleBackColor = true;
            this.cmdG.MouseHover += new System.EventHandler(this.cmdG_MouseHover);
            // 
            // cmdB
            // 
            this.cmdB.Location = new System.Drawing.Point(374, 249);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(27, 24);
            this.cmdB.TabIndex = 15;
            this.cmdB.Text = "B";
            this.cmdB.UseVisualStyleBackColor = true;
            this.cmdB.MouseHover += new System.EventHandler(this.cmdB_MouseHover);
            // 
            // cmdAller
            // 
            this.cmdAller.Location = new System.Drawing.Point(75, 215);
            this.cmdAller.Name = "cmdAller";
            this.cmdAller.Size = new System.Drawing.Size(50, 24);
            this.cmdAller.TabIndex = 12;
            this.cmdAller.Text = "Aller";
            this.cmdAller.UseVisualStyleBackColor = true;
            this.cmdAller.Click += new System.EventHandler(this.cmdAller_Click);
            // 
            // frmFenetreBleuRouge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.cmdAller);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdStats);
            this.Controls.Add(this.cmdRouge);
            this.Controls.Add(this.cmdBleu);
            this.Controls.Add(this.cmdBasDroite);
            this.Controls.Add(this.cmdBasGauche);
            this.Controls.Add(this.cmdHautDroite);
            this.Controls.Add(this.cmdHautGauche);
            this.Name = "frmFenetreBleuRouge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenetre";
            this.Load += new System.EventHandler(this.frmFenetreBleuRouge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHautGauche;
        private System.Windows.Forms.Button cmdHautDroite;
        private System.Windows.Forms.Button cmdBasGauche;
        private System.Windows.Forms.Button cmdBasDroite;
        private System.Windows.Forms.Button cmdBleu;
        private System.Windows.Forms.Button cmdRouge;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdAller;
    }
}

