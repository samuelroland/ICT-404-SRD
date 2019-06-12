using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Learning
{
    public partial class frmGravityDactylo : Form
    {
        public frmGravityDactylo()
        {
            InitializeComponent();
        }

        private void FrmGravityDactylo_Load(object sender, EventArgs e)
        {
            tmrVitesse.Enabled = true;

        }

        private void TmrVitesse_Tick(object sender, EventArgs e)
        {

            int y = lblAsteroide.Location.Y;
            lblAsteroide.Location = new Point(x: 300, y: y + 1);
            prgProgressionJeu.Value = y / 5;
        }

        private void CmdReDemarrer_Click(object sender, EventArgs e)
        {
            play();
        }

        private void play()
        {

            //charger les mots...
            string[] mots = { "salut", "bonjour", "asdf", "poiuz", "tchao", " ademin" };

            //Créer l'astéroide 1:

            for (int id = 0; id < 5; id++)
            {
                MessageBox.Show(id.ToString());
                this.lblAsteroide.BackColor = System.Drawing.SystemColors.ActiveCaption;
                this.lblAsteroide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblAsteroide.Location = new System.Drawing.Point(201, 0);
                this.lblAsteroide.Size = new System.Drawing.Size(79, 32);
                this.lblAsteroide.TabIndex = 9;
                this.lblAsteroide.Text = mots[id];
                this.lblAsteroide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.lblAsteroide.Name = "lblAsteroide" + id;
            }

        }
    }
}
