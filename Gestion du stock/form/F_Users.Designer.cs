namespace Gestion_du_stock
{
    partial class F_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Utilisateurs", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Users));
            this.B_Annuler = new System.Windows.Forms.Button();
            this.LV_Users = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.CB_stock = new System.Windows.Forms.CheckBox();
            this.CB_comptes = new System.Windows.Forms.CheckBox();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Nouveau = new System.Windows.Forms.Button();
            this.B_Enregistrer = new System.Windows.Forms.Button();
            this.B_Supprimer = new System.Windows.Forms.Button();
            this.GB_User = new System.Windows.Forms.GroupBox();
            this.GB_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Annuler
            // 
            this.B_Annuler.Location = new System.Drawing.Point(6, 213);
            this.B_Annuler.Name = "B_Annuler";
            this.B_Annuler.Size = new System.Drawing.Size(229, 26);
            this.B_Annuler.TabIndex = 1;
            this.B_Annuler.Text = "Annuler";
            this.B_Annuler.UseVisualStyleBackColor = true;
            this.B_Annuler.Click += new System.EventHandler(this.B_Annuler_Click);
            // 
            // LV_Users
            // 
            this.LV_Users.AutoArrange = false;
            this.LV_Users.BackColor = System.Drawing.SystemColors.Control;
            this.LV_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.login});
            this.LV_Users.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LV_Users.FullRowSelect = true;
            listViewGroup1.Header = "Utilisateurs";
            listViewGroup1.Name = "listViewGroup1";
            this.LV_Users.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.LV_Users.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LV_Users.Location = new System.Drawing.Point(3, 37);
            this.LV_Users.MultiSelect = false;
            this.LV_Users.Name = "LV_Users";
            this.LV_Users.Size = new System.Drawing.Size(150, 211);
            this.LV_Users.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LV_Users.TabIndex = 2;
            this.LV_Users.TileSize = new System.Drawing.Size(150, 80);
            this.LV_Users.UseCompatibleStateImageBehavior = false;
            this.LV_Users.View = System.Windows.Forms.View.Details;
            this.LV_Users.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_Users_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // login
            // 
            this.login.Text = "login";
            this.login.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(85, 45);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(150, 20);
            this.TB_password.TabIndex = 5;
            // 
            // CB_stock
            // 
            this.CB_stock.AutoSize = true;
            this.CB_stock.Location = new System.Drawing.Point(119, 109);
            this.CB_stock.Name = "CB_stock";
            this.CB_stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_stock.Size = new System.Drawing.Size(84, 17);
            this.CB_stock.TabIndex = 6;
            this.CB_stock.Text = "Admin stock";
            this.CB_stock.UseVisualStyleBackColor = true;
            // 
            // CB_comptes
            // 
            this.CB_comptes.AutoSize = true;
            this.CB_comptes.Location = new System.Drawing.Point(105, 86);
            this.CB_comptes.Name = "CB_comptes";
            this.CB_comptes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_comptes.Size = new System.Drawing.Size(98, 17);
            this.CB_comptes.TabIndex = 7;
            this.CB_comptes.Text = "Admin comptes";
            this.CB_comptes.UseVisualStyleBackColor = true;
            // 
            // TB_login
            // 
            this.TB_login.Location = new System.Drawing.Point(85, 19);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(150, 20);
            this.TB_login.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nom";
            // 
            // B_Nouveau
            // 
            this.B_Nouveau.Location = new System.Drawing.Point(3, 12);
            this.B_Nouveau.Name = "B_Nouveau";
            this.B_Nouveau.Size = new System.Drawing.Size(150, 26);
            this.B_Nouveau.TabIndex = 13;
            this.B_Nouveau.Text = "Nouveau";
            this.B_Nouveau.UseVisualStyleBackColor = true;
            this.B_Nouveau.Click += new System.EventHandler(this.B_Nouveau_Click);
            // 
            // B_Enregistrer
            // 
            this.B_Enregistrer.Location = new System.Drawing.Point(6, 181);
            this.B_Enregistrer.Name = "B_Enregistrer";
            this.B_Enregistrer.Size = new System.Drawing.Size(229, 26);
            this.B_Enregistrer.TabIndex = 14;
            this.B_Enregistrer.Text = "Enregistrer";
            this.B_Enregistrer.UseVisualStyleBackColor = true;
            this.B_Enregistrer.Click += new System.EventHandler(this.B_Enregistrer_Click);
            // 
            // B_Supprimer
            // 
            this.B_Supprimer.Location = new System.Drawing.Point(6, 149);
            this.B_Supprimer.Name = "B_Supprimer";
            this.B_Supprimer.Size = new System.Drawing.Size(229, 26);
            this.B_Supprimer.TabIndex = 15;
            this.B_Supprimer.Text = "Supprimer";
            this.B_Supprimer.UseVisualStyleBackColor = true;
            this.B_Supprimer.Click += new System.EventHandler(this.B_Supprimer_Click);
            // 
            // GB_User
            // 
            this.GB_User.Controls.Add(this.B_Supprimer);
            this.GB_User.Controls.Add(this.B_Enregistrer);
            this.GB_User.Controls.Add(this.TB_login);
            this.GB_User.Controls.Add(this.label4);
            this.GB_User.Controls.Add(this.CB_comptes);
            this.GB_User.Controls.Add(this.CB_stock);
            this.GB_User.Controls.Add(this.TB_password);
            this.GB_User.Controls.Add(this.label2);
            this.GB_User.Controls.Add(this.B_Annuler);
            this.GB_User.Location = new System.Drawing.Point(159, 5);
            this.GB_User.Name = "GB_User";
            this.GB_User.Size = new System.Drawing.Size(244, 248);
            this.GB_User.TabIndex = 16;
            this.GB_User.TabStop = false;
            this.GB_User.Visible = false;
            // 
            // F_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 255);
            this.Controls.Add(this.GB_User);
            this.Controls.Add(this.B_Nouveau);
            this.Controls.Add(this.LV_Users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 293);
            this.Name = "F_Users";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EditUsers";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Users_FormClosing);
            this.Load += new System.EventHandler(this.F_Users_Load);
            this.GB_User.ResumeLayout(false);
            this.GB_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Annuler;
        private System.Windows.Forms.ListView LV_Users;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.CheckBox CB_stock;
        private System.Windows.Forms.CheckBox CB_comptes;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Nouveau;
        private System.Windows.Forms.Button B_Enregistrer;
        private System.Windows.Forms.Button B_Supprimer;
        private System.Windows.Forms.GroupBox GB_User;
        private System.Windows.Forms.ColumnHeader id;
    }
}