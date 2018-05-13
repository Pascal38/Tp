using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TpB2B
{
    /// <summary>
    /// classe générale des données à gérer
    /// --------------------------------------
    /// classe qui regroupe les données de l'application de gestion
    /// des client dans une collection d'objet en static (= on instantiable)
    /// </summary>
    class Donnees
    {
        /// <summary>
        /// collection d'objet Client
        /// </summary>
        public static ArrayList ArrayClient = new ArrayList(); //directive using collections non présent
    }
}
