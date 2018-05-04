using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpB2B
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// menu Fenêtres / Liste des Clients ==> instancier un form frmTime
        /// </summary>
        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeClients frmL; // déclare une instance du form
            frmL = new frmListeClients(); // instancie le form
            frmL.MdiParent = this;
            frmL.Show(); // affiche le form dans son conteneur
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNvxClient frmNC; // déclare une instance du form
            frmNC = new frmNvxClient(); // instancie le form
            frmNC.MdiParent = this;
            frmNC.Show(); // affiche le form dans son conteneur
        }

        private void nouveauContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNvxContact frmNC; // déclare une instance du form
            frmNC = new frmNvxContact(); // instancie le form
            frmNC.Show(); // affiche le form dans son conteneur
        }
    }
}
