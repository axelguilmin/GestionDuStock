using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using JThomas.Controls;

namespace Gestion_du_stock
{
    public partial class F_NewItem : Form
    {
        public F_NewItem()
        {
            InitializeComponent();
            this.B_Save.Enabled = false;
        }

        private void F_NewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.ReturnToAccueil();
        }

        private void F_NewItem_Load(object sender, EventArgs e)
        {
            // --- DGV Item
            this.DGV_Items.DataSource = DataBase.context.Items;

            this.DGV_Items.AllowUserToAddRows = true;

            // Cacher l'entete de ligne
            // this.DGV_Items.RowHeadersVisible = false;

            // Renomer les entetes de colonnes


            // Redimentionner automatiquement
            this.DGV_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// DataGridViewAutoSizeColumnsMode.AllCells;

            // Masquer les colonnes inutiles
            this.DGV_Items.Columns["id"].Visible = false;
            this.DGV_Items.Columns["idEquipment"].Visible = false;
            this.DGV_Items.Columns["ItemInterventions"].Visible = false;
            this.DGV_Items.Columns["state"].Visible = false;
            this.DGV_Items.Columns["expiryDate"].Visible = false;
            this.DGV_Items.Columns["buyingDate"].Visible = false;
            this.DGV_Items.Columns["Equipment"].Visible = false;
            this.DGV_Items.Columns["barCode"].Visible = false;
            this.DGV_Items.Columns["serialNumber"].HeaderText = "N° Série";

            // --- DGV Equipment
            this.DGV_Equipment.DataSource = DataBase.context.Equipments;

            this.DGV_Equipment.AllowUserToAddRows = true;

            // Cacher l'entete de ligne
            //  this.DGV_Equipment.RowHeadersVisible = false;

            // Renomer les entetes de colonnes
            this.DGV_Equipment.Columns["name"].HeaderText = "Nom du Type";
            this.DGV_Equipment.Columns["maxUses"].Visible = false;

            // Redimentionner automatiquement
            //    this.DGV_Equipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Masquer les colonnes inutiles
            this.DGV_Equipment.Columns["id"].Visible = false;
            this.DGV_Equipment.Columns["Items"].Visible = false;

            this.addDisplayedColumns();
            this.fillDisplayedColumns();

        }
        private void deleteDisplayedColumns()
        {
            this.DGV_Items.Columns.Remove("Etat");
            this.DGV_Items.Columns.Remove("Type");
            this.DGV_Items.Columns.Remove("Achat");
            this.DGV_Items.Columns.Remove("Peremption");
            this.DGV_Items.Columns.Remove("Code Barre");
        }
        private void addDisplayedColumns()
        {
            // --- Etat ---
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = new String[3] { "en stock", "jeté", "perdu" };
            combo.Name = "Etat";
            combo.HeaderText = "Etat";
            combo.FlatStyle = FlatStyle.Flat;
            this.DGV_Items.Columns.Add(combo);

            // --- Type ----
            DataGridViewComboBoxColumn colType = new DataGridViewComboBoxColumn();
            List<String> DS = new List<String>();
            foreach (var t in DataBase.context.Equipments.GroupBy(a => a.name))
                DS.Add(t.Key);
            colType.DataSource = DS;
            colType.Name = "Type";
            colType.HeaderText = "Type";
            colType.FlatStyle = FlatStyle.Flat;
            this.DGV_Items.Columns.Add(colType);

            // --- Date d'achat --- 
            DataGridViewMaskedTextColumn col = new DataGridViewMaskedTextColumn("00/00/0000");
            col.HeaderText = "Achat";
            col.Name = "Achat";
            this.DGV_Items.Columns.Add(col);

            // --- Date de peremption ---
            DataGridViewMaskedTextColumn col2 = new DataGridViewMaskedTextColumn("00/00/0000");
            col2.HeaderText = "Peremption";
            col2.Name = "Peremption";
            this.DGV_Items.Columns.Add(col2);

            // --- Code Barre ---
            DataGridViewMaskedTextColumn colCode = new DataGridViewMaskedTextColumn("099999");
            colCode.HeaderText = "Code Barre";
            colCode.Name = "CodeBarre";
            this.DGV_Items.Columns.Add(colCode);

            // --- Nombre max d'utilisation ---
            DataGridViewMaskedTextColumn colMax = new DataGridViewMaskedTextColumn("999999");
            colMax.HeaderText = "Nombre max d'utilisation";
            colMax.Name = "max";
            this.DGV_Equipment.Columns.Add(colMax);

        }
        private void fillDisplayedColumns()
        {
            // Pour chaque ligne
            for (var i = 0; i < (this.DGV_Items.RowCount - 1); i++) // rowCount is nb_users + 1 empty line
            {
                // --- Etat ---
                long state = long.Parse(this.DGV_Items.Rows[i].Cells["state"].Value.ToString());
                switch (state)
                {
                    case E_ItemState.bought:
                        this.DGV_Items.Rows[i].Cells["Etat"].Value = "en stock";
                        break;
                    case E_ItemState.lost:
                        this.DGV_Items.Rows[i].Cells["Etat"].Value = "perdu";
                        break;
                    case E_ItemState.trashed:
                        this.DGV_Items.Rows[i].Cells["Etat"].Value = "jeté";
                        break;
                }
                // --- Date de péremption
                var expiryDateTS = this.DGV_Items.Rows[i].Cells["expiryDate"].Value;
                if (expiryDateTS != null)
                    this.DGV_Items.Rows[i].Cells["Peremption"].Value = DataBase.TimestampToDateTime(expiryDateTS.ToString()).ToShortDateString();

                // --- Date d'achat
                String buyingDateTS = this.DGV_Items.Rows[i].Cells["buyingDate"].Value.ToString();
                this.DGV_Items.Rows[i].Cells["Achat"].Value = DataBase.TimestampToDateTime(buyingDateTS).ToShortDateString();

                // --- Type
                this.DGV_Items.Rows[i].Cells["Type"].Value = this.DGV_Items.Rows[i].Cells["Equipment"].Value.ToString();

                // --- Code Barre
                this.DGV_Items.Rows[i].Cells["CodeBarre"].Value = this.DGV_Items.Rows[i].Cells["barCode"].Value.ToString();
            }
                        // Pour chaque ligne
            for (var i = 0; i < (this.DGV_Equipment.RowCount - 1); i++) // rowCount is nb_users + 1 empty line
            {
                // --- Nombre max d'utilisation
                if(this.DGV_Equipment.Rows[i].Cells["maxUses"].Value != null)
                    this.DGV_Equipment.Rows[i].Cells["max"].Value = this.DGV_Equipment.Rows[i].Cells["maxUses"].Value.ToString();
            }
        }

