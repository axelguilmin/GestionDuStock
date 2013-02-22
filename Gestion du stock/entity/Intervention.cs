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
    public partial class Intervention : EntityObject
    {
        partial void OncheckingStateChanging(global::System.Int64 value)
        {
            if (value < E_InterventionCheckingState.waiting || value > E_InterventionCheckingState.done)
                throw new DataException("Valeur inconnue dans l'énumeration EnumCheckingState");
        }
        /// <summary>
        /// Ajouter un Item a une intervention
        /// </summary>
        /// <param name="item">L'item a ajouter</param>
        /// <returns>Retourne l'instance de la table d'association a ajouter si réussit</returns>
        public ItemIntervention AddItem(Item item)
        {
            // Vérifier que l'item n'est pas déja utilisé dans cette intervention
            var dejaAjoute = 0 != this.ItemInterventions
                  .Count(a => a.Item.id == item.id) ;

            if (dejaAjoute)
                throw new DataException("Cet objet est déja utilisé dans cette intervetion");

            // L'objet est perdu ou jeté
            if (item.state != (int)E_ItemState.bought)
                throw new DataException("Cet objet a été jeté ou pedu");

            // Objet utilisé dans une autre intervention non finie
            var dejaUtilise = 0 != item.ItemInterventions
                .Where(a => a.Intervention.id != this.id)
                .Count(a => a.Intervention.endedDate == null);
            if (dejaUtilise)
                throw new DataException("Cet objet est en ce moment utilisé dans une autre intervention");

            // Si pas d'erreur ajouter l'item
            return new ItemIntervention()
            {
                Intervention = this,
                Item = item,
                used = null
            };

        }
        /// <summary>
        /// Considere tout les items qui ne sont pas revenu de l'intervention comme perdu / cassés
        /// </summary>
        public void lostItems()
        {
            // Nous devons etre a la bonne étape du checking
            if (this.checkingState != E_InterventionCheckingState.usedAndNotUsedObjectChecked)
            { return; }

            // Les Item non revenu de l'intervention
            var lost = this.ItemInterventions.Where(a => a.used == null);

            // pour chaque on indique la perte
            foreach (ItemIntervention ii in lost)
            {
                Message.Say(ii.Item.Equipment.name + " perdu");
                    ii.Item.state = (int)E_ItemState.lost;
            }
        }
        /// <summary>
        /// Spécifier qu'un objet a été utilisé ou non pendant l'intervention
        /// </summary>
        /// <param name="item">L'item utilisé ou non</param>
        public void checkItem(Item item)
        {
            if (this.checkingState == E_InterventionCheckingState.started)
                this.ItemInterventions.First(a => a.idItem == item.id).used = 1;
            else if (this.checkingState == E_InterventionCheckingState.usedObjectChecked)
                this.ItemInterventions.First(a => a.idItem == item.id).used = 0;
            else if (this.checkingState == E_InterventionCheckingState.usedAndNotUsedObjectChecked) // Materiel cassé / perdu
            {
                this.ItemInterventions.First(a => a.idItem == item.id).used = 1;
                item.state = (int)E_ItemState.lost;
            }
            String motif;
            if (item.ShloudBeTrashed(out motif))
                if (Message.Comfirm(motif + " désirez vous le jeter ?"))
                    item.state = (int)E_ItemState.trashed;

        }
            /// <summary>
        /// Retourne une valeur de 0 à 100 indiquant l'avancement du check fait au retour de l'intervention
        /// </summary>
        /// <returns></returns>
        public int percentageChecked()
        {
            float total = this.ItemInterventions.Count();
            // Ne pas diviser par zero
            if (total == 0) return 100;
            float accompli = this.ItemInterventions
                 .Where(a => a.idIntervention == this.id)
                .Count(a => a.used != null);
            return int.Parse(Math.Round((accompli / total * 100.0F)).ToString());
        }
    }
    /// <summary>
    /// Enumeration définissant l'état du checking fait au retour d'une intervention
    /// </summary>
    /// C'est en fait une classe pour ne pas avoir a caster quand on veut enregistrer en bdd
    public static class E_InterventionCheckingState
    {
        /// <summary>
        /// Listing non fait, valeur par défaut
        /// </summary>
        public const long waiting = 0;
        /// <summary>
        /// Listing commencé
        /// </summary>
        public const long started = 1;
        /// <summary>
        /// Seul les Item utilisé ont été scannés
        /// </summary>
        public const long usedObjectChecked = 2;
        /// <summary>
        /// Tous les Item revenu ont été scannés, il reste a lister les object perdus
        /// </summary>
        public const long usedAndNotUsedObjectChecked = 3;
        /// <summary>
        /// Le listing de retour d'intervention est finit
        /// </summary>
        public const long done = 4;
    }
}
