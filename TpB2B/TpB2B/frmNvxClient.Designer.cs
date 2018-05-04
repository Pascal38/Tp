namespace TpB2B
{
    partial class frmNvxClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvxClient));
            this.grpIdentification = new System.Windows.Forms.GroupBox();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.txtNumClient = new System.Windows.Forms.TextBox();
            this.lblRaisonSoc = new System.Windows.Forms.Label();
            this.txtRaisonSoc = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtAdresse2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.grpCaracteristique = new System.Windows.Forms.GroupBox();
            this.ChbPrive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.cbxActivite = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpIdentification.SuspendLayout();
            this.grpCaracteristique.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIdentification
            // 
            this.grpIdentification.Controls.Add(this.txtTelephone);
            this.grpIdentification.Controls.Add(this.lblTelephone);
            this.grpIdentification.Controls.Add(this.txtVille);
            this.grpIdentification.Controls.Add(this.txtCodePostal);
            this.grpIdentification.Controls.Add(this.label1);
            this.grpIdentification.Controls.Add(this.txtAdresse2);
            this.grpIdentification.Controls.Add(this.txtAdresse);
            this.grpIdentification.Controls.Add(this.lblAdresse);
            this.grpIdentification.Controls.Add(this.txtRaisonSoc);
            this.grpIdentification.Controls.Add(this.lblRaisonSoc);
            this.grpIdentification.Controls.Add(this.txtNumClient);
            this.grpIdentification.Controls.Add(this.lblNumClient);
            this.grpIdentification.Location = new System.Drawing.Point(28, 18);
            this.grpIdentification.Name = "grpIdentification";
            this.grpIdentification.Size = new System.Drawing.Size(627, 239);
            this.grpIdentification.TabIndex = 0;
            this.grpIdentification.TabStop = false;
            this.grpIdentification.Text = "Identification";
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(26, 34);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(79, 13);
            this.lblNumClient.TabIndex = 1;
            this.lblNumClient.Text = "Numéro Client :";
            // 
            // txtNumClient
            // 
            this.txtNumClient.Location = new System.Drawing.Point(121, 31);
            this.txtNumClient.Name = "txtNumClient";
            this.txtNumClient.Size = new System.Drawing.Size(100, 20);
            this.txtNumClient.TabIndex = 2;
            // 
            // lblRaisonSoc
            // 
            this.lblRaisonSoc.AutoSize = true;
            this.lblRaisonSoc.Location = new System.Drawing.Point(21, 72);
            this.lblRaisonSoc.Name = "lblRaisonSoc";
            this.lblRaisonSoc.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSoc.TabIndex = 3;
            this.lblRaisonSoc.Text = "Raison Sociale :";
            // 
            // txtRaisonSoc
            // 
            this.txtRaisonSoc.Location = new System.Drawing.Point(121, 69);
            this.txtRaisonSoc.Name = "txtRaisonSoc";
            this.txtRaisonSoc.Size = new System.Drawing.Size(344, 20);
            this.txtRaisonSoc.TabIndex = 4;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(54, 112);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(121, 109);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(344, 20);
            this.txtAdresse.TabIndex = 6;
            // 
            // txtAdresse2
            // 
            this.txtAdresse2.Location = new System.Drawing.Point(121, 144);
            this.txtAdresse2.Name = "txtAdresse2";
            this.txtAdresse2.Size = new System.Drawing.Size(344, 20);
            this.txtAdresse2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code Postal & Ville :";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(121, 173);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(85, 20);
            this.txtCodePostal.TabIndex = 9;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(234, 173);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(231, 20);
            this.txtVille.TabIndex = 10;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(41, 211);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 11;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(121, 208);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(188, 20);
            this.txtTelephone.TabIndex = 12;
            // 
            // grpCaracteristique
            // 
            this.grpCaracteristique.Controls.Add(this.cbxNature);
            this.grpCaracteristique.Controls.Add(this.lblNature);
            this.grpCaracteristique.Controls.Add(this.cbxActivite);
            this.grpCaracteristique.Controls.Add(this.lblActivite);
            this.grpCaracteristique.Controls.Add(this.txtCA);
            this.grpCaracteristique.Controls.Add(this.label3);
            this.grpCaracteristique.Controls.Add(this.txtEffectif);
            this.grpCaracteristique.Controls.Add(this.label2);
            this.grpCaracteristique.Controls.Add(this.ChbPrive);
            this.grpCaracteristique.Location = new System.Drawing.Point(30, 272);
            this.grpCaracteristique.Name = "grpCaracteristique";
            this.grpCaracteristique.Size = new System.Drawing.Size(624, 131);
            this.grpCaracteristique.TabIndex = 13;
            this.grpCaracteristique.TabStop = false;
            this.grpCaracteristique.Text = "Caractéristiques";
            // 
            // ChbPrive
            // 
            this.ChbPrive.AutoSize = true;
            this.ChbPrive.Location = new System.Drawing.Point(11, 29);
            this.ChbPrive.Name = "ChbPrive";
            this.ChbPrive.Size = new System.Drawing.Size(50, 17);
            this.ChbPrive.TabIndex = 14;
            this.ChbPrive.Text = "&Privé";
            this.ChbPrive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Effectif :";
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(86, 55);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(100, 20);
            this.txtEffectif.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CA :";
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(288, 55);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(83, 20);
            this.txtCA.TabIndex = 18;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(22, 95);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 19;
            this.lblActivite.Text = "Activité :";
            // 
            // cbxActivite
            // 
            this.cbxActivite.FormattingEnabled = true;
            this.cbxActivite.Location = new System.Drawing.Point(86, 92);
            this.cbxActivite.Name = "cbxActivite";
            this.cbxActivite.Size = new System.Drawing.Size(118, 21);
            this.cbxActivite.TabIndex = 20;
            this.cbxActivite.Text = "Administration";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(237, 95);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 21;
            this.lblNature.Text = "Nature :";
            // 
            // cbxNature
            // 
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Location = new System.Drawing.Point(288, 92);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(83, 21);
            this.cbxNature.TabIndex = 22;
            this.cbxNature.Text = "Ancienne";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(270, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(351, 415);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(75, 23);
            this.btnContacts.TabIndex = 24;
            this.btnContacts.Text = "&Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(432, 415);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNvxClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpCaracteristique);
            this.Controls.Add(this.grpIdentification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNvxClient";
            this.Text = "Saisie Nouveau Client";
            this.grpIdentification.ResumeLayout(false);
            this.grpIdentification.PerformLayout();
            this.grpCaracteristique.ResumeLayout(false);
            this.grpCaracteristique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentification;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresse2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtRaisonSoc;
        private System.Windows.Forms.Label lblRaisonSoc;
        private System.Windows.Forms.TextBox txtNumClient;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.GroupBox grpCaracteristique;
        private System.Windows.Forms.CheckBox ChbPrive;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxActivite;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.ComboBox cbxNature;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnAnnuler;
    }
}