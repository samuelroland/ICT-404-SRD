namespace Trombinoscope
{
    partial class frmTrombinoscope
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
            this.tmrActualiser = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrActualiser
            // 
            this.tmrActualiser.Enabled = true;
            this.tmrActualiser.Interval = 2000;
            this.tmrActualiser.Tick += new System.EventHandler(this.TmrActualiser_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 710);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(453, 673);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(90, 60);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "msg à remplir";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Green;
            this.lblNom.Location = new System.Drawing.Point(453, 660);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(90, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Prénom !";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.Green;
            this.lblIcon.Image = global::Trombinoscope.Properties.Resources.content;
            this.lblIcon.Location = new System.Drawing.Point(453, 563);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(90, 110);
            this.lblIcon.TabIndex = 6;
            // 
            // frmTrombinoscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 741);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.button1);
            this.Name = "frmTrombinoscope";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Tous";
            this.Load += new System.EventHandler(this.frmTrombinoscope_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrActualiser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblIcon;
    }
}

