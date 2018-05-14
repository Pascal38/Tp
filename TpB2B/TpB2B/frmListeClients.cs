using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Cod pour le Form Liste Clients
/// Avec un DataGridView ainsi qu'une zone de recherche.
/// Fait par : Pascal
/// Le : 13 Mai 2018
/// </summary>
namespace TpB2B
{
    public partial class frmListeClients : Form
    {

        private Int32 iClient;

        public frmListeClients()
        {
            InitializeComponent();
        }

        private void btnNvxClient_Click(object sender, EventArgs e)
        {
            frmNvxClient frmNC; // déclare une instance du form
            frmNC = new frmNvxClient(); // instancie le form
            //frmNC.Show(); // affiche le form dans son conteneur
            if (frmNC.ShowDialog() == DialogResult.OK)
            {
                //recherche rang du client
                //this.iClient = MClients.NClients - 1;
                //afficher ce client sur le form Liste des clients
                this.afficheClients();
            }
        }



        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();

        }
        /// <summary>
        /// rétablit la source de données de la dataGridView
        /// et rafraîchit son affichage
        /// </summary>
        private void afficheClients()
        {
            // DataTable : pour recopier les Clients
            // (stockés en collection) ;
            // à relier au DataGridView pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr; // ligne de la datatable
            Int32 i; // var de boucle
                     // ajout à la datatable de 5 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Privé ?", typeof(bool)));
            dt.Columns.Add(new DataColumn("Activite", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            // boucle remplissage de la DataTable à partir de la collection
            for (i = 0; i < Donnees.ArrayClient.Count; i++)
            {
                // instanciation DataRow (=ligne de DataTable)
                dr = dt.NewRow();
                // affectation des 5 colonnes
                // la collection voit les éléments comme des ‘Object’
                // ==>'caster' en MStagiaire pour en voir les attributs
                dr[0] = ((MClients)(Donnees.ArrayClient[i])).RaisonSociale;
                dr[1] = ((MClients)(Donnees.ArrayClient[i])).Ville;
                dr[2] = ((MClients)(Donnees.ArrayClient[i])).CodePostal;
                dr[3] = ((MClients)(Donnees.ArrayClient[i])).TypeClient;
                dr[4] = ((MClients)(Donnees.ArrayClient[i])).Activite;
                dr[5] = ((MClients)(Donnees.ArrayClient[i])).Nature;
                // ajout de la ligne à la Datatable
                // (la propriété Rows est elle-même une collection...)
                dt.Rows.Add(dr);
            } // fin de boucle
              // déterminer l'origine des données à afficher en DataGridView
            this.grdListeClients.DataSource = dt;
            // refraîchir l'affichage (même pas utile…)
            this.grdListeClients.Refresh();
            dt = null; // pas vraiment utile non plus…
            dr = null;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.grdListeClients.SelectedRows.Count > 0 &&
            this.grdListeClients.SelectedRows[0].Index !=
            this.grdListeClients.Rows.Count - 1)
            {
                this.grdListeClients.Rows.RemoveAt(
                    this.grdListeClients.SelectedRows[0].Index);
            }
        }
        
        private void grdListeClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 iSClient;

            iSClient = this.grdListeClients.CurrentRow.Index;

            MClients leClient = Donnees.ArrayClient[iSClient] as MClients;

            frmConsultclient2 frmVisu = new frmConsultclient2(leClient);
            frmVisu.ShowDialog();
            this.afficheClients();
        }
        private void frmListeClients_Load(object sender, EventArgs e)
        {

        }
    }
}
