using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_du_stock
{
    public partial class F_Users : Form
    {
        private Account user;
        public F_Users()
        {
            InitializeComponent();
        }

        private void F_Users_Load(object sender, EventArgs e)
        {       
            this.LV_Users.Columns[0].Width = 0;
            this.LV_Users.Columns[1].Width = -2; // -2 : remplir le reste

            var query = DataBase.context.Accounts.OrderBy(i => i.login) ;
            foreach (Account user in query)
                this.LV_Users.Items.Insert(0, new ListViewItem(new String[2] { user.id.ToString(), user.login}, this.LV_Users.Groups[0]));
        }

        private void LV_Users_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.LV_Users.SelectedItems.Count != 0)
            {
                long id = int.Parse(LV_Users.SelectedItems[0].SubItems[0].Text);
                this.GB_User.Visible = true;
                this.user = DataBase.context.Accounts.Where(a => a.id == id).First();
                this.TB_login.Text = user.login;
                this.TB_password.Text = user.password;
                this.CB_comptes.Checked = user.Can_edit_account;
                this.CB_stock.Checked = user.Can_edit_stock;
                // Compte verouillé
                if (this.user.locked == 1)
                {
                    this.CB_comptes.Enabled = false;
                    this.CB_stock.Enabled = false;
                    this.B_Supprimer.Enabled = false;
                }
                else
                {
                    this.CB_comptes.Enabled = true;
                    this.CB_stock.Enabled = true;
                    this.B_Supprimer.Enabled = true;
                }
            }
            else
            {
                this.GB_User.Visible = false;
            }
        }

        private void B_Supprimer_Click(object sender, EventArgs e)
        {
            if (Message.Comfirm("Vraiment supprimer l'utilisateur " + this.user.login + " ?"))
            {
                DataBase.context.DeleteObject(this.user);
                DataBase.context.SaveChanges();
                this.bindData();
            }
        }

        private void B_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.user.login = TB_login.Text;
                this.user.password = TB_password.Text;
                this.user.Can_edit_account = CB_comptes.Checked;
                this.user.Can_edit_stock = CB_stock.Checked;
                if (this.LV_Users.SelectedItems.Count == 0)
                    DataBase.context.AddToAccounts(this.user);
                DataBase.context.SaveChanges();
                // maj affichage
                this.bindData();
            }
            catch (DataException ex)
            {
                Message.Say(ex.Message);
            }            
        }

        private void B_Annuler_Click(object sender, EventArgs e)
        {
            this.bindData();
        }

        private void B_Nouveau_Click(object sender, EventArgs e)
        {
            this.user = new Account() ;
           
            this.LV_Users.SelectedItems.Clear();
            this.GB_User.Visible = true;
            this.TB_login.Text = "Nouvel utilisateur";
            this.TB_password.Text = "";
            this.CB_comptes.Checked = false;
            this.CB_stock.Checked = false;
            this.CB_comptes.Enabled = true;
            this.CB_stock.Enabled = true;
            this.B_Supprimer.Enabled = false;
        }

        private void bindData()
        {
            this.GB_User.Visible = false;
            this.LV_Users.Items.Clear();
            this.F_Users_Load(this, null);
        }

        private void F_Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.ReturnToAccueil();
        }

    }
}
