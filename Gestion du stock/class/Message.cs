using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_du_stock
{
    static class Message
    {
        public static void Error(String message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Error(Exception exception)
        {
            if (exception.Message != null)
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool Comfirm(String message)
        {
            return MessageBox.Show(message, "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
        public static bool Comfirm(Exception exception)
        {
            if (exception.Message != null)
                return MessageBox.Show(exception.Message, "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            else
                return false;
        }
        public static void Say(String message)
        {
            MessageBox.Show(message, "Gestion du stock", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public static void Debug(Object item)
        {
            MessageBox.Show(item.ToString());
        }
    }
}
