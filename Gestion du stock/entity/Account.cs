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
    public partial class Account : EntityObject
    {
       partial void OnloginChanging(string value)
        {
            if (value.Length < 2)
                throw new DataException("Les nom d'utilisateur doivent contenir au moins 2 caractères");
           // Tester si ce pseudo existe déjà
           if(DataBase.context.Accounts.Where(a => a.login == value && a.id != this.id).Count() > 0)
               throw new DataException("Ce nom d'utilisateur existe déjà");
        }

        partial void Oncan_edit_accountChanging(long value)
        {
            if (this._locked == 1 && value != 1)
                throw new DataException("Impossible de modifier les droits d'un compte vérouillé");
        }
    
        partial void Oncan_edit_stockChanging(long value)
        {
            if (this._locked == 1 && value != 1)
                throw new DataException("Impossible de modifier les droits d'un compte vérouillé");
        }

        partial void OnpasswordChanging(string value)
        {
            if (value.Length < 2)
                throw new DataException("Les mot de passes doivent contenir au moins 2 caractères");
        }

        // Mapping bool <=> int en bdd
        public bool Can_edit_stock
        {
            get
            {
                return this.can_edit_stock != 0;
            }
            set
            {
                if (value)
                    this.can_edit_stock = 1;
                else
                    this.can_edit_stock = 0;
            }
        }

        public bool Can_edit_account
        {
            get
            {
                return this.can_edit_account != 0;
            }
            set
            {
                if (value)
                    this.can_edit_account = 1;
                else
                    this.can_edit_account = 0;
            }
        }
    }
}
