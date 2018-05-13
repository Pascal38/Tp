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
            this.Init();
        }
        public void Init()
        {
            //vide la combobox sources
            this.cbxActivite.Items.Clear();
            this.cbxNature.Items.Clear();
            //ajoute une collection d'Items
            this.cbxActivite.Items.AddRange(new String[] { "Agro", "Industrie", "Service", "Electronique" });
            this.cbxNature.Items.AddRange(new String[] { "Principale", "Secondaire", "Ancienne" });
            //initialise le type du client (par défaut public)
            this.ChbPrive.Checked = false;
            
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
            MClients nvxclient = new MClients();

            try
            {
                //affecte les données de l'objet MClients
                
                nvxclient.NumClient = Int32.Parse(txtNumClient.Text);
              
                nvxclient.RaisonSociale = txtRaisonSoc.Text;
                
                nvxclient.Adresse1 = txtAdresse.Text;
                nvxclient.Adresse2 = txtAdresse2.Text;
               
                nvxclient.CodePostal = txtCodePostal.Text;
                
                nvxclient.Ville = txtVille.Text;
               
                nvxclient.Telephone = txtTelephone.Text;
               
                nvxclient.TypeClient = ChbPrive.Checked; 
                                                         
                nvxclient.Effectif = Int32.Parse(txtEffectif.Text);
               
                nvxclient.CA = Int64.Parse(txtCA.Text);
                
                nvxclient.Activite = cbxActivite.SelectedItem.ToString();
                
                nvxclient.Nature = cbxNature.SelectedItem.ToString();
                
                //ajouter la référence d'objet MClients dans la collection
                Donnees.ArrayClient.Add(nvxclient);
                //incrémenter le nombre de client
                MClients.Nclients += 1;


            }
            catch (Exception eNcli)
            {
                MessageBox.Show("Erreur : \n" + eNcli.Message + "Ajout Nouveau Client");
            }
            
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            frmNvxContact frmNC; // déclare une instance du form
            frmNC = new frmNvxContact(); // instancie le form
            //frmNC.Show(); // affiche le form dans son conteneur 
            //pas de d'afficher l'objet dans MDI en mode modal
            if (frmNC.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("contact ajouté avec Succès");
            }
            else
            {
                MessageBox.Show("ajout de contact à échouer");
            }
        }
    }
}
