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
    public partial class frmNvxClient : Form
    {
        public frmNvxClient()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            // Création et initialisation du bouton
            Button Ok = new Button();

            // Set the button to return a value of OK when clicked.
            btnOK.DialogResult = DialogResult.OK;

            // Ajout du bouton au form.
            Controls.Add(btnOK);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            frmNvxContact frmNC; // déclare une instance du form
            frmNC = new frmNvxContact(); // instancie le form
            frmNC.Show(); // affiche le form dans son conteneur
        }
    }
}