        private void DGV_Items_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.B_Save.Enabled = true;

             // Si c'est un nouveau on met des valeur par défault
            bool NewItem = (e.RowIndex >= this.DGV_Items.Rows.Count -2 );

            // --- Type ---
            try
            {
                var name = this.DGV_Items.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                this.DGV_Items.Rows[e.RowIndex].Cells["Equipment"].Value = (Equipment)DataBase.context.Equipments.Where(a => a.name == name).First();
            }
            catch (Exception) 
            {
                if(!NewItem) Message.Error("Type incorrect");
                if(!NewItem) this.DGV_Items.Rows[e.RowIndex].Cells["Type"].Value = this.DGV_Items.Rows[e.RowIndex].Cells["Equipment"].Value.ToString();
                else this.DGV_Items.Rows[e.RowIndex].Cells["Type"].Value = DataBase.context.Equipments.First().ToString();
            }

            // --- Date de péremption (peut etre null)
            try
            {
                if(this.DGV_Items.Rows[e.RowIndex].Cells["Peremption"].Value.ToString() == "__/__/____")
                {
                          this.DGV_Items.Rows[e.RowIndex].Cells["Peremption"].Value = null;
                        this.DGV_Items.Rows[e.RowIndex].Cells["expiryDate"].Value = null;
                }
                else
                this.DGV_Items.Rows[e.RowIndex].Cells["expiryDate"].Value = DataBase.DateTimeToTimestamp(DateTime.ParseExact(this.DGV_Items.Rows[e.RowIndex].Cells["Peremption"].Value.ToString(), "dd/MM/yyyy", null));
            }
            catch (Exception)
            {
                
                if (this.DGV_Items.Rows[e.RowIndex].Cells["expiryDate"].Value == null)
                {
                    this.DGV_Items.Rows[e.RowIndex].Cells["Peremption"].Value = null;
                    this.DGV_Items.Rows[e.RowIndex].Cells["expiryDate"].Value = null;
                }
                else
                {
                    Message.Error("Date de péremption incorrecte");
                    var expiryDateTS = this.DGV_Items.Rows[e.RowIndex].Cells["expiryDate"].Value;
                    if (expiryDateTS != null)
                        this.DGV_Items.Rows[e.RowIndex].Cells["Peremption"].Value = DataBase.TimestampToDateTime(expiryDateTS.ToString()).ToShortDateString();
                }
            }
            // --- Date d'achat
            try
            {
                this.DGV_Items.Rows[e.RowIndex].Cells["buyingDate"].Value = DataBase.DateTimeToTimestamp(DateTime.ParseExact(this.DGV_Items.Rows[e.RowIndex].Cells["Achat"].Value.ToString(), "dd/MM/yyyy", null));
            }
            catch (Exception)
            {
                if (!NewItem)
                {
                    Message.Error("La Date d'achat incorrecte");
                    String buyingDateTS = this.DGV_Items.Rows[e.RowIndex].Cells["buyingDate"].Value.ToString();
                    this.DGV_Items.Rows[e.RowIndex].Cells["Achat"].Value = DataBase.TimestampToDateTime(buyingDateTS).ToShortDateString();
                }
                else
                {
                    this.DGV_Items.Rows[e.RowIndex].Cells["buyingDate"].Value = DataBase.DateTimeToTimestamp(DateTime.Now);
                    String buyingDateTS = this.DGV_Items.Rows[e.RowIndex].Cells["buyingDate"].Value.ToString();
                    this.DGV_Items.Rows[e.RowIndex].Cells["Achat"].Value = DataBase.TimestampToDateTime(buyingDateTS).ToShortDateString();
                }

            }
            // --- Etat
            if (NewItem && DGV_Items.Rows[e.RowIndex].Cells["Etat"].Value == null)
            {
                this.DGV_Items.Rows[e.RowIndex].Cells["state"].Value = (int)E_ItemState.bought;
                this.DGV_Items.Rows[e.RowIndex].Cells["Etat"].Value = "en stock";
            }
            else
            {

                String state = this.DGV_Items.Rows[e.RowIndex].Cells["Etat"].Value.ToString();
                if (state.CompareTo("en stock") == 0)
                    this.DGV_Items.Rows[e.RowIndex].Cells["state"].Value = (int)E_ItemState.bought;
                else if (state.CompareTo("perdu") == 0)
                    this.DGV_Items.Rows[e.RowIndex].Cells["state"].Value = (int)E_ItemState.lost;
                else if (state.CompareTo("jeté") == 0)
                    this.DGV_Items.Rows[e.RowIndex].Cells["state"].Value = (int)E_ItemState.trashed;
            }
            // --- Code Barre
            try
            {
                int val = int.Parse(this.DGV_Items.Rows[e.RowIndex].Cells["CodeBarre"].Value.ToString().Replace("_",""));
                this.DGV_Items.Rows[e.RowIndex].Cells["barCode"].Value = val.ToString() ;
                this.DGV_Items.Rows[e.RowIndex].Cells["CodeBarre"].Value = val.ToString();
            }
            catch (Exception)
            {
                if (!NewItem)
                {
                    Message.Error("Le Code barre est incorrect");
                    this.DGV_Items.Rows[e.RowIndex].Cells["CodeBarre"].Value = this.DGV_Items.Rows[e.RowIndex].Cells["barCode"].Value.ToString();
                }
                else
                {
                    this.DGV_Items.Rows[e.RowIndex].Cells["CodeBarre"].Value = 0;
                }
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            this.B_Save.Enabled = false;

            this.DGV_Items.EndEdit();
            this.DGV_Items.CommitEdit(DataGridViewDataErrorContexts.Commit);
            this.DGV_Items.Update();
            this.DGV_Items.Invalidate();

            this.DGV_Equipment.EndEdit();
            this.DGV_Equipment.CommitEdit(DataGridViewDataErrorContexts.Commit);
            this.DGV_Equipment.Update();
            this.DGV_Equipment.Invalidate();

            try
            {
                DataBase.context.SaveChanges();
            }
            catch (Exception)
            {
                Message.Error("Erreur lors de l'enregistrement des données");
            }
        }

