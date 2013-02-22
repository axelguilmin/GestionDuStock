namespace Gestion_du_stock
{
    partial class F_Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("En Attente", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("En cours", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("A Checker", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Historique", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Example"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Example 2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Accueil));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.LV_Interventions = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_NewIntervention = new System.Windows.Forms.Button();
            this.L_InterventionsEnCours = new System.Windows.Forms.Label();
            this.L_InterventionsEnAttente = new System.Windows.Forms.Label();
            this.LV_Items = new System.Windows.Forms.ListView();
            this.Qte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intitule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_Close = new System.Windows.Forms.Button();
            this.TB_TitleIntervention = new System.Windows.Forms.TextBox();
            this.B_DeleteIntervention = new System.Windows.Forms.Button();
            this.B_Fin = new System.Windows.Forms.Button();
            this.PB_Check = new System.Windows.Forms.ProgressBar();
            this.SC_Button = new System.Windows.Forms.SplitContainer();
            this.B_Departure = new System.Windows.Forms.Button();
            this.L_Departure = new System.Windows.Forms.Label();
            this.B_ComeBack = new System.Windows.Forms.Button();
            this.L_ComeBack = new System.Windows.Forms.Label();
            this.L_Chek = new System.Windows.Forms.Label();
            this.TB_BarCodeAdd = new System.Windows.Forms.TextBox();
            this.B_AddItem = new System.Windows.Forms.Button();
            this.B_CheckItem = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.L_ConnectedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_Button)).BeginInit();
            this.SC_Button.Panel1.SuspendLayout();
            this.SC_Button.Panel2.SuspendLayout();
            this.SC_Button.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Menu;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.interventionsToolStripMenuItem,
            this.materielToolStripMenuItem,
            this.utilisateursToolStripMenuItem,
            this.toolStripMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(658, 24);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "Menu";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // interventionsToolStripMenuItem
            // 
            this.interventionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleToolStripMenuItem,
            this.historiqueToolStripMenuItem});
            this.interventionsToolStripMenuItem.Name = "interventionsToolStripMenuItem";
            this.interventionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.interventionsToolStripMenuItem.Text = "Interventions";
            // 
            // nouvelleToolStripMenuItem
            // 
            this.nouvelleToolStripMenuItem.Name = "nouvelleToolStripMenuItem";
            this.nouvelleToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nouvelleToolStripMenuItem.Text = "Nouvelle";
            this.nouvelleToolStripMenuItem.Click += new System.EventHandler(this.nouvelleToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.CheckOnClick = true;
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.historiqueToolStripMenuItem.Text = "Afficher tout l\'historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // materielToolStripMenuItem
            // 
            this.materielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererMaterielToolStripMenuItem});
            this.materielToolStripMenuItem.Name = "materielToolStripMenuItem";
            this.materielToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.materielToolStripMenuItem.Text = "Materiel";
            // 
            // gererMaterielToolStripMenuItem
            // 
            this.gererMaterielToolStripMenuItem.Name = "gererMaterielToolStripMenuItem";
            this.gererMaterielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gererMaterielToolStripMenuItem.Text = "Gérer";
            this.gererMaterielToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.ChangerToolStripMenuItem,
            this.deconexionToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gererToolStripMenuItem.Text = "Gerer";
            this.gererToolStripMenuItem.Click += new System.EventHandler(this.gererToolStripMenuItem_Click);
            // 
            // ChangerToolStripMenuItem
            // 
            this.ChangerToolStripMenuItem.Name = "ChangerToolStripMenuItem";
            this.ChangerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ChangerToolStripMenuItem.Text = "Changer";
            this.ChangerToolStripMenuItem.Click += new System.EventHandler(this.ChangerToolStripMenuItem_Click);
            // 
            // deconexionToolStripMenuItem
            // 
            this.deconexionToolStripMenuItem.Name = "deconexionToolStripMenuItem";
            this.deconexionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deconexionToolStripMenuItem.Text = "Deconexion";
            this.deconexionToolStripMenuItem.Click += new System.EventHandler(this.deconexionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LV_Interventions);
            this.SplitContainer.Panel1.Controls.Add(this.B_NewIntervention);
            this.SplitContainer.Panel1.Controls.Add(this.L_InterventionsEnCours);
            this.SplitContainer.Panel1.Controls.Add(this.L_InterventionsEnAttente);
            this.SplitContainer.Panel1MinSize = 180;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.AccessibleName = "";
            this.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.Panel2.Controls.Add(this.LV_Items);
            this.SplitContainer.Panel2.Controls.Add(this.B_Close);
            this.SplitContainer.Panel2.Controls.Add(this.TB_TitleIntervention);
            this.SplitContainer.Panel2.Controls.Add(this.B_DeleteIntervention);
            this.SplitContainer.Panel2.Controls.Add(this.B_Fin);
            this.SplitContainer.Panel2.Controls.Add(this.PB_Check);
            this.SplitContainer.Panel2.Controls.Add(this.SC_Button);
            this.SplitContainer.Panel2.Controls.Add(this.L_Chek);
            this.SplitContainer.Panel2.Controls.Add(this.TB_BarCodeAdd);
            this.SplitContainer.Panel2.Controls.Add(this.B_AddItem);
            this.SplitContainer.Panel2.Controls.Add(this.B_CheckItem);
            this.SplitContainer.Panel2MinSize = 180;
            this.SplitContainer.Size = new System.Drawing.Size(658, 438);
            this.SplitContainer.SplitterDistance = 200;
            this.SplitContainer.TabIndex = 11;
            // 
            // LV_Interventions
            // 
            this.LV_Interventions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Interventions.BackColor = System.Drawing.SystemColors.Control;
            this.LV_Interventions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV_Interventions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.id});
            this.LV_Interventions.FullRowSelect = true;
            listViewGroup1.Header = "En Attente";
            listViewGroup1.Name = "En Attente";
            listViewGroup2.Header = "En cours";
            listViewGroup2.Name = "En cours";
            listViewGroup3.Header = "A Checker";
            listViewGroup3.Name = "A Checker";
            listViewGroup4.Header = "Historique";
            listViewGroup4.Name = "Historique";
            this.LV_Interventions.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.LV_Interventions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LV_Interventions.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup2;
            this.LV_Interventions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LV_Interventions.LabelWrap = false;
            this.LV_Interventions.Location = new System.Drawing.Point(0, 40);
            this.LV_Interventions.MultiSelect = false;
            this.LV_Interventions.Name = "LV_Interventions";
            this.LV_Interventions.Size = new System.Drawing.Size(200, 398);
            this.LV_Interventions.TabIndex = 18;
            this.LV_Interventions.UseCompatibleStateImageBehavior = false;
            this.LV_Interventions.View = System.Windows.Forms.View.Details;
            this.LV_Interventions.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.LV_Interventions_ItemMouseHover);
            this.LV_Interventions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_Interventions_ItemSelectionChanged);
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 59;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // B_NewIntervention
            // 
            this.B_NewIntervention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.B_NewIntervention.Location = new System.Drawing.Point(3, 3);
            this.B_NewIntervention.Name = "B_NewIntervention";
            this.B_NewIntervention.Size = new System.Drawing.Size(194, 31);
            this.B_NewIntervention.TabIndex = 14;
            this.B_NewIntervention.Text = "Nouvelle intervention";
            this.B_NewIntervention.UseVisualStyleBackColor = true;
            this.B_NewIntervention.Click += new System.EventHandler(this.B_NewIntervention_Click);
            // 
            // L_InterventionsEnCours
            // 
            this.L_InterventionsEnCours.AutoSize = true;
            this.L_InterventionsEnCours.Location = new System.Drawing.Point(-208, 197);
            this.L_InterventionsEnCours.Name = "L_InterventionsEnCours";
            this.L_InterventionsEnCours.Size = new System.Drawing.Size(112, 13);
            this.L_InterventionsEnCours.TabIndex = 17;
            this.L_InterventionsEnCours.Text = "Interventions en cours";
            // 
            // L_InterventionsEnAttente
            // 
            this.L_InterventionsEnAttente.AutoSize = true;
            this.L_InterventionsEnAttente.Location = new System.Drawing.Point(-208, 44);
            this.L_InterventionsEnAttente.Name = "L_InterventionsEnAttente";
            this.L_InterventionsEnAttente.Size = new System.Drawing.Size(119, 13);
            this.L_InterventionsEnAttente.TabIndex = 13;
            this.L_InterventionsEnAttente.Text = "Interventions en attente";
            // 
            // LV_Items
            // 
            this.LV_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Qte,
            this.Intitule});
            this.LV_Items.FullRowSelect = true;
            this.LV_Items.GridLines = true;
            this.LV_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Items.HideSelection = false;
            this.LV_Items.Location = new System.Drawing.Point(3, 68);
            this.LV_Items.Name = "LV_Items";
            this.LV_Items.Size = new System.Drawing.Size(444, 243);
            this.LV_Items.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LV_Items.TabIndex = 24;
            this.LV_Items.UseCompatibleStateImageBehavior = false;
            this.LV_Items.View = System.Windows.Forms.View.Details;
            this.LV_Items.SelectedIndexChanged += new System.EventHandler(this.LV_Items_SelectedIndexChanged);
            // 
            // Qte
            // 
            this.Qte.Text = "Qte";
            this.Qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qte.Width = 30;
            // 
            // Intitule
            // 
            this.Intitule.Text = "Intitulé";
            this.Intitule.Width = 410;
            // 
            // B_Close
            // 
            this.B_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Close.Location = new System.Drawing.Point(385, 388);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(61, 25);
            this.B_Close.TabIndex = 23;
            this.B_Close.Text = "Fermer";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Fermer_Click);
            // 
            // TB_TitleIntervention
            // 
            this.TB_TitleIntervention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_TitleIntervention.BackColor = System.Drawing.SystemColors.Window;
            this.TB_TitleIntervention.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_TitleIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TitleIntervention.Location = new System.Drawing.Point(3, 40);
            this.TB_TitleIntervention.Name = "TB_TitleIntervention";
            this.TB_TitleIntervention.Size = new System.Drawing.Size(445, 22);
            this.TB_TitleIntervention.TabIndex = 22;
            this.TB_TitleIntervention.Text = "TB_TitleIntervention";
            this.TB_TitleIntervention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_TitleIntervention.TextChanged += new System.EventHandler(this.TB_TitleIntervention_TextChanged);
            this.TB_TitleIntervention.Leave += new System.EventHandler(this.TB_TitleIntervention_Leave);
            // 
            // B_DeleteIntervention
            // 
            this.B_DeleteIntervention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_DeleteIntervention.Location = new System.Drawing.Point(3, 388);
            this.B_DeleteIntervention.Name = "B_DeleteIntervention";
            this.B_DeleteIntervention.Size = new System.Drawing.Size(68, 25);
            this.B_DeleteIntervention.TabIndex = 21;
            this.B_DeleteIntervention.Text = "Supprimer";
            this.B_DeleteIntervention.UseVisualStyleBackColor = true;
            this.B_DeleteIntervention.Click += new System.EventHandler(this.B_DeleteIntervention_Click);
            // 
            // B_Fin
            // 
            this.B_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Fin.Location = new System.Drawing.Point(386, 359);
            this.B_Fin.Name = "B_Fin";
            this.B_Fin.Size = new System.Drawing.Size(59, 22);
            this.B_Fin.TabIndex = 18;
            this.B_Fin.Text = "Fin";
            this.B_Fin.UseVisualStyleBackColor = true;
            this.B_Fin.Click += new System.EventHandler(this.B_Fin_Click);
            // 
            // PB_Check
            // 
            this.PB_Check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Check.Location = new System.Drawing.Point(2, 359);
            this.PB_Check.Name = "PB_Check";
            this.PB_Check.Size = new System.Drawing.Size(378, 23);
            this.PB_Check.TabIndex = 17;
            // 
            // SC_Button
            // 
            this.SC_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SC_Button.IsSplitterFixed = true;
            this.SC_Button.Location = new System.Drawing.Point(3, 3);
            this.SC_Button.Margin = new System.Windows.Forms.Padding(0);
            this.SC_Button.Name = "SC_Button";
            // 
            // SC_Button.Panel1
            // 
            this.SC_Button.Panel1.Controls.Add(this.B_Departure);
            this.SC_Button.Panel1.Controls.Add(this.L_Departure);
            // 
            // SC_Button.Panel2
            // 
            this.SC_Button.Panel2.Controls.Add(this.B_ComeBack);
            this.SC_Button.Panel2.Controls.Add(this.L_ComeBack);
            this.SC_Button.Size = new System.Drawing.Size(445, 31);
            this.SC_Button.SplitterDistance = 219;
            this.SC_Button.TabIndex = 16;
            this.SC_Button.TabStop = false;
            // 
            // B_Departure
            // 
            this.B_Departure.AutoSize = true;
            this.B_Departure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Departure.Location = new System.Drawing.Point(0, 0);
            this.B_Departure.Margin = new System.Windows.Forms.Padding(0);
            this.B_Departure.Name = "B_Departure";
            this.B_Departure.Size = new System.Drawing.Size(219, 31);
            this.B_Departure.TabIndex = 14;
            this.B_Departure.Text = "Départ";
            this.B_Departure.UseVisualStyleBackColor = true;
            this.B_Departure.Click += new System.EventHandler(this.B_Departure_Click);
            // 
            // L_Departure
            // 
            this.L_Departure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_Departure.Location = new System.Drawing.Point(0, 0);
            this.L_Departure.Name = "L_Departure";
            this.L_Departure.Size = new System.Drawing.Size(219, 31);
            this.L_Departure.TabIndex = 12;
            this.L_Departure.Text = "L_Departure";
            this.L_Departure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Departure.Visible = false;
            // 
            // B_ComeBack
            // 
            this.B_ComeBack.AutoSize = true;
            this.B_ComeBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_ComeBack.Location = new System.Drawing.Point(0, 0);
            this.B_ComeBack.Name = "B_ComeBack";
            this.B_ComeBack.Size = new System.Drawing.Size(222, 31);
            this.B_ComeBack.TabIndex = 13;
            this.B_ComeBack.Text = "Retour";
            this.B_ComeBack.UseVisualStyleBackColor = true;
            this.B_ComeBack.Click += new System.EventHandler(this.B_ComeBack_Click);
            // 
            // L_ComeBack
            // 
            this.L_ComeBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_ComeBack.Location = new System.Drawing.Point(0, 0);
            this.L_ComeBack.Name = "L_ComeBack";
            this.L_ComeBack.Size = new System.Drawing.Size(222, 31);
            this.L_ComeBack.TabIndex = 9;
            this.L_ComeBack.Text = "L_ComeBack";
            this.L_ComeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_ComeBack.Visible = false;
            // 
            // L_Chek
            // 
            this.L_Chek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Chek.BackColor = System.Drawing.SystemColors.Control;
            this.L_Chek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L_Chek.Location = new System.Drawing.Point(3, 340);
            this.L_Chek.Name = "L_Chek";
            this.L_Chek.Size = new System.Drawing.Size(445, 16);
            this.L_Chek.TabIndex = 15;
            this.L_Chek.Text = "Information utilisateur";
            this.L_Chek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TB_BarCodeAdd
            // 
            this.TB_BarCodeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_BarCodeAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_BarCodeAdd.Location = new System.Drawing.Point(3, 317);
            this.TB_BarCodeAdd.Name = "TB_BarCodeAdd";
            this.TB_BarCodeAdd.Size = new System.Drawing.Size(377, 20);
            this.TB_BarCodeAdd.TabIndex = 11;
            // 
            // B_AddItem
            // 
            this.B_AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_AddItem.Location = new System.Drawing.Point(386, 317);
            this.B_AddItem.Name = "B_AddItem";
            this.B_AddItem.Size = new System.Drawing.Size(61, 20);
            this.B_AddItem.TabIndex = 10;
            this.B_AddItem.Text = "+";
            this.B_AddItem.UseVisualStyleBackColor = true;
            this.B_AddItem.Click += new System.EventHandler(this.B_AddItem_Click);
            // 
            // B_CheckItem
            // 
            this.B_CheckItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_CheckItem.Location = new System.Drawing.Point(386, 317);
            this.B_CheckItem.Name = "B_CheckItem";
            this.B_CheckItem.Size = new System.Drawing.Size(61, 20);
            this.B_CheckItem.TabIndex = 19;
            this.B_CheckItem.Text = "Check";
            this.B_CheckItem.UseVisualStyleBackColor = true;
            this.B_CheckItem.Click += new System.EventHandler(this.B_CheckItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.L_ConnectedUser});
            this.StatusStrip.Location = new System.Drawing.Point(0, 440);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(658, 22);
            this.StatusStrip.TabIndex = 12;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // L_ConnectedUser
            // 
            this.L_ConnectedUser.Name = "L_ConnectedUser";
            this.L_ConnectedUser.Size = new System.Drawing.Size(0, 17);
            // 
            // F_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 462);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "F_Accueil";
            this.Text = "Gestion du stock";
            this.Activated += new System.EventHandler(this.F_Accueil_Activated);
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.SizeChanged += new System.EventHandler(this.F_Accueil_SizeChanged);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.SC_Button.Panel1.ResumeLayout(false);
            this.SC_Button.Panel1.PerformLayout();
            this.SC_Button.Panel2.ResumeLayout(false);
            this.SC_Button.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_Button)).EndInit();
            this.SC_Button.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererMaterielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangerToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label L_InterventionsEnCours;
        private System.Windows.Forms.Button B_NewIntervention;
        private System.Windows.Forms.Label L_InterventionsEnAttente;
        private System.Windows.Forms.Label L_Departure;
        private System.Windows.Forms.Button B_Departure;
        private System.Windows.Forms.Button B_ComeBack;
        private System.Windows.Forms.TextBox TB_BarCodeAdd;
        private System.Windows.Forms.Button B_AddItem;
        private System.Windows.Forms.Label L_Chek;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.SplitContainer SC_Button;
        private System.Windows.Forms.Label L_ComeBack;
        private System.Windows.Forms.ProgressBar PB_Check;
        private System.Windows.Forms.Button B_Fin;
        private System.Windows.Forms.Button B_CheckItem;
        private System.Windows.Forms.Button B_DeleteIntervention;
        private System.Windows.Forms.TextBox TB_TitleIntervention;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.ListView LV_Items;
        private System.Windows.Forms.ColumnHeader Intitule;
        private System.Windows.Forms.ColumnHeader Qte;
        private System.Windows.Forms.ListView LV_Interventions;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ToolStripStatusLabel L_ConnectedUser;
    }
}

