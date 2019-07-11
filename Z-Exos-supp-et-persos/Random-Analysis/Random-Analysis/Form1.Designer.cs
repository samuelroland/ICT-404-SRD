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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandomAnalysis));
            this.tkbNum = new System.Windows.Forms.TrackBar();
            this.grpExplication = new System.Windows.Forms.GroupBox();
            this.lblExplication = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).BeginInit();
            this.grpExplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbNum
            // 
            this.tkbNum.AutoSize = false;
            this.tkbNum.LargeChange = 1;
            this.tkbNum.Location = new System.Drawing.Point(34, 81);
            this.tkbNum.Maximum = 100;
            this.tkbNum.Name = "tkbNum";
            this.tkbNum.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbNum.Size = new System.Drawing.Size(10, 306);
            this.tkbNum.SmallChange = 5;
            this.tkbNum.TabIndex = 3;
            // 
            // grpExplication
            // 
            this.grpExplication.Controls.Add(this.lblExplication);
            this.grpExplication.Location = new System.Drawing.Point(12, 12);
            this.grpExplication.Name = "grpExplication";
            this.grpExplication.Size = new System.Drawing.Size(1600, 63);
            this.grpExplication.TabIndex = 5;
            this.grpExplication.TabStop = false;
            this.grpExplication.Text = "Explication du programme";
            // 
            // lblExplication
            // 
            this.lblExplication.AutoSize = true;
            this.lblExplication.Location = new System.Drawing.Point(6, 16);
            this.lblExplication.Name = "lblExplication";
            this.lblExplication.Size = new System.Drawing.Size(625, 26);
            this.lblExplication.TabIndex = 0;
            this.lblExplication.Text = resources.GetString("lblExplication.Text");
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(55, 81);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(10, 306);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 50;
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(50, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "14";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(29, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "14";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(50, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "14";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(29, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "14";
            // 
            // frmRandomAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpExplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tkbNum);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "frmRandomAnalysis";
            this.Text = "Analyse de nombre aléatoires";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).EndInit();
            this.grpExplication.ResumeLayout(false);
            this.grpExplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tkbNum;
        private System.Windows.Forms.GroupBox grpExplication;
        private System.Windows.Forms.Label lblExplication;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

