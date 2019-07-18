namespace Random_Analysis
{
    partial class frmRandomAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandomAnalysis));
            this.grpExplication = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxNbFois = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdLancer = new System.Windows.Forms.Button();
            this.lblExplication = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNb14 = new System.Windows.Forms.Label();
            this.tmrRandomGenerator = new System.Windows.Forms.Timer(this.components);
            this.lblDifferenceMax = new System.Windows.Forms.Label();
            this.txtRandomResult = new System.Windows.Forms.TextBox();
            this.tmrEcriture = new System.Windows.Forms.Timer(this.components);
            this.grpExplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExplication
            // 
            this.grpExplication.Controls.Add(this.label1);
            this.grpExplication.Controls.Add(this.txtMaxNbFois);
            this.grpExplication.Controls.Add(this.cmdSave);
            this.grpExplication.Controls.Add(this.cmdLancer);
            this.grpExplication.Controls.Add(this.lblExplication);
            this.grpExplication.Location = new System.Drawing.Point(12, 12);
            this.grpExplication.Name = "grpExplication";
            this.grpExplication.Size = new System.Drawing.Size(1100, 63);
            this.grpExplication.TabIndex = 5;
            this.grpExplication.TabStop = false;
            this.grpExplication.Text = "Explication du programme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nb max de fois tiré:";
            // 
            // txtMaxNbFois
            // 
            this.txtMaxNbFois.Location = new System.Drawing.Point(688, 35);
            this.txtMaxNbFois.Name = "txtMaxNbFois";
            this.txtMaxNbFois.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNbFois.TabIndex = 3;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(913, 13);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(181, 42);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Sauver les résultats";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // cmdLancer
            // 
            this.cmdLancer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLancer.Location = new System.Drawing.Point(808, 13);
            this.cmdLancer.Name = "cmdLancer";
            this.cmdLancer.Size = new System.Drawing.Size(99, 42);
            this.cmdLancer.TabIndex = 1;
            this.cmdLancer.Text = "Lancer";
            this.cmdLancer.UseVisualStyleBackColor = false;
            this.cmdLancer.Click += new System.EventHandler(this.CmdLancer_Click);
            // 
            // lblExplication
            // 
            this.lblExplication.AutoSize = true;
            this.lblExplication.Location = new System.Drawing.Point(6, 16);
            this.lblExplication.Name = "lblExplication";
            this.lblExplication.Size = new System.Drawing.Size(676, 26);
            this.lblExplication.TabIndex = 0;
            this.lblExplication.Text = resources.GetString("lblExplication.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numéros et nombres de fois tirés.";
            // 
            // lblNb14
            // 
            this.lblNb14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNb14.Location = new System.Drawing.Point(29, 458);
            this.lblNb14.Name = "lblNb14";
            this.lblNb14.Size = new System.Drawing.Size(33, 15);
            this.lblNb14.TabIndex = 8;
            this.lblNb14.Text = "3059";
            this.lblNb14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrRandomGenerator
            // 
            this.tmrRandomGenerator.Interval = 1;
            this.tmrRandomGenerator.Tick += new System.EventHandler(this.TmrRandomGenerator_Tick);
            // 
            // lblDifferenceMax
            // 
            this.lblDifferenceMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDifferenceMax.Location = new System.Drawing.Point(68, 458);
            this.lblDifferenceMax.Name = "lblDifferenceMax";
            this.lblDifferenceMax.Size = new System.Drawing.Size(297, 15);
            this.lblDifferenceMax.TabIndex = 9;
            this.lblDifferenceMax.Text = "Différence: 8";
            this.lblDifferenceMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRandomResult
            // 
            this.txtRandomResult.Location = new System.Drawing.Point(12, 476);
            this.txtRandomResult.Multiline = true;
            this.txtRandomResult.Name = "txtRandomResult";
            this.txtRandomResult.ReadOnly = true;
            this.txtRandomResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRandomResult.Size = new System.Drawing.Size(1630, 241);
            this.txtRandomResult.TabIndex = 11;
            this.txtRandomResult.Text = "Randoms: ";
            this.txtRandomResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmrEcriture
            // 
            this.tmrEcriture.Interval = 10000;
            this.tmrEcriture.Tick += new System.EventHandler(this.TmrEcriture_Tick);
            // 
            // frmRandomAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 742);
            this.Controls.Add(this.txtRandomResult);
            this.Controls.Add(this.lblDifferenceMax);
            this.Controls.Add(this.lblNb14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpExplication);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "frmRandomAnalysis";
            this.Text = "Analyse de nombre aléatoires";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpExplication.ResumeLayout(false);
            this.grpExplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpExplication;
        private System.Windows.Forms.Label lblExplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNb14;
        private System.Windows.Forms.Button cmdLancer;
        private System.Windows.Forms.Timer tmrRandomGenerator;
        private System.Windows.Forms.Label lblDifferenceMax;
        private System.Windows.Forms.TextBox txtRandomResult;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxNbFois;
        private System.Windows.Forms.Timer tmrEcriture;
    }
}

