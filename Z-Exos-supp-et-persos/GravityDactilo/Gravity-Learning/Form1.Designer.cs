namespace Gravity_Learning
{
    partial class frmGravityDactylo
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
            this.components = new System.ComponentModel.Container();
            this.cmdReDemarrer = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.lblTapezInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prgProgressionJeu = new System.Windows.Forms.ProgressBar();
            this.lblPointsInfo = new System.Windows.Forms.Label();
            this.lblProgression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrVitesse = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEspace = new System.Windows.Forms.GroupBox();
            this.lblNomEspace = new System.Windows.Forms.Label();
            this.lblAsteroide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReDemarrer
            // 
            this.cmdReDemarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReDemarrer.Location = new System.Drawing.Point(12, 399);
            this.cmdReDemarrer.Name = "cmdReDemarrer";
            this.cmdReDemarrer.Size = new System.Drawing.Size(87, 28);
            this.cmdReDemarrer.TabIndex = 0;
            this.cmdReDemarrer.Text = "Démarrer";
            this.cmdReDemarrer.UseVisualStyleBackColor = true;
            this.cmdReDemarrer.Click += new System.EventHandler(this.CmdReDemarrer_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPause.Location = new System.Drawing.Point(12, 318);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(65, 28);
            this.cmdPause.TabIndex = 1;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            // 
            // lblTapezInfo
            // 
            this.lblTapezInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTapezInfo.Location = new System.Drawing.Point(105, 388);
            this.lblTapezInfo.Name = "lblTapezInfo";
            this.lblTapezInfo.Size = new System.Drawing.Size(110, 39);
            this.lblTapezInfo.TabIndex = 3;
            this.lblTapezInfo.Text = "Tapez les mots qui descendent";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 31);
            this.textBox1.TabIndex = 4;
            // 
            // prgProgressionJeu
            // 
            this.prgProgressionJeu.BackColor = System.Drawing.Color.Snow;
            this.prgProgressionJeu.Location = new System.Drawing.Point(109, 1);
            this.prgProgressionJeu.Name = "prgProgressionJeu";
            this.prgProgressionJeu.Size = new System.Drawing.Size(572, 35);
            this.prgProgressionJeu.TabIndex = 5;
            // 
            // lblPointsInfo
            // 
            this.lblPointsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsInfo.Location = new System.Drawing.Point(8, 170);
            this.lblPointsInfo.Name = "lblPointsInfo";
            this.lblPointsInfo.Size = new System.Drawing.Size(79, 42);
            this.lblPointsInfo.TabIndex = 6;
            this.lblPointsInfo.Text = "Points marqués:";
            // 
            // lblProgression
            // 
            this.lblProgression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgression.Location = new System.Drawing.Point(309, 9);
            this.lblProgression.Name = "lblProgression";
            this.lblProgression.Size = new System.Drawing.Size(152, 23);
            this.lblProgression.TabIndex = 7;
            this.lblProgression.Text = "Progression du jeu";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrVitesse
            // 
            this.tmrVitesse.Enabled = true;
            this.tmrVitesse.Interval = 25;
            this.tmrVitesse.Tick += new System.EventHandler(this.TmrVitesse_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gravity_Learning.Properties.Resources.logogalaxie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::Gravity_Learning.Properties.Resources.logogalaxie;
            this.pictureBox1.Location = new System.Drawing.Point(2, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // grpEspace
            // 
            this.grpEspace.BackColor = System.Drawing.Color.White;
            this.grpEspace.BackgroundImage = global::Gravity_Learning.Properties.Resources.espace1;
            this.grpEspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpEspace.Controls.Add(this.lblNomEspace);
            this.grpEspace.Controls.Add(this.lblAsteroide);
            this.grpEspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpEspace.Location = new System.Drawing.Point(108, 38);
            this.grpEspace.Name = "grpEspace";
            this.grpEspace.Size = new System.Drawing.Size(572, 338);
            this.grpEspace.TabIndex = 2;
            this.grpEspace.TabStop = false;
            // 
            // lblNomEspace
            // 
            this.lblNomEspace.BackColor = System.Drawing.Color.Transparent;
            this.lblNomEspace.Location = new System.Drawing.Point(116, 12);
            this.lblNomEspace.Name = "lblNomEspace";
            this.lblNomEspace.Size = new System.Drawing.Size(352, 29);
            this.lblNomEspace.TabIndex = 10;
            this.lblNomEspace.Text = "Espace Interstellaire - Bras d\'Orion";
            // 
            
            // 
            // frmGravityDactylo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProgression);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgProgressionJeu);
            this.Controls.Add(this.lblPointsInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTapezInfo);
            this.Controls.Add(this.grpEspace);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdReDemarrer);
            this.Name = "frmGravityDactylo";
            this.Text = "Gravity Dactylo";
            this.Load += new System.EventHandler(this.FrmGravityDactylo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEspace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReDemarrer;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.GroupBox grpEspace;
        private System.Windows.Forms.Label lblTapezInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar prgProgressionJeu;
        private System.Windows.Forms.Label lblPointsInfo;
        private System.Windows.Forms.Label lblProgression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrVitesse;
        private System.Windows.Forms.Label lblNomEspace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAsteroide;
    }
}

