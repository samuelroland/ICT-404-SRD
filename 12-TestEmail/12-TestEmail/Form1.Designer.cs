namespace _12_TestEmail
{
    partial class frmTestEmail
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
            this.lblEmailAVerif = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.cmdVerifier = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkAtePresent = new System.Windows.Forms.CheckBox();
            this.chkPointPresent = new System.Windows.Forms.CheckBox();
            this.lblCharsAvant = new System.Windows.Forms.Label();
            this.lblCharsApres = new System.Windows.Forms.Label();
            this.txtCharsAvant = new System.Windows.Forms.TextBox();
            this.txtCharsApres = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmailAVerif
            // 
            this.lblEmailAVerif.AutoSize = true;
            this.lblEmailAVerif.Location = new System.Drawing.Point(57, 30);
            this.lblEmailAVerif.Name = "lblEmailAVerif";
            this.lblEmailAVerif.Size = new System.Drawing.Size(75, 13);
            this.lblEmailAVerif.TabIndex = 3;
            this.lblEmailAVerif.Text = "Email à vérifier";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(57, 198);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(84, 13);
            this.lblNomUser.TabIndex = 1;
            this.lblNomUser.Text = "Nom d\'utilisateur";
            // 
            // cmdVerifier
            // 
            this.cmdVerifier.Location = new System.Drawing.Point(465, 25);
            this.cmdVerifier.Name = "cmdVerifier";
            this.cmdVerifier.Size = new System.Drawing.Size(75, 23);
            this.cmdVerifier.TabIndex = 2;
            this.cmdVerifier.Text = "Vérifier";
            this.cmdVerifier.UseVisualStyleBackColor = true;
            this.cmdVerifier.Click += new System.EventHandler(this.CmdVerifier_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // chkAtePresent
            // 
            this.chkAtePresent.AutoCheck = false;
            this.chkAtePresent.AutoSize = true;
            this.chkAtePresent.Location = new System.Drawing.Point(60, 84);
            this.chkAtePresent.Name = "chkAtePresent";
            this.chkAtePresent.Size = new System.Drawing.Size(85, 17);
            this.chkAtePresent.TabIndex = 4;
            this.chkAtePresent.Text = "\"@\" présent";
            this.chkAtePresent.ThreeState = true;
            this.chkAtePresent.UseVisualStyleBackColor = true;
            // 
            // chkPointPresent
            // 
            this.chkPointPresent.AutoCheck = false;
            this.chkPointPresent.AutoSize = true;
            this.chkPointPresent.Location = new System.Drawing.Point(60, 169);
            this.chkPointPresent.Name = "chkPointPresent";
            this.chkPointPresent.Size = new System.Drawing.Size(141, 17);
            this.chkPointPresent.TabIndex = 5;
            this.chkPointPresent.Text = "\".\" présent après le \"@\"";
            this.chkPointPresent.UseVisualStyleBackColor = true;
            // 
            // lblCharsAvant
            // 
            this.lblCharsAvant.AutoSize = true;
            this.lblCharsAvant.Location = new System.Drawing.Point(80, 116);
            this.lblCharsAvant.Name = "lblCharsAvant";
            this.lblCharsAvant.Size = new System.Drawing.Size(107, 13);
            this.lblCharsAvant.TabIndex = 6;
            this.lblCharsAvant.Text = "caractère(s) avant @";
            // 
            // lblCharsApres
            // 
            this.lblCharsApres.AutoSize = true;
            this.lblCharsApres.Location = new System.Drawing.Point(80, 141);
            this.lblCharsApres.Name = "lblCharsApres";
            this.lblCharsApres.Size = new System.Drawing.Size(106, 13);
            this.lblCharsApres.TabIndex = 7;
            this.lblCharsApres.Text = "caractère(s) après @";
            // 
            // txtCharsAvant
            // 
            this.txtCharsAvant.Location = new System.Drawing.Point(49, 113);
            this.txtCharsAvant.Name = "txtCharsAvant";
            this.txtCharsAvant.ReadOnly = true;
            this.txtCharsAvant.Size = new System.Drawing.Size(25, 20);
            this.txtCharsAvant.TabIndex = 8;
            // 
            // txtCharsApres
            // 
            this.txtCharsApres.Location = new System.Drawing.Point(49, 138);
            this.txtCharsApres.Name = "txtCharsApres";
            this.txtCharsApres.ReadOnly = true;
            this.txtCharsApres.Size = new System.Drawing.Size(25, 20);
            this.txtCharsApres.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(102, 257);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(198, 20);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "L\'adresse est ... formée";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(152, 198);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(179, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "label1";
            // 
            // frmTestEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 307);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCharsApres);
            this.Controls.Add(this.txtCharsAvant);
            this.Controls.Add(this.lblCharsApres);
            this.Controls.Add(this.lblCharsAvant);
            this.Controls.Add(this.chkPointPresent);
            this.Controls.Add(this.chkAtePresent);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmdVerifier);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblEmailAVerif);
            this.Name = "frmTestEmail";
            this.Text = "Vérification d\'Email";
            this.Load += new System.EventHandler(this.FrmTestEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailAVerif;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Button cmdVerifier;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkAtePresent;
        private System.Windows.Forms.CheckBox chkPointPresent;
        private System.Windows.Forms.Label lblCharsAvant;
        private System.Windows.Forms.Label lblCharsApres;
        private System.Windows.Forms.TextBox txtCharsAvant;
        private System.Windows.Forms.TextBox txtCharsApres;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUsername;
    }
}

