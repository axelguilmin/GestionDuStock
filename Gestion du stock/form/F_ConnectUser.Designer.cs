namespace Gestion_du_stock
{
    partial class F_ConnectUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ConnectUser));
            this.B_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Connect = new System.Windows.Forms.Button();
            this.CB_StayConnected = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.ST_Error = new System.Windows.Forms.StatusStrip();
            this.L_Error = new System.Windows.Forms.ToolStripStatusLabel();
            this.ST_Error.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(11, 82);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(60, 26);
            this.B_Cancel.TabIndex = 17;
            this.B_Cancel.Text = "Annuler";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rester connecté ?";
            // 
            // B_Connect
            // 
            this.B_Connect.Location = new System.Drawing.Point(77, 82);
            this.B_Connect.Name = "B_Connect";
            this.B_Connect.Size = new System.Drawing.Size(168, 26);
            this.B_Connect.TabIndex = 15;
            this.B_Connect.Text = "Se connecter";
            this.B_Connect.UseVisualStyleBackColor = true;
            this.B_Connect.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // CB_StayConnected
            // 
            this.CB_StayConnected.AutoSize = true;
            this.CB_StayConnected.Location = new System.Drawing.Point(230, 62);
            this.CB_StayConnected.Name = "CB_StayConnected";
            this.CB_StayConnected.Size = new System.Drawing.Size(15, 14);
            this.CB_StayConnected.TabIndex = 14;
            this.CB_StayConnected.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(93, 10);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(152, 20);
            this.TB_Login.TabIndex = 10;
            // 
            // TB_Password
            // 
            this.TB_Password.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TB_Password.Location = new System.Drawing.Point(93, 36);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(152, 20);
            this.TB_Password.TabIndex = 11;
            // 
            // ST_Error
            // 
            this.ST_Error.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.L_Error});
            this.ST_Error.Location = new System.Drawing.Point(0, 120);
            this.ST_Error.Name = "ST_Error";
            this.ST_Error.Size = new System.Drawing.Size(254, 22);
            this.ST_Error.TabIndex = 18;
            this.ST_Error.Text = " Coucou";
            // 
            // L_Error
            // 
            this.L_Error.Name = "L_Error";
            this.L_Error.Size = new System.Drawing.Size(0, 17);
            // 
            // F_ConnectUser
            // 
            this.AcceptButton = this.B_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_Cancel;
            this.ClientSize = new System.Drawing.Size(254, 142);
            this.ControlBox = false;
            this.Controls.Add(this.ST_Error);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_Connect);
            this.Controls.Add(this.CB_StayConnected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 180);
            this.MinimumSize = new System.Drawing.Size(270, 180);
            this.Name = "F_ConnectUser";
            this.ShowInTaskbar = false;
            this.Text = "F_ConnectUser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.F_ConnectUser_Load);
            this.ST_Error.ResumeLayout(false);
            this.ST_Error.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.CheckBox CB_StayConnected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.StatusStrip ST_Error;
        private System.Windows.Forms.ToolStripStatusLabel L_Error;
    }
}