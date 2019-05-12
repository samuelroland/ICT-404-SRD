namespace _03_Deductions
{
    partial class frmDeductions
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
            this.lblRevenu = new System.Windows.Forms.Label();
            this.lblCoefficient = new System.Windows.Forms.Label();
            this.lblRevenueImposable = new System.Windows.Forms.Label();
            this.checkBoxDeductionJeune = new System.Windows.Forms.CheckBox();
            this.checkBoxDeductionTransport = new System.Windows.Forms.CheckBox();
            this.checkBoxRabais = new System.Windows.Forms.CheckBox();
            this.textBoxRevenueAnnuel = new System.Windows.Forms.TextBox();
            this.textBoxCoefficient = new System.Windows.Forms.TextBox();
            this.textBoxRabais = new System.Windows.Forms.TextBox();
            this.textBoxDeductionsTransport = new System.Windows.Forms.TextBox();
            this.textBoxDeductionJeune = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRevenu
            // 
            this.lblRevenu.AutoSize = true;
            this.lblRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenu.Location = new System.Drawing.Point(24, 27);
            this.lblRevenu.Name = "lblRevenu";
            this.lblRevenu.Size = new System.Drawing.Size(134, 18);
            this.lblRevenu.TabIndex = 0;
            this.lblRevenu.Text = "Revenu annuel brut";
            // 
            // lblCoefficient
            // 
            this.lblCoefficient.AutoSize = true;
            this.lblCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefficient.Location = new System.Drawing.Point(24, 79);
            this.lblCoefficient.Name = "lblCoefficient";
            this.lblCoefficient.Size = new System.Drawing.Size(127, 18);
            this.lblCoefficient.TabIndex = 1;
            this.lblCoefficient.Text = "Coefficient familial";
            // 
            // lblRevenueImposable
            // 
            this.lblRevenueImposable.AutoSize = true;
            this.lblRevenueImposable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueImposable.Location = new System.Drawing.Point(93, 312);
            this.lblRevenueImposable.Name = "lblRevenueImposable";
            this.lblRevenueImposable.Size = new System.Drawing.Size(20, 18);
            this.lblRevenueImposable.TabIndex = 2;
            this.lblRevenueImposable.Text = "...";
            // 
            // checkBoxDeductionJeune
            // 
            this.checkBoxDeductionJeune.AutoSize = true;
            this.checkBoxDeductionJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxDeductionJeune.Location = new System.Drawing.Point(96, 145);
            this.checkBoxDeductionJeune.Name = "checkBoxDeductionJeune";
            this.checkBoxDeductionJeune.Size = new System.Drawing.Size(133, 22);
            this.checkBoxDeductionJeune.TabIndex = 3;
            this.checkBoxDeductionJeune.Text = "Déduction jeune";
            this.checkBoxDeductionJeune.UseVisualStyleBackColor = true;
            this.checkBoxDeductionJeune.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxDeductionJeune_KeyDown);
            // 
            // checkBoxDeductionTransport
            // 
            this.checkBoxDeductionTransport.AutoSize = true;
            this.checkBoxDeductionTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxDeductionTransport.Location = new System.Drawing.Point(96, 173);
            this.checkBoxDeductionTransport.Name = "checkBoxDeductionTransport";
            this.checkBoxDeductionTransport.Size = new System.Drawing.Size(157, 22);
            this.checkBoxDeductionTransport.TabIndex = 5;
            this.checkBoxDeductionTransport.Text = "Déduction transport";
            this.checkBoxDeductionTransport.UseVisualStyleBackColor = true;
            this.checkBoxDeductionTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBoxDeductionTransport_KeyPress);
            // 
            // checkBoxRabais
            // 
            this.checkBoxRabais.AutoSize = true;
            this.checkBoxRabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxRabais.Location = new System.Drawing.Point(96, 201);
            this.checkBoxRabais.Name = "checkBoxRabais";
            this.checkBoxRabais.Size = new System.Drawing.Size(145, 22);
            this.checkBoxRabais.TabIndex = 7;
            this.checkBoxRabais.Text = "Rabais fidélité (%)";
            this.checkBoxRabais.UseVisualStyleBackColor = true;
            this.checkBoxRabais.CheckedChanged += new System.EventHandler(this.checkBoxRabais_CheckedChanged);
            // 
            // textBoxRevenueAnnuel
            // 
            this.textBoxRevenueAnnuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxRevenueAnnuel.Location = new System.Drawing.Point(187, 27);
            this.textBoxRevenueAnnuel.Name = "textBoxRevenueAnnuel";
            this.textBoxRevenueAnnuel.Size = new System.Drawing.Size(143, 24);
            this.textBoxRevenueAnnuel.TabIndex = 1;
            this.textBoxRevenueAnnuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRevenueAnnuel.TextChanged += new System.EventHandler(this.textBoxRevenueAnnuel_TextChanged);
            // 
            // textBoxCoefficient
            // 
            this.textBoxCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCoefficient.Location = new System.Drawing.Point(269, 73);
            this.textBoxCoefficient.Name = "textBoxCoefficient";
            this.textBoxCoefficient.Size = new System.Drawing.Size(61, 24);
            this.textBoxCoefficient.TabIndex = 2;
            this.textBoxCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient.TextChanged += new System.EventHandler(this.textBoxCoefficient_TextChanged);
            // 
            // textBoxRabais
            // 
            this.textBoxRabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxRabais.Location = new System.Drawing.Point(269, 199);
            this.textBoxRabais.Name = "textBoxRabais";
            this.textBoxRabais.Size = new System.Drawing.Size(61, 24);
            this.textBoxRabais.TabIndex = 8;
            this.textBoxRabais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRabais.TextChanged += new System.EventHandler(this.textBoxRabais_TextChanged);
            // 
            // textBoxDeductionsTransport
            // 
            this.textBoxDeductionsTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxDeductionsTransport.Location = new System.Drawing.Point(269, 170);
            this.textBoxDeductionsTransport.Name = "textBoxDeductionsTransport";
            this.textBoxDeductionsTransport.Size = new System.Drawing.Size(61, 24);
            this.textBoxDeductionsTransport.TabIndex = 6;
            this.textBoxDeductionsTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDeductionsTransport.TextChanged += new System.EventHandler(this.textBoxDeductionsTransport_TextChanged);
            // 
            // textBoxDeductionJeune
            // 
            this.textBoxDeductionJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxDeductionJeune.Location = new System.Drawing.Point(269, 143);
            this.textBoxDeductionJeune.Name = "textBoxDeductionJeune";
            this.textBoxDeductionJeune.Size = new System.Drawing.Size(61, 24);
            this.textBoxDeductionJeune.TabIndex = 4;
            this.textBoxDeductionJeune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDeductionJeune.TextChanged += new System.EventHandler(this.textBoxDeductionJeune_TextChanged);
            // 
            // frmDeductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 364);
            this.Controls.Add(this.textBoxDeductionJeune);
            this.Controls.Add(this.textBoxDeductionsTransport);
            this.Controls.Add(this.textBoxRabais);
            this.Controls.Add(this.textBoxCoefficient);
            this.Controls.Add(this.textBoxRevenueAnnuel);
            this.Controls.Add(this.checkBoxRabais);
            this.Controls.Add(this.checkBoxDeductionTransport);
            this.Controls.Add(this.checkBoxDeductionJeune);
            this.Controls.Add(this.lblRevenueImposable);
            this.Controls.Add(this.lblCoefficient);
            this.Controls.Add(this.lblRevenu);
            this.Name = "frmDeductions";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.frmDeductions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenu;
        private System.Windows.Forms.Label lblCoefficient;
        private System.Windows.Forms.Label lblRevenueImposable;
        private System.Windows.Forms.CheckBox checkBoxDeductionJeune;
        private System.Windows.Forms.CheckBox checkBoxDeductionTransport;
        private System.Windows.Forms.CheckBox checkBoxRabais;
        private System.Windows.Forms.TextBox textBoxRevenueAnnuel;
        private System.Windows.Forms.TextBox textBoxCoefficient;
        private System.Windows.Forms.TextBox textBoxRabais;
        private System.Windows.Forms.TextBox textBoxDeductionsTransport;
        private System.Windows.Forms.TextBox textBoxDeductionJeune;
    }
}

