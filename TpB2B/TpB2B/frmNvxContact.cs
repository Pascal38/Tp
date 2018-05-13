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
    public partial class frmNvxContact : Form
    {
        private frmNvxContact frmNC;
        private MClients nvxcontact;

        public frmNvxContact()
        {
            InitializeComponent();
            this.Init();
        }
        private void Init()
        {
            //vide la combobox source
            this.cbxFonction.Items.Clear();
            //ajoute une collection d'Items
            this.cbxFonction.Items.AddRange(new String[] { "Comptable", "Directeur", "Technicien", "RH" });



        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Close();
            this.DialogResult = DialogResult.Cancel;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //créer une référence d'objet MClients
            nvxcontact = new MClients();
            frmNC = new frmNvxContact();
            try
            {

                //affecte les données de l'objet MClients
                nvxcontact.Nom = txtNom.Text;
                nvxcontact.Prenom = txtPrenom.Text;
                nvxcontact.Telephone = txtTelephone.Text;
                nvxcontact.Email = txtEmail.Text;
                nvxcontact.Fonction = cbxFonction.SelectedItem.ToString();
                //ajouter la référence d'objet MClients dans la collection
                Donnees.ArrayClient.Add(nvxcontact);
                //incrémenter le nombre de contacts du client
                MClients.NContsClient += 1;



            }
            catch (Exception enc)
            {
                nvxcontact = null;
                MessageBox.Show("Erreur : \n" + enc.Message, "Ajout Contact");
            }
        }
    }
}
