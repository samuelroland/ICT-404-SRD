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
            
        }
    }
}
