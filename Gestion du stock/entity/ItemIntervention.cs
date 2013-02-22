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
    public partial class ItemIntervention : EntityObject
    {
        /// <summary>
        /// Verifier qu'un item peut bien etre ajouté a une intervention
        /// </summary>
        /// <returns>true si ok, false sinon</returns>
        partial void OnidItemChanging(global::System.Int64 idItem)
        {
          
        }

    }
}
