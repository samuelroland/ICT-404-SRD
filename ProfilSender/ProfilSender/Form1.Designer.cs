namespace ProfilSender
{
    partial class frmProfilSender
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
            this.chkPresent = new System.Windows.Forms.CheckBox();
            this.optContent = new System.Windows.Forms.RadioButton();
            this.optCool = new System.Windows.Forms.RadioButton();
            this.optNerveux = new System.Windows.Forms.RadioButton();
            this.optPasContent = new System.Windows.Forms.RadioButton();
            this.optAngelique = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkPresent
            // 
            this.chkPresent.AutoSize = true;
            this.chkPresent.Location = new System.Drawing.Point(25, 12);
            this.chkPresent.Name = "chkPresent";
            this.chkPresent.Size = new System.Drawing.Size(62, 17);
            this.chkPresent.TabIndex = 0;
            this.chkPresent.Text = "Présent";
            this.chkPresent.UseVisualStyleBackColor = true;
            this.chkPresent.CheckedChanged += new System.EventHandler(this.ChkPresent_CheckedChanged);
            // 
            // optContent
            // 
            this.optContent.AutoSize = true;
            this.optContent.Location = new System.Drawing.Point(119, 12);
            this.optContent.Name = "optContent";
            this.optContent.Size = new System.Drawing.Size(62, 17);
            this.optContent.TabIndex = 1;
            this.optContent.Text = "Content";
            this.optContent.UseVisualStyleBackColor = true;
            this.optContent.CheckedChanged += new System.EventHandler(this.OptContent_CheckedChanged);
            // 
            // optCool
            // 
            this.optCool.AutoSize = true;
            this.optCool.Location = new System.Drawing.Point(119, 41);
            this.optCool.Name = "optCool";
            this.optCool.Size = new System.Drawing.Size(46, 17);
            this.optCool.TabIndex = 2;
            this.optCool.Text = "Cool";
            this.optCool.UseVisualStyleBackColor = true;
            this.optCool.CheckedChanged += new System.EventHandler(this.OptCool_CheckedChanged);
            // 
            // optNerveux
            // 
            this.optNerveux.AutoSize = true;
            this.optNerveux.Location = new System.Drawing.Point(119, 70);
            this.optNerveux.Name = "optNerveux";
            this.optNerveux.Size = new System.Drawing.Size(65, 17);
            this.optNerveux.TabIndex = 3;
            this.optNerveux.Text = "Nerveux";
            this.optNerveux.UseVisualStyleBackColor = true;
            this.optNerveux.CheckedChanged += new System.EventHandler(this.OptNerveux_CheckedChanged);
            // 
            // optPasContent
            // 
            this.optPasContent.AutoSize = true;
            this.optPasContent.Location = new System.Drawing.Point(119, 99);
            this.optPasContent.Name = "optPasContent";
            this.optPasContent.Size = new System.Drawing.Size(82, 17);
            this.optPasContent.TabIndex = 4;
            this.optPasContent.Text = "Pas content";
            this.optPasContent.UseVisualStyleBackColor = true;
            this.optPasContent.CheckedChanged += new System.EventHandler(this.OptPasContent_CheckedChanged);
            // 
            // optAngelique
            // 
            this.optAngelique.AutoSize = true;
            this.optAngelique.Location = new System.Drawing.Point(119, 128);
            this.optAngelique.Name = "optAngelique";
            this.optAngelique.Size = new System.Drawing.Size(72, 17);
            this.optAngelique.TabIndex = 5;
            this.optAngelique.Text = "Angélique";
            this.optAngelique.UseVisualStyleBackColor = true;
            this.optAngelique.CheckedChanged += new System.EventHandler(this.OptAngelique_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(22, 165);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(25, 181);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(233, 66);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.Validated += new System.EventHandler(this.TxtMessage_Validated);
            // 
            // frmProfilSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 259);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.optAngelique);
            this.Controls.Add(this.optPasContent);
            this.Controls.Add(this.optNerveux);
            this.Controls.Add(this.optCool);
            this.Controls.Add(this.optContent);
            this.Controls.Add(this.chkPresent);
            this.Name = "frmProfilSender";
            this.Text = "Username";
            this.Load += new System.EventHandler(this.FrmProfilSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPresent;
        private System.Windows.Forms.RadioButton optContent;
        private System.Windows.Forms.RadioButton optCool;
        private System.Windows.Forms.RadioButton optNerveux;
        private System.Windows.Forms.RadioButton optPasContent;
        private System.Windows.Forms.RadioButton optAngelique;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

