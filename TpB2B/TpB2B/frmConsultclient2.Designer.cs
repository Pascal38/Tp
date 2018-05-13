namespace TpB2B
{
    partial class frmConsultclient2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpIdentification.SuspendLayout();
            this.grpCaracteristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIdentification
            // 
            this.grpIdentification.Location = new System.Drawing.Point(28, 11);
            // 
            // grpCaracteristique
            // 
            this.grpCaracteristique.Location = new System.Drawing.Point(30, 259);
            this.grpCaracteristique.Enter += new System.EventHandler(this.grpCaracteristique_Enter);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(337, 438);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(418, 438);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(495, 438);
            // 
            // grdContact
            // 
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(28, 404);
            this.grdContact.Name = "grdContact";
            this.grdContact.Size = new System.Drawing.Size(624, 94);
            this.grdContact.TabIndex = 27;
            this.grdContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgContact_CellContentClick);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(313, 502);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(108, 23);
            this.btnModifierClient.TabIndex = 32;
            this.btnModifierClient.Text = "Modifier Client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(438, 503);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(113, 23);
            this.btnNouveauContact.TabIndex = 31;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(575, 503);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 30;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmConsultclient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(673, 527);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grdContact);
            this.Name = "frmConsultclient2";
            this.Load += new System.EventHandler(this.frmConsultclient2_Load);
            this.Controls.SetChildIndex(this.grpIdentification, 0);
            this.Controls.SetChildIndex(this.grpCaracteristique, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnContacts, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.grdContact, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnNouveauContact, 0);
            this.Controls.SetChildIndex(this.btnModifierClient, 0);
            this.grpIdentification.ResumeLayout(false);
            this.grpIdentification.PerformLayout();
            this.grpCaracteristique.ResumeLayout(false);
            this.grpCaracteristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
    }
}