        private void DGV_Items_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0 && e.RowIndex < this.DGV_Items.Rows.Count          -1)
            {
                // Selectionner le Type correspondant dans l'autre DGV
                String type = this.DGV_Items.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                for (var i = 0; i < (this.DGV_Equipment.RowCount - 1); i++) // rowCount is nb_users + 1 empty line
                {
                    if (this.DGV_Equipment.Rows[i].Cells["name"].Value.ToString() == type)
                    {
                        this.DGV_Equipment.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void DGV_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.DGV_Items.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DGV_Equipment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Si c'est un nouveau on met des valeur par défault
            bool NewEquipment = (e.RowIndex >= this.DGV_Equipment.Rows.Count - 2);

            if (NewEquipment && this.DGV_Equipment.Rows[e.RowIndex].Cells["name"].Value == null)
            {
                this.DGV_Equipment.Rows[e.RowIndex].Cells["name"].Value = "Nouveau";
            }

            if (e.RowIndex != 0 && e.RowIndex < this.DGV_Items.Rows.Count - 1)
            {
                this.B_Save.Enabled = true;
                try
                {
                    String val = this.DGV_Equipment.Rows[e.RowIndex].Cells["max"].Value.ToString().Replace("_", "");

                    this.DGV_Equipment.Rows[e.RowIndex].Cells["maxUses"].Value = val.ToString();
                    this.DGV_Equipment.Rows[e.RowIndex].Cells["max"].Value = val.ToString();
                }
                catch (Exception)
                {
                    if (!NewEquipment)
                    {
                        Message.Error("Nombre max d'utilisation incorret");
                        this.DGV_Equipment.Rows[e.RowIndex].Cells["max"].Value = this.DGV_Equipment.Rows[e.RowIndex].Cells["maxUses"].Value.ToString();
                    }  
                }
            }
            if (NewEquipment)
            {
                //TODO : Mettre à jour la ComboBox Type ...

                //this.deleteDisplayedColumns();
                //this.addDisplayedColumns();
                //this.fillDisplayedColumns();

                //this.DGV_Items.Refresh();
            }
        }
    }
}
