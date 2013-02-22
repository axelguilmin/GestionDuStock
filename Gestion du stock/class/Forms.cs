using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Reflection;

namespace Gestion_du_stock
{
    class Forms
    {
        private static F_Accueil _F_Accueil { get; set; }
        private static F_Users _F_Users { get; set; }
        private static F_NewItem _F_NewItem { get; set; }
        private static F_About _F_About { get; set; }
        private static F_ConnectUser _F_ConnectUser { get; set; }

        public static void Start()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            Forms._F_Accueil = new F_Accueil();
            Application.Run(Forms._F_Accueil);
            Forms._F_Accueil.Text = Forms._F_Accueil.ProductName;
        }

        public static void ShowAbout()
        {
            Forms._F_Accueil.Enabled = false;
            Forms._F_About = new F_About();
            Forms._F_About.Show();
            Forms._F_About.Text = "A Propos - " + Forms._F_About.ProductName;
        }
        public static void ShowNewItem()
        {
            // L'utilisateur doit avoir le droit "can_edit_stock"
            if (!User.Instance.Edit_stock())
                // Sinon on lui demande de se connecter
                Forms.ConnectUser();
            if (User.Instance.Edit_stock())
            {
                // Bloquer le formulaire principal
                Forms._F_Accueil.Enabled = false;
                Forms._F_NewItem = new F_NewItem();
                Forms._F_NewItem.Show();
                Forms._F_NewItem.Text = "Gérer le matériel - " + Forms._F_NewItem.ProductName;
            }
        }
        public static void ShowUsers()
        {
            // L'utilisateur doit avoir le droit "can_edit_stock"
            if (!User.Instance.Edit_account())
                // Sinon on lui demande de se connecter
                Forms.ConnectUser();
            if (User.Instance.Edit_account())
            {
                // Bloquer le formulaire principal
                Forms._F_Accueil.Enabled = false;
                Forms._F_Users = new F_Users();
                Forms._F_Users.Show();
                Forms._F_Users.Text = "Gérer les utilisateurs - " + Forms._F_Users.ProductName;
            }
        }
        /// <summary>
        /// Retour au formulaire principal
        /// </summary>
        public static void ReturnToAccueil()
        {
            // Déconnecter automatiquement l'utilisateur s'il ne souhaite pas rester co
            if (!User.Instance.StayConnected())
                User.Instance.Logout();
            Forms._F_Accueil.Enabled = true;
        }

        public static void ConnectUser(bool CB_stayConnectedDefaultValue = false)
        {
            Forms._F_ConnectUser = new F_ConnectUser(CB_stayConnectedDefaultValue);
            // Show dialog attend que le form soit fermé pour continuer
            Forms._F_ConnectUser.Text = "Se connecter - " + Forms._F_ConnectUser.ProductName;
            Forms._F_ConnectUser.ShowDialog();            
        }
    }
}
