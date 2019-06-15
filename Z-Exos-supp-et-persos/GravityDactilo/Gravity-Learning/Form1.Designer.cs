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
            this.txtZoneFrappe = new System.Windows.Forms.TextBox();
            this.prgProgressionJeu = new System.Windows.Forms.ProgressBar();
            this.lblPointsInfo = new System.Windows.Forms.Label();
            this.lblProgression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrVitesse = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEspace = new System.Windows.Forms.GroupBox();
            this.lblAst6 = new System.Windows.Forms.Label();
            this.pctAst6 = new System.Windows.Forms.PictureBox();
            this.lblAst2 = new System.Windows.Forms.Label();
            this.pctAst2 = new System.Windows.Forms.PictureBox();
            this.lblAst3 = new System.Windows.Forms.Label();
            this.pctAst3 = new System.Windows.Forms.PictureBox();
            this.lblAst5 = new System.Windows.Forms.Label();
            this.pctAst5 = new System.Windows.Forms.PictureBox();
            this.lblAst4 = new System.Windows.Forms.Label();
            this.pctAst4 = new System.Windows.Forms.PictureBox();
            this.lblAst1 = new System.Windows.Forms.Label();
            this.pctAst1 = new System.Windows.Forms.PictureBox();
            this.lblNomEspace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst1)).BeginInit();
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
            this.cmdPause.Location = new System.Drawing.Point(4, 318);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(98, 28);
            this.cmdPause.TabIndex = 1;
            this.cmdPause.Text = "Pause";
            this.cmdPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.CmdPause_Click);
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
            // txtZoneFrappe
            // 
            this.txtZoneFrappe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneFrappe.Location = new System.Drawing.Point(221, 395);
            this.txtZoneFrappe.Name = "txtZoneFrappe";
            this.txtZoneFrappe.Size = new System.Drawing.Size(459, 31);
            this.txtZoneFrappe.TabIndex = 4;
            // 
            // prgProgressionJeu
            // 
            this.prgProgressionJeu.BackColor = System.Drawing.Color.Snow;
            this.prgProgressionJeu.Location = new System.Drawing.Point(4, -3);
            this.prgProgressionJeu.Name = "prgProgressionJeu";
            this.prgProgressionJeu.Size = new System.Drawing.Size(125, 35);
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
            this.lblProgression.Location = new System.Drawing.Point(12, 9);
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
            this.label1.Size = new System.Drawing.Size(91, 32);
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
            this.grpEspace.Controls.Add(this.lblAst6);
            this.grpEspace.Controls.Add(this.pctAst6);
            this.grpEspace.Controls.Add(this.lblAst2);
            this.grpEspace.Controls.Add(this.pctAst2);
            this.grpEspace.Controls.Add(this.lblAst3);
            this.grpEspace.Controls.Add(this.pctAst3);
            this.grpEspace.Controls.Add(this.lblAst5);
            this.grpEspace.Controls.Add(this.pctAst5);
            this.grpEspace.Controls.Add(this.lblAst4);
            this.grpEspace.Controls.Add(this.pctAst4);
            this.grpEspace.Controls.Add(this.lblAst1);
            this.grpEspace.Controls.Add(this.pctAst1);
            this.grpEspace.Controls.Add(this.lblNomEspace);
            this.grpEspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpEspace.Location = new System.Drawing.Point(108, 38);
            this.grpEspace.Name = "grpEspace";
            this.grpEspace.Size = new System.Drawing.Size(572, 338);
            this.grpEspace.TabIndex = 2;
            this.grpEspace.TabStop = false;
            // 
            // lblAst6
            // 
            this.lblAst6.BackColor = System.Drawing.Color.Transparent;
            this.lblAst6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst6.ForeColor = System.Drawing.Color.White;
            this.lblAst6.Location = new System.Drawing.Point(20, 229);
            this.lblAst6.Name = "lblAst6";
            this.lblAst6.Size = new System.Drawing.Size(72, 27);
            this.lblAst6.TabIndex = 23;
            this.lblAst6.Text = "mot...";
            // 
            // pctAst6
            // 
            this.pctAst6.BackColor = System.Drawing.Color.Transparent;
            this.pctAst6.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst6.Location = new System.Drawing.Point(25, 174);
            this.pctAst6.Name = "pctAst6";
            this.pctAst6.Size = new System.Drawing.Size(52, 61);
            this.pctAst6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst6.TabIndex = 22;
            this.pctAst6.TabStop = false;
            // 
            // lblAst2
            // 
            this.lblAst2.BackColor = System.Drawing.Color.Transparent;
            this.lblAst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst2.ForeColor = System.Drawing.Color.White;
            this.lblAst2.Location = new System.Drawing.Point(411, 229);
            this.lblAst2.Name = "lblAst2";
            this.lblAst2.Size = new System.Drawing.Size(72, 27);
            this.lblAst2.TabIndex = 21;
            this.lblAst2.Text = "mot...";
            // 
            // pctAst2
            // 
            this.pctAst2.BackColor = System.Drawing.Color.Transparent;
            this.pctAst2.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst2.Location = new System.Drawing.Point(416, 174);
            this.pctAst2.Name = "pctAst2";
            this.pctAst2.Size = new System.Drawing.Size(52, 61);
            this.pctAst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst2.TabIndex = 20;
            this.pctAst2.TabStop = false;
            // 
            // lblAst3
            // 
            this.lblAst3.BackColor = System.Drawing.Color.Transparent;
            this.lblAst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst3.ForeColor = System.Drawing.Color.White;
            this.lblAst3.Location = new System.Drawing.Point(326, 102);
            this.lblAst3.Name = "lblAst3";
            this.lblAst3.Size = new System.Drawing.Size(72, 27);
            this.lblAst3.TabIndex = 19;
            this.lblAst3.Text = "mot...";
            // 
            // pctAst3
            // 
            this.pctAst3.BackColor = System.Drawing.Color.Transparent;
            this.pctAst3.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst3.Location = new System.Drawing.Point(331, 47);
            this.pctAst3.Name = "pctAst3";
            this.pctAst3.Size = new System.Drawing.Size(52, 61);
            this.pctAst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst3.TabIndex = 18;
            this.pctAst3.TabStop = false;
            // 
            // lblAst5
            // 
            this.lblAst5.BackColor = System.Drawing.Color.Transparent;
            this.lblAst5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst5.ForeColor = System.Drawing.Color.White;
            this.lblAst5.Location = new System.Drawing.Point(63, 123);
            this.lblAst5.Name = "lblAst5";
            this.lblAst5.Size = new System.Drawing.Size(72, 27);
            this.lblAst5.TabIndex = 17;
            this.lblAst5.Text = "mot...";
            // 
            // pctAst5
            // 
            this.pctAst5.BackColor = System.Drawing.Color.Transparent;
            this.pctAst5.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst5.Location = new System.Drawing.Point(68, 68);
            this.pctAst5.Name = "pctAst5";
            this.pctAst5.Size = new System.Drawing.Size(52, 61);
            this.pctAst5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst5.TabIndex = 16;
            this.pctAst5.TabStop = false;
            // 
            // lblAst4
            // 
            this.lblAst4.BackColor = System.Drawing.Color.Transparent;
            this.lblAst4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst4.ForeColor = System.Drawing.Color.White;
            this.lblAst4.Location = new System.Drawing.Point(166, 114);
            this.lblAst4.Name = "lblAst4";
            this.lblAst4.Size = new System.Drawing.Size(72, 27);
            this.lblAst4.TabIndex = 15;
            this.lblAst4.Text = "mot...";
            // 
            // pctAst4
            // 
            this.pctAst4.BackColor = System.Drawing.Color.Transparent;
            this.pctAst4.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst4.Location = new System.Drawing.Point(171, 59);
            this.pctAst4.Name = "pctAst4";
            this.pctAst4.Size = new System.Drawing.Size(52, 61);
            this.pctAst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst4.TabIndex = 14;
            this.pctAst4.TabStop = false;
            // 
            // lblAst1
            // 
            this.lblAst1.BackColor = System.Drawing.Color.Transparent;
            this.lblAst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst1.ForeColor = System.Drawing.Color.White;
            this.lblAst1.Location = new System.Drawing.Point(486, 123);
            this.lblAst1.Name = "lblAst1";
            this.lblAst1.Size = new System.Drawing.Size(72, 27);
            this.lblAst1.TabIndex = 13;
            this.lblAst1.Text = "mot...";
            // 
            // pctAst1
            // 
            this.pctAst1.BackColor = System.Drawing.Color.Transparent;
            this.pctAst1.Image = global::Gravity_Learning.Properties.Resources.asteroid1;
            this.pctAst1.Location = new System.Drawing.Point(491, 68);
            this.pctAst1.Name = "pctAst1";
            this.pctAst1.Size = new System.Drawing.Size(52, 61);
            this.pctAst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAst1.TabIndex = 12;
            this.pctAst1.TabStop = false;
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
            this.Controls.Add(this.txtZoneFrappe);
            this.Controls.Add(this.lblTapezInfo);
            this.Controls.Add(this.grpEspace);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdReDemarrer);
            this.Name = "frmGravityDactylo";
            this.Text = "Gravity Dactylo";
            this.Load += new System.EventHandler(this.FrmGravityDactylo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctAst6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAst1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReDemarrer;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.GroupBox grpEspace;
        private System.Windows.Forms.Label lblTapezInfo;
        private System.Windows.Forms.TextBox txtZoneFrappe;
        private System.Windows.Forms.ProgressBar prgProgressionJeu;
        private System.Windows.Forms.Label lblPointsInfo;
        private System.Windows.Forms.Label lblProgression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrVitesse;
        private System.Windows.Forms.Label lblNomEspace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctAst1;
        private System.Windows.Forms.Label lblAst1;
        private System.Windows.Forms.Label lblAst6;
        private System.Windows.Forms.PictureBox pctAst6;
        private System.Windows.Forms.Label lblAst2;
        private System.Windows.Forms.PictureBox pctAst2;
        private System.Windows.Forms.Label lblAst3;
        private System.Windows.Forms.PictureBox pctAst3;
        private System.Windows.Forms.Label lblAst5;
        private System.Windows.Forms.PictureBox pctAst5;
        private System.Windows.Forms.Label lblAst4;
        private System.Windows.Forms.PictureBox pctAst4;
    }
}

