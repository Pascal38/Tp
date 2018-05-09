using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpB2B
{
    /// <summary>
    /// Classe des stagiaires : permet de mémoriser les informations concernant un client
    /// comporte des membres propriétés et attributs
    /// et le nombre des client donnée partagée par toutes les instances (==>Static)
    /// </summary>
    class MInfClients
    {

        /// <summary>
        /// Nombre de clients de la classe
        /// (donnée partagée par toutes les instances
        /// </summary>
        public static Int32 Nclients;
        /// <summary>
        /// obtient le numéro du client
        /// </summary>
        private Int32 numClient;
        /// <summary>
        /// numéro du client,
        /// l'appelant devra prendra garde à passer un entier valide
        /// </summary>
        public Int32 NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }
        /// <summary>
        /// obtient la raison sociale du client
        /// </summary>
        private String raisonSociale;
        /// <summary>
        /// raison sociale du client,
        /// </summary>
        public String RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }

        /// <summary>
        /// immeuble, rue et numéro, le format est libre
        /// </summary>
        private String rue;
        /// <summary>
        /// obtient ou définit immeuble, rue et numéro, le format est libre
        /// </summary>
        public String Rue
        {
            get { return this.rue; }
            set { this.rue = value; }
        }

        /// <summary>
        /// le nom de la ville
        /// </summary>
        private String villeClient;
        /// <summary>
        /// obtient ou définit le nom de la ville (forcé en Majuscule)
        /// </summary>
        public String Ville
        {
            get { return this.villeClient; }
            set { this.villeClient = value.Trim().ToUpper(); } //mettre la ville en majsucule
        }

        /// <summary>
        /// le code postal, l'appelant devra prendre garde à passer
        /// un code postal valide à 5 chiffres
        /// </summary>
        private String codePostaleClient;
        /// <summary>
        /// obtient ou définit le code postal (contrôle : 5 car, tous chiffres)
        /// </summary>
        /// <exception cref="Exception">Si code postal non valide</exception>
        public String CodePostale
        {
            get { return this.codePostaleClient; }
            set
            {
                Int32 i;
                Boolean erreur = false;
                if (value.Length == 5)
                {
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }
                    }//fin du boucle contrôle chriffres
                    if (erreur) //on a rencontre un non-chriffre
                    {
                        //1ère solution par simple messagebox
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide " +
                            ": uniquement des chiffres", "Erreur Classe MInfClients"
                            , System.Windows.Forms.MessageBoxButtons.OK);
                        //2ème Solution par levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : " +
                            "uniquement des chiffres");
                    }
                    else
                    {
                        codePostaleClient = value; //Tout est bon, on affecte la propriété
                    }
                }
                else
                {
                    //1ère Solution par simple messagebox
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal: " +
                        "5 chiffres pas +, pas -", "Erreur de Classe MInfClients",
                        System.Windows.Forms.MessageBoxButtons.OK);
                }

            }
        }

        /// <summary>
        /// le Téléphone du client, l'appelant devra prendre garde à passer
        /// un numéro valide à 10 chiffres
        /// </summary>
        private String telephoneClient;
        /// <summary>
        /// obtient ou définit le téléphone (contrôle : 10 car, tous chiffres)
        /// </summary>
        /// <exception cref="Exception">Si code postal non valide</exception>
        public String TelephoneClient
        {
            get { return this.telephoneClient; }
            set
            {
                Int32 i;
                Boolean erreur = false;
                if (value.Length == 10)
                {
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }
                    }//fin du boucle contrôle chriffres
                    if (erreur) //on a rencontre un non-chriffre
                    {
                        //1ère solution par simple messagebox
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un numéro de téléphone valide " +
                            ": uniquement des chiffres", "Erreur Classe MInfClients"
                            , System.Windows.Forms.MessageBoxButtons.OK);
                        //2ème Solution par levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un numéro de téléphone valide : " +
                            "uniquement des chiffres");
                    }
                    else
                    {
                        telephoneClient = value; //Tout est bon, on affecte la propriété
                    }
                }
                else
                {
                    //1ère Solution par simple messagebox
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un numéro de téléphone: " +
                        "5 chiffres pas +, pas -", "Erreur de Classe MInfClients",
                        System.Windows.Forms.MessageBoxButtons.OK);
                }

            }
        }

        /* Contacts Clients*/
        /// <summary>
        /// Nom du client
        /// </summary>
        private String nomClient;
        /// <summary>
        /// obtient ou définit le nom du stagiaire (forcé en Majuscute)
        /// </summary>
        public String Nom
        {
            get { return this.nomClient; }
            set { this.nomClient = value.Trim().ToUpper(); }//mettre le nom en Majuscule
        }
        /// <summary>
        /// Prenom du Client
        /// </summary>
        private String prenomClient;
        /// <summary>
        /// obtient ou définit le prénom du client (force en miniscule)
        /// </summary>
        public string Prenom
        {
            get { return this.prenomClient; }
            set { this.prenomClient = value.Trim().ToLower(); }//mettre le prénom en minuscule
        }
        /// <summary>
        /// Email du client
        /// </summary>
        private String emailClient;
        /// <summary>
        /// obtient ou définit l'email du client
        /// </summary>
        public String EmailClient
        {
            get { return this.emailClient; }
            set { this.emailClient = value; } //il faut un contrôle de validité
        }
        /// <summary>
        /// Fonction du contact client
        /// </summary>
        private String fonctionClient;
        /// <summary>
        /// obtient ou définit la fonction du contact client
        /// </summary>
        public String FonctionClient
        {
            get { return this.fonctionClient; }
            set { this.fonctionClient = value; }
        }
        /// <summary>
        /// le type du client (public, privé)
        /// </summary>
        private String typeClient;
        /// <summary>
        /// obtient ou définit le type client
        /// </summary>
        public String TypeClient
        {
            get { return this.typeClient; }
            set { this.typeClient = value; }
        }
        /// <summary>
        /// l'effectif du client
        /// </summary>
        private Int32 effectifClient;
        /// <summary>
        /// obtient ou définit l'effectif client
        /// </summary>
        public Int32 EffectifClient
        {
            get { return this.effectifClient; }
            set { this.effectifClient = value; }
        }
        /// <summary>
        /// le chiffre d'affaire client
        /// </summary>
        private Int32 chiffreAffaireClient;
        /// <summary>
        /// obtient ou définit le chiffre d'affaire du client
        /// </summary>
        public Int32 ChiffreAffaireClient
        {
            get { return this.chiffreAffaireClient; }
            set { this.chiffreAffaireClient = value; }
        }
        /// <summary>
        /// l'activité du client (agro, industrie,....)
        /// </summary>
        private String activiteClient;
        /// <summary>
        /// obtient ou définit l'activité du client
        /// </summary>
        public String ActiviteClient
        {
            get { return this.activiteClient; }
            set { this.activiteClient = value; }
        }
        /// <summary>
        /// la nature de l'activité du client
        /// </summary>
        private String natureActiviteClient;
        /// <summary>
        /// obtient ou définit la nature de l'activité du client
        /// </summary>
        public String NatureActiviteClient
        {
            get { return this.natureActiviteClient; }
            set { this.natureActiviteClient = value; }
        }



    }//fin classe MInfoClients
}
