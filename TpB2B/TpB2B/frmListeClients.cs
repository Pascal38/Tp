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
    public partial class frmListeClients : Form
    {
        public frmListeClients()
        {
            InitializeComponent();
        }

        private void btnNvxClient_Click(object sender, EventArgs e)
        {
            frmNvxClient frmNC; // déclare une instance du form
            frmNC = new frmNvxClient(); // instancie le form
            frmNC.Show(); // affiche le form dans son conteneur
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        
        }
    }
}
