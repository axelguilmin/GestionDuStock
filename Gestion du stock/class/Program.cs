using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;

namespace Gestion_du_stock
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DataBase.Truncate();
            //DataBase.InsertTestDataSet();
            Forms.Start();
        }
        public static void Exit()
        {
            Application.Exit();
        }
    }
}
