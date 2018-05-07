using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpB2B
{
    ///<summary>
    /// classe des stagiaires :
    /// permet de mémoriser les informations concernant le clients
    /// comporte des membres propriétés et attributs
    /// et le nombre de stagiaires,
    /// donnée partagée par toutes les instances (==> static)
    /// </summary> 
    public class MClients
    {
        /// <summary>
        /// nombre de Numéro client
        /// (donnée partagée par toutes les instances)
        /// </summary>
        public static Int32 Nstag;

        /// <summary>
        /// obtient le numéro du client
        /// </summary>
        private Int32 numClient;

        /// <summary>
        /// numéro client,
        /// l'appelant devra prendre garde à passer un entier valide
        /// </summary>
        public Int32 NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }

        /// <summary>
        /// la raison sociale
        /// </summary>
        private String nomClient;

        /// <summary>
        /// obtient ou définit le nom du stagiaire (forcé en majuscules)
        /// </summary>
        public String Nom
        {
            // en lecture, retourne la var privée
            get { return this.nomClient; }
            // cette portion de code sert à l’affectation d’une nouvelle valeur ;
            // c’est ici que l’on effectue des contrôles de saisie
            // ou des transformations (ici : mettre le nom en majuscules) 
            set { this.nomClient = value.Trim().ToUpper(); } // mettre le nom en majuscules
        }
        /// <summary>
        /// le prénom de stagiaire
        /// </summary>
        private String activiteClient;
        /// <summary>
        /// obtient ou définit le prénom de stagiaire (forcé en minuscules)
        /// </summary>
        public String Activite
        {
            get { return activiteClient; } // en lecture, retourne la var privée
            set { activiteClient = value.Trim().ToLower(); } // mettre le prénom en minuscules
        }
        /// <summary>
        /// immeuble, rue et numéro, le format est libre
        /// </summary>
        private String natureClient;
        /// <summary>
        /// obtient ou définit immeuble, rue et numéro, le format est libre
        /// </summary>
        public String Nature
        {
            get { return Nature; }
            set { Nature = value; }
        }

        /// <summary>
        /// le nom de la ville
        /// </summary>
        private String villeClient;
        /// <summary>
        /// obtient ou définit le nom de la ville (forcé en majuscules)
        /// </summary>
        public String Ville
        {
            get { return villeClient; } // en lecture, retourne la var privée
            set { villeClient = value.Trim().ToUpper(); } // mettre la ville en majuscules
        }
        /// <summary>
        /// le code postal, l'appelant devra prendre garde à passer
        /// un code postal valide à 5 chiffres
        /// </summary>
        private String codePostalStagiaire;

        /// <summary>
        /// obtient ou définit le code postal (contrôle : 5 car, tous chiffres)
        /// </summary>
        /// <exception cref="Exception">Si code postal non valide</exception>
        public String CodePostal
        {
            get { return codePostalStagiaire; } // en lecture, retourne la var privée 
            set
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i; // variable de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 5) // 5 car. attendus : OK ==> contrôler un à un
                {
                    for (i = 0; i < value.Length; i++) // controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }
                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // première solution par simple messagebox
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n"
                        + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MClients",
                        System.Windows.Forms.MessageBoxButtons.OK);

                        //2° solution par levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un Code Postal valide : Uniquement en chiffre");
                    }
                    else
                    {
                        codePostalStagiaire = value; // tout est bon, on affecte la propriété
                    }
                }
                else // il n'y a pas 5 caractères
                {
                    // première solution par simple messagebox
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                   "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "ErreurClasse MClients",
                   System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }

    }
}
