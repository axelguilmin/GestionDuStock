using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_du_stock
{
    public class User // Singleton
    {
        private Account connectedUser;
        private bool stayConnected;
        public bool StayConnected()
        {
            return stayConnected;
        }
        private static User instance;
        private User() { }
        public bool Login(String login, String password, bool stayConnected)
        {
            this.Logout();
            var account = DataBase.context.Accounts.Where(a => a.login == login && a.password == password);

            if (account.Count() == 0)
            {
                return false;
            }
            else
            {
                // Mémoriser si on veux rester connecter
                this.stayConnected = stayConnected;
                this.connectedUser = account.First();
                return true;
            }
        }
        public void Logout()
        {
            this.connectedUser = null;
            this.stayConnected = false;
        }
        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }

        public bool Edit_stock()
        {
            if (connectedUser != null && !connectedUser.Can_edit_stock)
                Message.Say("L'accès à cette partie du logiciel vous est interdite");
            // Tester si un User est mémorisé et peut faire cette action
            return (connectedUser != null && connectedUser.Can_edit_stock);
        }

        public bool Edit_account()
        {
            if (connectedUser != null && !connectedUser.Can_edit_account)
                Message.Say("L'accès à cette partie du logiciel vous est interdite");
            return (connectedUser != null && connectedUser.Can_edit_account);
        }
        override public String ToString()
        {
            if (this.connectedUser == null)
                return "Aucun utilisateur connecté";
            else
                return "Utilsateur connecté : " + connectedUser.login;
        }
    }
}
