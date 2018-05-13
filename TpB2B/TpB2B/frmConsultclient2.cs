using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TpB2B
{
    public partial class frmConsultclient2 : TpB2B.frmNvxClient
    {
        /// <summary>
        /// la référence du client à afficher et modifier
        /// </summary>
        private MClients lecli;

        public frmConsultclient2(MClients uncli)
        {
            // créer une référence d’objet client
            // pointant vers le client reçu en paramètre
            this.lecli = uncli;
            InitializeComponent();

        }

        private void frmConsultclient2_Load(object sender, EventArgs e)
        {
            //affiche le client
            this.afficheLeClient(this.lecli);

        }

        private void afficheLeClient(MClients uncli)
        {

            //affectation des TextBox, ComboBox et CheckedBox

            this.txtNumClient.Text = uncli.NumClient.ToString();
            this.txtRaisonSoc.Text = uncli.RaisonSociale;
            this.txtAdresse.Text = uncli.Adresse1;
            this.txtAdresse2.Text = uncli.Adresse2;
            this.txtCodePostal.Text = uncli.CodePostal;
            this.txtVille.Text = uncli.Ville;
            this.txtTelephone.Text = uncli.Telephone;
            this.ChbPrive.Checked = uncli.TypeClient;
            this.txtEffectif.Text = uncli.Effectif.ToString();
            this.txtCA.Text = uncli.CA.ToString();
            this.cbxActivite.SelectedItem = uncli.Activite;
            this.cbxNature.SelectedItem = uncli.Nature;

            //affichage contacts dans la datagrid 

            //DataTable : pour récopier les contacts du client
            //(stockés en collections);
            //à relier au DataGrid pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr;  // ligne de la Datatable
            Int32 i; // variable de boucle
                     //ajout à la datatable de 5 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(String)));
            dt.Columns.Add(new DataColumn("Email", typeof(String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(String)));
            //Boucle de remplissage de la Datatable à partir de la collection 
            for (i = 0; i < Donnees.ArrayClient.Count; i++)
            {
                //instanciation  DataRow (=ligne Datatable)
                dr = dt.NewRow();
                //affectation des 5 colonnes
                //la collection voit les éléments comme des objets
                //==>'caster' en MCLiContacts pour en voir les attributs
                dr[0] = ((MClients)(Donnees.ArrayClient[i])).Nom;
                dr[1] = ((MClients)(Donnees.ArrayClient[i])).Prenom;
                dr[2] = ((MClients)(Donnees.ArrayClient[i])).Telephone;
                dr[3] = ((MClients)(Donnees.ArrayClient[i])).Email;
                dr[4] = ((MClients)(Donnees.ArrayClient[i])).Fonction;

                //ajout de la ligne à la DataTable (la propriété Rows est une collection)
                dt.Rows.Add(dr);
            }// fin de la boucle
             //déterminer l'origne des données à afficher en DataGrid
            this.grdContact.DataSource = dt;
            //refraichir l'affichage
            this.grdContact.Refresh();
            dt = null;
            dr = null;


        }

        private void grpCaracteristique_Enter(object sender, EventArgs e)
        {

        }

        private void drgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {

        }

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
