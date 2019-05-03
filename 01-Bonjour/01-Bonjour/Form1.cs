using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Bonjour
{
    public partial class frmBienvenue : Form
    {
        private ContentAlignment TopRight;

        public frmBienvenue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBienvenueDate.Text = String.Format("{0:dd MMM yyy}", DateTime.Now);
        }

        private void lblBienvenueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
