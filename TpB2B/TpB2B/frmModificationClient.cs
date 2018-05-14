using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMdfClient
{
    public partial class frmModificationClient : Form
    {
        /// <summary> 
        ///  constructeur par défaut 
        /// </summary> 

        public frmModificationClient()
        {
            InitializeComponent();
            this.Init();
        }

        /// <summary> 
        /// initialise la combobox source 
        /// </summary> 
        private void Init()
        {
            // vide la combobox 
            this.cbxActivite.Items.Clear();
            // ajoute 1 item à la fois 
            this.cbxActivite.Items.Add("Bovins");
            this.cbxActivite.Items.Add("Administration");
            // ajoute une collection d'items 
            this.cbxActivite.Items.AddRange(new String[]
               {
                "Laiterie", "Céréales", "Boissons", });
            // vide la combobox 
            this.cbxNature.Items.Clear();
            // ajoute 1 item à la fois 
            this.cbxNature.Items.Add("Principal");
            this.cbxNature.Items.Add("Secondaire");
            // ajoute une collection d'items 
            this.cbxNature.Items.AddRange(new String[]
               {
                "Ancienne", });
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModificationClient_Load(object sender, EventArgs e)
        {

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
