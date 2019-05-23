using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trombinoscope
{
    public partial class frmTrombinoscope : Form
    {
        string username = "bob";
        public frmTrombinoscope()
        {
            InitializeComponent();
        }
        const int salut=2;
        private void frmTrombinoscope_Load(object sender, EventArgs e)
        {
            Control label1 = new System.Windows.Forms.Label(); // Création d'un contrôle Label
            label1.BackColor = System.Drawing.Color.Yellow; // Couleur de fond
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", // Police
            15F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            label1.Location = new System.Drawing.Point(36, 24); // Position
            label1.Name = "label1"; // Nom
            label1.Size = new System.Drawing.Size(115, 25); // Dimensions
            label1.Text = username; // Texte
            Controls.Add(label1); // Ajout au formulaire
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
