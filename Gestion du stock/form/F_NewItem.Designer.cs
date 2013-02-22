namespace Gestion_du_stock
{
    partial class F_NewItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NewItem));
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.DGV_Equipment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Items
            // 
            this.DGV_Items.AllowUserToOrderColumns = true;
            this.DGV_Items.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Items.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Location = new System.Drawing.Point(0, 0);
            this.DGV_Items.MultiSelect = false;
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Items.Size = new System.Drawing.Size(484, 242);
            this.DGV_Items.TabIndex = 0;
            this.DGV_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Items_CellClick);
            this.DGV_Items.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Items_CellEndEdit);
            this.DGV_Items.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Items_CellEnter);
            // 
            // DGV_Equipment
            // 
            this.DGV_Equipment.AllowUserToOrderColumns = true;
            this.DGV_Equipment.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.DGV_Equipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Equipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Equipment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Equipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Equipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Equipment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Equipment.Location = new System.Drawing.Point(3, 16);
            this.DGV_Equipment.MultiSelect = false;
            this.DGV_Equipment.Name = "DGV_Equipment";
            this.DGV_Equipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Equipment.Size = new System.Drawing.Size(273, 183);
            this.DGV_Equipment.TabIndex = 1;
            this.DGV_Equipment.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Equipment_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DGV_Equipment);
            this.groupBox1.Location = new System.Drawing.Point(193, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Scanner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Save.Location = new System.Drawing.Point(12, 416);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(175, 34);
            this.B_Save.TabIndex = 4;
            this.B_Save.Text = "Enregistrer";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(103, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Inventaire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(12, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Gestion_du_stock.Properties.Resources.camion;
            this.pictureBox1.Location = new System.Drawing.Point(12, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // F_NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_Items);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "F_NewItem";
            this.ShowInTaskbar = false;
            this.Text = "F_NewItem";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_NewItem_FormClosing);
            this.Load += new System.EventHandler(this.F_NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource stockEntitiesBindingSource;
        private System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.DataGridView DGV_Equipment;
        private System.Windows.Forms.BindingSource stockEntitiesBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}