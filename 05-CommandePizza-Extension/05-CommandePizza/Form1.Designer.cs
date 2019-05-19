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
            this.lblCommande = new System.Windows.Forms.Label();
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
            this.lblResultatCommande = new System.Windows.Forms.Label();
            this.lblPateCadre = new System.Windows.Forms.Label();
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
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(31, 202);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(60, 13);
            this.lblCommande.TabIndex = 1;
            this.lblCommande.Text = "Commande";
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
            this.txtTable.Text = ".";
            this.txtTable.TextChanged += new System.EventHandler(this.txtTable_TextChanged);
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(214, 197);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(75, 23);
            this.cmdCommander.TabIndex = 10;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            this.cmdCommander.Click += new System.EventHandler(this.cmdCommander_Click);
            // 
            // lblResultatCommande
            // 
            this.lblResultatCommande.BackColor = System.Drawing.Color.Yellow;
            this.lblResultatCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResultatCommande.Location = new System.Drawing.Point(30, 223);
            this.lblResultatCommande.Name = "lblResultatCommande";
            this.lblResultatCommande.Size = new System.Drawing.Size(259, 73);
            this.lblResultatCommande.TabIndex = 12;
            this.lblResultatCommande.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // frmCommandePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 303);
            this.Controls.Add(this.lblResultatCommande);
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
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblPateCadre);
            this.Name = "frmCommandePizza";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.frmCommandePizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.Label lblResultatCommande;
        private System.Windows.Forms.RadioButton optExtrafine;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.Label lblPateCadre;
    }
}

