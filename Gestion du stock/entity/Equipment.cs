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
    public partial class Equipment : EntityObject
    {
        public override string ToString()
        {
            return this.name;
        }
    }
}
