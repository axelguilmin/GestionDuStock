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
    public partial class F_ConnectUser : Form
    {
        public F_ConnectUser(bool CB_stayConnectedDefaultValue)
        {
            InitializeComponent();
            this.CB_StayConnected.Checked = CB_stayConnectedDefaultValue;
        }
        private void B_Connect_Click(object sender, EventArgs e)
        {
            if (User.Instance.Login(this.TB_Login.Text, this.TB_Password.Text,this.CB_StayConnected.Checked))
                this.Close();
            else
                this.L_Error.Text = "Mauvais Nom ou Mot de passe";
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Forms.ReturnToAccueil();
            this.Close();
        }

        private void F_ConnectUser_Load(object sender, EventArgs e)
        {

        }

    }
}
