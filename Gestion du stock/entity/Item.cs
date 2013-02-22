using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// From Entity
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Gestion_du_stock
{
    public partial class Item : EntityObject
    {
        partial void OnstateChanging(global::System.Int64 value)
        {
            if (value < E_ItemState.bought || value > E_ItemState.trashed)
                throw new DataException("Valeur inconnue dans l'énumeration EnumCheckingState");
        }

        /// <summary>
        /// Vérifier si un objet est toujours utilisable
        /// </summary>
        /// <param name="why">motif de refus / acceptation</param>
        /// <returns>false s'il doit etre jeté</returns>
        public bool ShloudBeTrashed(out String why)
        {
            if (this.state == E_ItemState.bought)
                if (this.Equipment.maxUses != null &&
                      this.ItemInterventions.Count(a => a.used == 1) > this.Equipment.maxUses)
                {
                    why = "Cet objet a été utilisé plus de " + this.Equipment.maxUses + " fois";
                    return true;
                }
                else if (this.expiryDate != null &&
                     DateTime.Now > DataBase.TimestampToDateTime(this.expiryDate))
                {
                    why = "Cet objet est trop vieux";
                    return true;
                }
            why = "Cet objet est utilisable";
            return false;
        }
    }
    /// <summary>
    /// Enumeration définissant l'état d'un Item
    /// </summary>
    /// C'est en fait une classe pour ne pas avoir a caster quand on veut enregistrer en bdd
    public static class E_ItemState
    {
        /// <summary>
        /// Objet acheté, il est possible de l'utiliser
        /// </summary>
        public const long bought = 0;
        /// <summary>
        /// Objet perdu
        /// </summary>
        public const long lost = 1;
        /// <summary>
        /// Objet jeté, car périmé ou cassé
        /// </summary>
        public const long trashed = 2;


    }
}
