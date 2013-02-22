using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Gestion_du_stock
{
    public partial class F_Accueil : Form
    {
        /// <summary>
        ///  Object bdd intervention à afficher
        /// </summary>
        private Intervention intervention;
        /// <summary>
        /// Object db pour les requetes
        /// </summary>
        private stockEntities db;
        private bool displayFullHistory = false;
        /// <summary>
        /// Constructeur
        /// </summary>
        public F_Accueil()
        {
            db = new stockEntities();
            InitializeComponent();
        }
        private void Accueil_Load(object sender, EventArgs e)
        {
            this.Panel1DataBind();
            // A l'ouverture on cache le panel contenant les infos sur une intervention
            foreach (Control control in this.SplitContainer.Panel2.Controls)
                control.Visible = false;
            // Redimentioner les listviews
            this.F_Accueil_SizeChanged(this, e);
        }
        private void Panel1DataBind()
        {
            DateTime dateMin;
            // Tronquer l'historique
            if (this.displayFullHistory)
                dateMin = DateTime.MinValue;
            else
                dateMin = DateTime.Now - new System.TimeSpan(7, 0, 0, 0);

            this.LV_Interventions.Items.Clear();
            foreach (Intervention intervention in db.Interventions )
            {
                // Trouver le bon groupe (0 -> En attente, 1 -> En cours, 2 -> A Checker, 3 -> Historique )
                var group = this.LV_Interventions.Groups[0];
                if (intervention.startedDate != null)
                {
                    group = this.LV_Interventions.Groups[1];
                    if (intervention.endedDate != null)
                    {
                        group = this.LV_Interventions.Groups[2];
                        if (intervention.checkingState == E_InterventionCheckingState.done)
                            group = this.LV_Interventions.Groups[3];
                    }
                }
                // Afficher si pas trop vieux ou non historisé
                if (intervention.checkingState != E_InterventionCheckingState.done || DateTime.Compare(DataBase.TimestampToDateTime(intervention.endedDate),dateMin) > 0 )
                {// Colonnes id, name
                    String[] values = new String[2] { intervention.name, intervention.id.ToString() };
                    // Inserer
                    this.LV_Interventions.Items.Insert(0, new ListViewItem(values, group));
                }
            }
            // Si this.intervention existe mais n'es pas selectionné dans le menu de gauche on le selectionne
            if (this.LV_Interventions.SelectedItems.Count == 0 && this.intervention != null)
            {
                foreach (ListViewItem item in this.LV_Interventions.Items)
                {
                    // Si l'id est celui de notre intervention
                    if (item.SubItems[1].Text == this.intervention.id.ToString())
                    {
                        this.LV_Interventions.Items[item.Index].Selected = true;
                    }
                }
            }

        }
        /// <summary>
        /// Réaliser le binding des données d'une intervention
        /// </summary>
        private void Panel2DataBind()
        {
            // Netoyage de l'ecran
            foreach (Control control in this.SplitContainer.Panel2.Controls)
                control.Visible = false;
            this.TB_BarCodeAdd.Text = null;
            this.SC_Button.Visible = true;
            foreach (Control control in this.SC_Button.Panel1.Controls)
                control.Visible = false;
            foreach (Control control in this.SC_Button.Panel2.Controls)
                control.Visible = false;

            this.LV_Items.Items.Clear();

            if (this.intervention != null)
            {
                // Nom
                this.Text = String.Format("Intervention : {0} - {1}", this.intervention.name, this.ProductName);

                // Liste des item
                this.LV_Items.Visible = true;
                this.LV_Items.Enabled = true;
                // Materiel embarqué
                var query = db.Items
                    .Where(i => i.ItemInterventions.Any(itemintervention => itemintervention.Intervention.id == this.intervention.id))
                    .GroupBy(i => i.Equipment.id)
                    .OrderBy(i => i.Key)
                ;
                foreach (IGrouping<Int64, Item> group in query)
                {
                    String[] tab = new String[2] { group.Count().ToString(), group.First().Equipment.name };
                    this.LV_Items.Items.Insert(0, new ListViewItem(tab));
                }

                // Nom de l'intervention            
                this.TB_TitleIntervention.Text = this.intervention.name;
                this.TB_TitleIntervention.Visible = true;
                this.TB_TitleIntervention.ReadOnly = true;
                this.TB_TitleIntervention.BackColor = this.BackColor;
                this.TB_TitleIntervention.ForeColor = this.ForeColor;
                this.TB_TitleIntervention.BorderStyle = BorderStyle.None;

                // Afficher le bouton de fermeture
                this.B_Close.Visible = true;

                // Nouvelle intervention & Intervention en prépa
                if (this.intervention.startedDate == null)
                {
                    // Afficher la liste des Item
                    this.LV_Items.Visible = true;
                    // Afficher la saisie d'un item
                    this.B_AddItem.Visible = true;
                    this.TB_BarCodeAdd.Visible = true;
                    // Afficher le bouton de départ
                    this.B_Departure.Visible = true;
                    // Permettre la mofification du titre
                    this.TB_TitleIntervention.ReadOnly = false;
                    this.TB_TitleIntervention.BackColor = this.TB_BarCodeAdd.BackColor;
                    this.TB_TitleIntervention.ForeColor = this.TB_BarCodeAdd.ForeColor;
                    this.TB_TitleIntervention.BorderStyle = this.TB_BarCodeAdd.BorderStyle;
                    // Permettre la suppression 
                    this.B_DeleteIntervention.Visible = true;
                }
                // Intervention en cours
                else if (this.intervention.endedDate == null)
                {
                    // Afficher la liste des Item
                    this.LV_Items.Visible = true;
                    this.LV_Items.Enabled = false;
                    // Afficher la date de départ
                    this.L_Departure.Text = "Départ : " + DataBase.TimestampToDateTime(this.intervention.startedDate).ToString("dddd dd MMMM yyyy HH:mm");
                    this.L_Departure.Visible = true;
                    // Activer le bouton de retour
                    this.B_ComeBack.Visible = true;
                }
                // Intervention finie, check en cours
                else if (this.intervention.checkingState != E_InterventionCheckingState.done)
                {
                    // Afficher la liste des Item
                    this.LV_Items.Visible = true;
                    this.LV_Items.Enabled = false;
                    // Afficher la date de départ
                    this.L_Departure.Text = "Départ : " + DataBase.TimestampToDateTime(this.intervention.startedDate).ToString("dddd dd MMMM yyyy HH:mm");
                    this.L_Departure.Visible = true;
                    // Afficher la date de retour
                    this.L_ComeBack.Text = "Retour : " + DataBase.TimestampToDateTime(this.intervention.endedDate).ToString("dddd dd MMMM yyyy HH:mm");
                    this.L_ComeBack.Visible = true;
                    // Afficher la saisie de code bar
                    this.TB_BarCodeAdd.Visible = true;
                    this.B_CheckItem.Visible = true;
                    this.L_Chek.Visible = true;
                    // Step dans le check
                    this.L_Chek.ForeColor = Color.Red;
                    switch (this.intervention.checkingState)
                    {
                        case E_InterventionCheckingState.started:
                            this.L_Chek.Text = ">> Scannez le materiel qui a été utilisé durant l'intervention, puis cliquez sur \"Fin\".";             
                            break;
                        case E_InterventionCheckingState.usedObjectChecked:
                            this.L_Chek.Text = ">> Scannez maintenant le materiel qui a n'a pas été utilisé, puis cliquez sur \"Fin\".";
                            break;
                    }
                    this.PB_Check.Visible = true;
                    this.B_Fin.Visible = true;
                    this.PB_Check.Value = this.intervention.percentageChecked();
                }
                else // Finit finit
                {
                    // Afficher la liste des Item
                    this.LV_Items.Visible = true;
                    this.LV_Items.Enabled = false;
                    // Afficher la date de départ
                    this.L_Departure.Text = "Départ : " + DataBase.TimestampToDateTime(this.intervention.startedDate).ToString("dddd dd MMMM yyyy HH:mm");
                    this.L_Departure.Visible = true;
                    // Afficher la date de retour
                    this.L_ComeBack.Text = "Retour : " + DataBase.TimestampToDateTime(this.intervention.endedDate).ToString("dddd dd MMMM yyyy HH:mm");
                    this.L_ComeBack.Visible = true;
                }
            }
        }
        /// <summary>
        /// Ajouter un Item dans l'intervention selectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier que le champ n'est pas vide
                if (this.TB_BarCodeAdd.TextLength == 0)
                    throw new FormatException();

                var barCode = int.Parse(this.TB_BarCodeAdd.Text);
                Item itemToAdd = db.Items.Where(a => a.barCode == barCode).First();

                // vérifier si l'objet est utilisable
                String motif;
                if (itemToAdd.ShloudBeTrashed(out motif))
                {
                    if (Message.Comfirm(motif + " désirez vous le jeter ?"))
                        itemToAdd.state = (int)E_ItemState.trashed;
                    else
                    {
                        // Ajouter
                        this.db.AddToItemInterventions(this.intervention.AddItem(itemToAdd));
                        this.db.SaveChanges();
                    }
                }               
                else
                {
                    // Ajouter
                    this.db.AddToItemInterventions(this.intervention.AddItem(itemToAdd));
                    this.db.SaveChanges();
                }
            }
            // Mauvais code barre => erreur db.Items.where ...
            catch (InvalidOperationException) { Message.Error("Code barre incorrect"); }
            catch (FormatException) { Message.Error("Code barre incorrect"); }
            // Autres erreur gérés par ItemIntervention.cs
            catch (DataException exception) { Message.Error(exception); }

            // Mettre à jour l'affichage
            this.Panel2DataBind();

            // Pour que la prochaine saisie puisse se faire plus rapidement
            this.TB_BarCodeAdd.Text = "";
            this.TB_BarCodeAdd.Focus();
        }
        /// <summary>
        /// Valider le retour d'un objet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_CheckItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier que le champ n'est pas vide
                if (this.TB_BarCodeAdd.TextLength == 0)
                    throw new FormatException();

                var barCode = int.Parse(this.TB_BarCodeAdd.Text);
                Item itemToCheck = db.Items.Where(a => a.barCode == barCode).First();

                // Marquer si utilisé ou pas 
                this.intervention.checkItem(itemToCheck);
                this.db.SaveChanges();

                // Avancer la barre
                this.PB_Check.Value = this.intervention.percentageChecked();

                // Selectionner l'item
                this.LV_Items.MultiSelect = true;
                //this.LV_Items.SelectedIndices += 0;
                // String ligne = group.Count().ToString() + " - " + group.First().Equipment.name;
                // this.LB_Items.Items
                //itemToCheck.Equipment.name
                //this.LB_Items
            }
            // Mauvais code barre => erreur db.Items.where ...
            catch (InvalidOperationException) { Message.Error("Code barre incorrect"); }
            catch (FormatException) { Message.Error("Code barre incorrect"); }
            // Autres erreur gérés par ItemIntervention.cs
            catch (DataException exception) { Message.Error(exception); }

            // Pour que la prochaine saisie puisse se faire plus rapidement
            this.TB_BarCodeAdd.Text = "";
            this.TB_BarCodeAdd.Focus();
        }
        private void B_NewIntervention_Click(object sender, EventArgs e)
        {
            this.intervention = new Intervention() { name = "Nouvelle intervention" };
            db.AddToInterventions(this.intervention);
            db.SaveChanges();
            // Mettre à jour l'affichae
            this.LV_Interventions.SelectedItems.Clear();
            this.Panel2DataBind(); 
            this.Panel1DataBind();
        }
        private void B_Departure_Click(object sender, EventArgs e)
        {
            this.intervention.startedDate = DataBase.DateTimeToTimestamp(DateTime.Now);
            db.SaveChanges();
            this.Panel2DataBind(); // Mettre à jour
            this.Panel1DataBind();
        }
        private void B_ComeBack_Click(object sender, EventArgs e)
        {
            this.intervention.endedDate = DataBase.DateTimeToTimestamp(DateTime.Now);
            this.intervention.checkingState = E_InterventionCheckingState.started;
            db.SaveChanges();
            this.Panel2DataBind();
            this.Panel1DataBind();
        }
        private void B_Fin_Click(object sender, EventArgs e)
        {
            // Passer a l'étape suivant du checking
            switch (this.intervention.checkingState)
            {
                case E_InterventionCheckingState.started:
                    this.intervention.checkingState = E_InterventionCheckingState.usedObjectChecked;
                    break;
                case E_InterventionCheckingState.usedObjectChecked:
                    this.intervention.checkingState = E_InterventionCheckingState.usedAndNotUsedObjectChecked;
                    this.PB_Check.Value = 100;
                    // Indiquer quel objets on été perdus
                    this.intervention.lostItems();
                    this.intervention.checkingState = E_InterventionCheckingState.done;
                    break;
            }
            this.db.SaveChanges();
            this.Panel1DataBind();
            this.Panel2DataBind();
        }
        private void TB_TitleIntervention_TextChanged(object sender, EventArgs e)
        {
            this.intervention.name = this.TB_TitleIntervention.Text;
        }
        /// <summary>
        /// Enregistrer le nouveau nom en persistance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_TitleIntervention_Leave(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.Panel2DataBind();
            this.Panel1DataBind();
        }

        private void LV_Interventions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.LV_Interventions.SelectedItems.Count != 0 )
            {
                long id = int.Parse(LV_Interventions.SelectedItems[0].SubItems[1].Text);
                this.intervention = db.Interventions.First(a => a.id == id);
                this.Panel2DataBind(); // Mettre à jour
            }
        }

        private void B_DeleteIntervention_Click(object sender, EventArgs e)
        {
            if (Message.Comfirm("Voulez vous vraiment supprimer cette intervention ?"))
                db.DeleteObject(this.intervention);
            this.db.SaveChanges();
            this.intervention = null;
            this.LV_Interventions.SelectedItems.Clear();
            this.Panel1DataBind();
            this.Panel2DataBind();
        }

        private void B_Fermer_Click(object sender, EventArgs e)
        {
            this.intervention = null;
            this.LV_Interventions.SelectedItems.Clear();
            this.Panel2DataBind();
            this.Panel1DataBind();
        }

        private void F_Accueil_SizeChanged(object sender, EventArgs e)
        {
            // Redimentioner la collone contenant les titre des interventions 
            this.LV_Interventions.Columns[1].Width = 0;
            this.LV_Interventions.Columns[0].Width = this.SplitContainer.Panel1.Width;

            // Conserver la colonne "intitule" dans la liste des iems sur toute la largeur
            this.LV_Items.Columns[0].Width = 40;
            this.LV_Items.Columns[0].TextAlign = HorizontalAlignment.Right;
            this.LV_Items.Columns[1].Width = -2; // -2 : remplir le reste
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            Program.Exit();
        }
        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ShowUsers();
        }

        private void ChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Instance.Logout();
            Forms.ConnectUser(true);
        }

        private void deconexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Instance.Logout();
            this.L_ConnectedUser.Text = User.Instance.ToString();
        }
        /// <summary>
        /// Intervention -> Nouvelle
        /// </summary>
        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.B_NewIntervention_Click(this, e);
        }
        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayFullHistory = this.historiqueToolStripMenuItem.Checked;
            this.Panel1DataBind();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ShowNewItem();
        }

        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ShowAbout();
        }


        private void F_Accueil_Activated(object sender, EventArgs e)
        {
            this.L_ConnectedUser.Text = User.Instance.ToString();
        }

        private void LV_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LV_Interventions_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }

    }
}
