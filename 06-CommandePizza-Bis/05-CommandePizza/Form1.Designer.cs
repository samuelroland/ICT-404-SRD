namespace _05_CommandePizza
{
    partial class frmCommandePizza
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
            this.lblTable = new System.Windows.Forms.Label();
            this.optExtrafine = new System.Windows.Forms.RadioButton();
            this.optFine = new System.Windows.Forms.RadioButton();
            this.optNormale = new System.Windows.Forms.RadioButton();
            this.optEpaisse = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.cmdCommander = new System.Windows.Forms.Button();
            this.lblPateCadre = new System.Windows.Forms.Label();
            this.cmdChanger = new System.Windows.Forms.Button();
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.txtRepertoire = new System.Windows.Forms.TextBox();
            this.fbdRepertoire = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(31, 19);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 18);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // optExtrafine
            // 
            this.optExtrafine.AutoSize = true;
            this.optExtrafine.Location = new System.Drawing.Point(56, 65);
            this.optExtrafine.Name = "optExtrafine";
            this.optExtrafine.Size = new System.Drawing.Size(69, 17);
            this.optExtrafine.TabIndex = 2;
            this.optExtrafine.Text = "Extra-fine";
            this.optExtrafine.UseVisualStyleBackColor = true;
            // 
            // optFine
            // 
            this.optFine.AutoSize = true;
            this.optFine.Location = new System.Drawing.Point(56, 88);
            this.optFine.Name = "optFine";
            this.optFine.Size = new System.Drawing.Size(45, 17);
            this.optFine.TabIndex = 3;
            this.optFine.Text = "Fine";
            this.optFine.UseVisualStyleBackColor = true;
            // 
            // optNormale
            // 
            this.optNormale.AutoSize = true;
            this.optNormale.Location = new System.Drawing.Point(56, 111);
            this.optNormale.Name = "optNormale";
            this.optNormale.Size = new System.Drawing.Size(64, 17);
            this.optNormale.TabIndex = 4;
            this.optNormale.Text = "Normale";
            this.optNormale.UseVisualStyleBackColor = true;
            // 
            // optEpaisse
            // 
            this.optEpaisse.AutoSize = true;
            this.optEpaisse.Location = new System.Drawing.Point(56, 134);
            this.optEpaisse.Name = "optEpaisse";
            this.optEpaisse.Size = new System.Drawing.Size(62, 17);
            this.optEpaisse.TabIndex = 5;
            this.optEpaisse.Text = "Epaisse";
            this.optEpaisse.UseVisualStyleBackColor = true;
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(190, 66);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 6;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(190, 89);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 7;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(190, 112);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 8;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(190, 135);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 9;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTable.Location = new System.Drawing.Point(81, 17);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(44, 24);
            this.txtTable.TabIndex = 1;
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(179, 193);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(75, 23);
            this.cmdCommander.TabIndex = 11;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            this.cmdCommander.Click += new System.EventHandler(this.cmdCommander_Click);
            // 
            // lblPateCadre
            // 
            this.lblPateCadre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPateCadre.Location = new System.Drawing.Point(35, 44);
            this.lblPateCadre.Name = "lblPateCadre";
            this.lblPateCadre.Size = new System.Drawing.Size(102, 123);
            this.lblPateCadre.TabIndex = 13;
            this.lblPateCadre.Text = "Pâte";
            // 
            // cmdChanger
            // 
            this.cmdChanger.Location = new System.Drawing.Point(12, 268);
            this.cmdChanger.Name = "cmdChanger";
            this.cmdChanger.Size = new System.Drawing.Size(75, 23);
            this.cmdChanger.TabIndex = 14;
            this.cmdChanger.Text = "Changer";
            this.cmdChanger.UseVisualStyleBackColor = true;
            this.cmdChanger.Click += new System.EventHandler(this.CmdChanger_Click);
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AutoSize = true;
            this.lblRepertoire.Location = new System.Drawing.Point(93, 273);
            this.lblRepertoire.Name = "lblRepertoire";
            this.lblRepertoire.Size = new System.Drawing.Size(59, 13);
            this.lblRepertoire.TabIndex = 15;
            this.lblRepertoire.Text = "Répertoire:";
            // 
            // txtRepertoire
            // 
            this.txtRepertoire.Location = new System.Drawing.Point(158, 270);
            this.txtRepertoire.Name = "txtRepertoire";
            this.txtRepertoire.Size = new System.Drawing.Size(218, 20);
            this.txtRepertoire.TabIndex = 16;
            // 
            // frmCommandePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 303);
            this.Controls.Add(this.txtRepertoire);
            this.Controls.Add(this.lblRepertoire);
            this.Controls.Add(this.cmdChanger);
            this.Controls.Add(this.cmdCommander);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.optEpaisse);
            this.Controls.Add(this.optNormale);
            this.Controls.Add(this.optFine);
            this.Controls.Add(this.optExtrafine);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblPateCadre);
            this.Name = "frmCommandePizza";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.RadioButton optExtrafine;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.Label lblPateCadre;
        private System.Windows.Forms.Button cmdChanger;
        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.TextBox txtRepertoire;
        private System.Windows.Forms.FolderBrowserDialog fbdRepertoire;
    }
}

