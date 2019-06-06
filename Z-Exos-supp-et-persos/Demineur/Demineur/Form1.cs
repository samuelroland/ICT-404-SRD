using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    public partial class frmDenimeur : Form
    {
        public frmDenimeur()
        {
            InitializeComponent();
        }
        private void charger(object sender)
        {
            MessageBox.Show("son nom c " + sender + this.Text);
            cmd[i].text = "safsd";
        }
        private void cmdtest_Click(object sender, EventArgs e)
        {
            charger(this);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
