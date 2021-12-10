namespace AppClient
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            this.btnRetour = new System.Windows.Forms.Button();
            this.gvClientAll = new System.Windows.Forms.DataGridView();
            this.btnAddCli = new System.Windows.Forms.Button();
            this.btnOkCli = new System.Windows.Forms.Button();
            this.btnDelCli = new System.Windows.Forms.Button();
            this.labelPartModif = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailClientModifier = new System.Windows.Forms.TextBox();
            this.TelClientModifier = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.CpClientModifier = new System.Windows.Forms.TextBox();
            this.labelAdr = new System.Windows.Forms.LinkLabel();
            this.labelRue = new System.Windows.Forms.Label();
            this.labelNumAdr = new System.Windows.Forms.Label();
            this.RueAdrClientModifier = new System.Windows.Forms.TextBox();
            this.NumAdrClientModifier = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrenomClientModifier = new System.Windows.Forms.TextBox();
            this.NomClientModifier = new System.Windows.Forms.TextBox();
            this.radioFemmeModifierClient = new System.Windows.Forms.RadioButton();
            this.radioHommeModifierClient = new System.Windows.Forms.RadioButton();
            this.IdClientModifier = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrenomClientAjouter = new System.Windows.Forms.TextBox();
            this.NomClientAjouter = new System.Windows.Forms.TextBox();
            this.radioFemmeClientAjouter = new System.Windows.Forms.RadioButton();
            this.radioHommeClientAjouter = new System.Windows.Forms.RadioButton();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailClientAjouter = new System.Windows.Forms.TextBox();
            this.TelClientAjouter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CpClientAjouter = new System.Windows.Forms.TextBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RueAdrClientAjouter = new System.Windows.Forms.TextBox();
            this.NumAdrClientAjouter = new System.Windows.Forms.TextBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(10, 1);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(70, 34);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "← Quitter";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // gvClientAll
            // 
            this.gvClientAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientAll.Location = new System.Drawing.Point(519, 12);
            this.gvClientAll.Name = "gvClientAll";
            this.gvClientAll.ReadOnly = true;
            this.gvClientAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClientAll.Size = new System.Drawing.Size(709, 491);
            this.gvClientAll.TabIndex = 1;
            this.gvClientAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickSurUnClient);
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(15, 429);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(451, 36);
            this.btnAddCli.TabIndex = 3;
            this.btnAddCli.Text = "+ Ajouter +";
            this.btnAddCli.UseVisualStyleBackColor = true;
            this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
            // 
            // btnOkCli
            // 
            this.btnOkCli.Location = new System.Drawing.Point(154, 817);
            this.btnOkCli.Name = "btnOkCli";
            this.btnOkCli.Size = new System.Drawing.Size(231, 36);
            this.btnOkCli.TabIndex = 4;
            this.btnOkCli.Text = "✓ Valider les modifications ✓";
            this.btnOkCli.UseVisualStyleBackColor = true;
            this.btnOkCli.Click += new System.EventHandler(this.btnOkCli_Click);
            // 
            // btnDelCli
            // 
            this.btnDelCli.Location = new System.Drawing.Point(862, 817);
            this.btnDelCli.Name = "btnDelCli";
            this.btnDelCli.Size = new System.Drawing.Size(231, 36);
            this.btnDelCli.TabIndex = 5;
            this.btnDelCli.Text = "- Supprimer -";
            this.btnDelCli.UseVisualStyleBackColor = true;
            this.btnDelCli.Click += new System.EventHandler(this.btnDelCli_Click);
            // 
            // labelPartModif
            // 
            this.labelPartModif.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.labelPartModif.AutoSize = true;
            this.labelPartModif.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.labelPartModif.LinkColor = System.Drawing.Color.DimGray;
            this.labelPartModif.Location = new System.Drawing.Point(29, 609);
            this.labelPartModif.Name = "labelPartModif";
            this.labelPartModif.Size = new System.Drawing.Size(303, 13);
            this.labelPartModif.TabIndex = 6;
            this.labelPartModif.TabStop = true;
            this.labelPartModif.Text = "Partie modification                                                              " +
    "        ";
            this.labelPartModif.VisitedLinkColor = System.Drawing.Color.DimGray;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(151, 725);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 13);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "CIVILITÉ                    ";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(626, 630);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "COORDONÉES          ";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tel";
            // 
            // EmailClientModifier
            // 
            this.EmailClientModifier.Location = new System.Drawing.Point(642, 676);
            this.EmailClientModifier.Name = "EmailClientModifier";
            this.EmailClientModifier.Size = new System.Drawing.Size(301, 20);
            this.EmailClientModifier.TabIndex = 36;
            // 
            // TelClientModifier
            // 
            this.TelClientModifier.Location = new System.Drawing.Point(949, 676);
            this.TelClientModifier.Name = "TelClientModifier";
            this.TelClientModifier.Size = new System.Drawing.Size(144, 20);
            this.TelClientModifier.TabIndex = 35;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(963, 745);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(64, 13);
            this.labelCP.TabIndex = 34;
            this.labelCP.Text = "Code Postal";
            // 
            // CpClientModifier
            // 
            this.CpClientModifier.Location = new System.Drawing.Point(966, 761);
            this.CpClientModifier.Name = "CpClientModifier";
            this.CpClientModifier.Size = new System.Drawing.Size(92, 20);
            this.CpClientModifier.TabIndex = 33;
            // 
            // labelAdr
            // 
            this.labelAdr.ActiveLinkColor = System.Drawing.Color.Black;
            this.labelAdr.AutoSize = true;
            this.labelAdr.DisabledLinkColor = System.Drawing.Color.Black;
            this.labelAdr.LinkColor = System.Drawing.Color.Black;
            this.labelAdr.Location = new System.Drawing.Point(626, 725);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(109, 13);
            this.labelAdr.TabIndex = 32;
            this.labelAdr.TabStop = true;
            this.labelAdr.Text = "ADRESSE                 ";
            this.labelAdr.VisitedLinkColor = System.Drawing.Color.Black;
            this.labelAdr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAdr_LinkClicked);
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Location = new System.Drawing.Point(708, 745);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(27, 13);
            this.labelRue.TabIndex = 31;
            this.labelRue.Text = "Rue";
            // 
            // labelNumAdr
            // 
            this.labelNumAdr.AutoSize = true;
            this.labelNumAdr.Location = new System.Drawing.Point(640, 745);
            this.labelNumAdr.Name = "labelNumAdr";
            this.labelNumAdr.Size = new System.Drawing.Size(19, 13);
            this.labelNumAdr.TabIndex = 30;
            this.labelNumAdr.Text = "N°";
            // 
            // RueAdrClientModifier
            // 
            this.RueAdrClientModifier.Location = new System.Drawing.Point(711, 761);
            this.RueAdrClientModifier.Name = "RueAdrClientModifier";
            this.RueAdrClientModifier.Size = new System.Drawing.Size(233, 20);
            this.RueAdrClientModifier.TabIndex = 29;
            // 
            // NumAdrClientModifier
            // 
            this.NumAdrClientModifier.Location = new System.Drawing.Point(643, 761);
            this.NumAdrClientModifier.Name = "NumAdrClientModifier";
            this.NumAdrClientModifier.Size = new System.Drawing.Size(50, 20);
            this.NumAdrClientModifier.TabIndex = 28;
            // 
            // labelId
            // 
            this.labelId.ActiveLinkColor = System.Drawing.Color.Black;
            this.labelId.AutoSize = true;
            this.labelId.DisabledLinkColor = System.Drawing.Color.Black;
            this.labelId.LinkColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(151, 631);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(108, 13);
            this.labelId.TabIndex = 27;
            this.labelId.TabStop = true;
            this.labelId.Text = "IDENTITÉ                 ";
            this.labelId.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom";
            // 
            // PrenomClientModifier
            // 
            this.PrenomClientModifier.Location = new System.Drawing.Point(371, 676);
            this.PrenomClientModifier.Name = "PrenomClientModifier";
            this.PrenomClientModifier.Size = new System.Drawing.Size(199, 20);
            this.PrenomClientModifier.TabIndex = 24;
            // 
            // NomClientModifier
            // 
            this.NomClientModifier.Location = new System.Drawing.Point(167, 676);
            this.NomClientModifier.Name = "NomClientModifier";
            this.NomClientModifier.Size = new System.Drawing.Size(198, 20);
            this.NomClientModifier.TabIndex = 23;
            // 
            // radioFemmeModifierClient
            // 
            this.radioFemmeModifierClient.AutoSize = true;
            this.radioFemmeModifierClient.Location = new System.Drawing.Point(259, 761);
            this.radioFemmeModifierClient.Name = "radioFemmeModifierClient";
            this.radioFemmeModifierClient.Size = new System.Drawing.Size(59, 17);
            this.radioFemmeModifierClient.TabIndex = 22;
            this.radioFemmeModifierClient.TabStop = true;
            this.radioFemmeModifierClient.Text = "Femme";
            this.radioFemmeModifierClient.UseVisualStyleBackColor = true;
            // 
            // radioHommeModifierClient
            // 
            this.radioHommeModifierClient.AutoSize = true;
            this.radioHommeModifierClient.Location = new System.Drawing.Point(167, 761);
            this.radioHommeModifierClient.Name = "radioHommeModifierClient";
            this.radioHommeModifierClient.Size = new System.Drawing.Size(61, 17);
            this.radioHommeModifierClient.TabIndex = 21;
            this.radioHommeModifierClient.TabStop = true;
            this.radioHommeModifierClient.Text = "Homme";
            this.radioHommeModifierClient.UseVisualStyleBackColor = true;
            // 
            // IdClientModifier
            // 
            this.IdClientModifier.Location = new System.Drawing.Point(151, 676);
            this.IdClientModifier.Name = "IdClientModifier";
            this.IdClientModifier.ReadOnly = true;
            this.IdClientModifier.Size = new System.Drawing.Size(10, 20);
            this.IdClientModifier.TabIndex = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(253, 82);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(110, 13);
            this.linkLabel3.TabIndex = 50;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "CIVILITÉ                    ";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(9, 80);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(108, 13);
            this.linkLabel4.TabIndex = 49;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "IDENTITÉ                 ";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nom";
            // 
            // PrenomClientAjouter
            // 
            this.PrenomClientAjouter.Location = new System.Drawing.Point(16, 174);
            this.PrenomClientAjouter.Name = "PrenomClientAjouter";
            this.PrenomClientAjouter.Size = new System.Drawing.Size(199, 20);
            this.PrenomClientAjouter.TabIndex = 46;
            // 
            // NomClientAjouter
            // 
            this.NomClientAjouter.Location = new System.Drawing.Point(16, 121);
            this.NomClientAjouter.Name = "NomClientAjouter";
            this.NomClientAjouter.Size = new System.Drawing.Size(198, 20);
            this.NomClientAjouter.TabIndex = 45;
            // 
            // radioFemmeClientAjouter
            // 
            this.radioFemmeClientAjouter.AutoSize = true;
            this.radioFemmeClientAjouter.Location = new System.Drawing.Point(336, 121);
            this.radioFemmeClientAjouter.Name = "radioFemmeClientAjouter";
            this.radioFemmeClientAjouter.Size = new System.Drawing.Size(59, 17);
            this.radioFemmeClientAjouter.TabIndex = 44;
            this.radioFemmeClientAjouter.TabStop = true;
            this.radioFemmeClientAjouter.Text = "Femme";
            this.radioFemmeClientAjouter.UseVisualStyleBackColor = true;
            // 
            // radioHommeClientAjouter
            // 
            this.radioHommeClientAjouter.AutoSize = true;
            this.radioHommeClientAjouter.Location = new System.Drawing.Point(254, 121);
            this.radioHommeClientAjouter.Name = "radioHommeClientAjouter";
            this.radioHommeClientAjouter.Size = new System.Drawing.Size(61, 17);
            this.radioHommeClientAjouter.TabIndex = 43;
            this.radioHommeClientAjouter.TabStop = true;
            this.radioHommeClientAjouter.Text = "Homme";
            this.radioHommeClientAjouter.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Location = new System.Drawing.Point(12, 230);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(113, 13);
            this.linkLabel5.TabIndex = 62;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "COORDONÉES          ";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tel";
            // 
            // EmailClientAjouter
            // 
            this.EmailClientAjouter.Location = new System.Drawing.Point(16, 270);
            this.EmailClientAjouter.Name = "EmailClientAjouter";
            this.EmailClientAjouter.Size = new System.Drawing.Size(301, 20);
            this.EmailClientAjouter.TabIndex = 59;
            // 
            // TelClientAjouter
            // 
            this.TelClientAjouter.Location = new System.Drawing.Point(322, 270);
            this.TelClientAjouter.Name = "TelClientAjouter";
            this.TelClientAjouter.Size = new System.Drawing.Size(144, 20);
            this.TelClientAjouter.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Code Postal";
            // 
            // CpClientAjouter
            // 
            this.CpClientAjouter.Location = new System.Drawing.Point(322, 358);
            this.CpClientAjouter.Name = "CpClientAjouter";
            this.CpClientAjouter.Size = new System.Drawing.Size(92, 20);
            this.CpClientAjouter.TabIndex = 56;
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel6.LinkColor = System.Drawing.Color.Black;
            this.linkLabel6.Location = new System.Drawing.Point(14, 322);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(109, 13);
            this.linkLabel6.TabIndex = 55;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "ADRESSE                 ";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Rue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "N°";
            // 
            // RueAdrClientAjouter
            // 
            this.RueAdrClientAjouter.Location = new System.Drawing.Point(82, 358);
            this.RueAdrClientAjouter.Name = "RueAdrClientAjouter";
            this.RueAdrClientAjouter.Size = new System.Drawing.Size(233, 20);
            this.RueAdrClientAjouter.TabIndex = 52;
            // 
            // NumAdrClientAjouter
            // 
            this.NumAdrClientAjouter.Location = new System.Drawing.Point(15, 358);
            this.NumAdrClientAjouter.Name = "NumAdrClientAjouter";
            this.NumAdrClientAjouter.Size = new System.Drawing.Size(50, 20);
            this.NumAdrClientAjouter.TabIndex = 51;
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel7.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel7.Location = new System.Drawing.Point(12, 55);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(60, 13);
            this.linkLabel7.TabIndex = 63;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Partie ajout";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.DimGray;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 872);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailClientAjouter);
            this.Controls.Add(this.TelClientAjouter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CpClientAjouter);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RueAdrClientAjouter);
            this.Controls.Add(this.NumAdrClientAjouter);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrenomClientAjouter);
            this.Controls.Add(this.NomClientAjouter);
            this.Controls.Add(this.radioFemmeClientAjouter);
            this.Controls.Add(this.radioHommeClientAjouter);
            this.Controls.Add(this.IdClientModifier);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailClientModifier);
            this.Controls.Add(this.TelClientModifier);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.CpClientModifier);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.labelRue);
            this.Controls.Add(this.labelNumAdr);
            this.Controls.Add(this.RueAdrClientModifier);
            this.Controls.Add(this.NumAdrClientModifier);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrenomClientModifier);
            this.Controls.Add(this.NomClientModifier);
            this.Controls.Add(this.radioFemmeModifierClient);
            this.Controls.Add(this.radioHommeModifierClient);
            this.Controls.Add(this.labelPartModif);
            this.Controls.Add(this.btnDelCli);
            this.Controls.Add(this.btnOkCli);
            this.Controls.Add(this.btnAddCli);
            this.Controls.Add(this.gvClientAll);
            this.Controls.Add(this.btnRetour);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView gvClientAll;
        private System.Windows.Forms.Button btnAddCli;
        private System.Windows.Forms.Button btnOkCli;
        private System.Windows.Forms.Button btnDelCli;
        private System.Windows.Forms.LinkLabel labelPartModif;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailClientModifier;
        private System.Windows.Forms.TextBox TelClientModifier;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox CpClientModifier;
        private System.Windows.Forms.LinkLabel labelAdr;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.Label labelNumAdr;
        private System.Windows.Forms.TextBox RueAdrClientModifier;
        private System.Windows.Forms.TextBox NumAdrClientModifier;
        private System.Windows.Forms.LinkLabel labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrenomClientModifier;
        private System.Windows.Forms.TextBox NomClientModifier;
        private System.Windows.Forms.RadioButton radioFemmeModifierClient;
        private System.Windows.Forms.RadioButton radioHommeModifierClient;
        private System.Windows.Forms.TextBox IdClientModifier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrenomClientAjouter;
        private System.Windows.Forms.TextBox NomClientAjouter;
        private System.Windows.Forms.RadioButton radioFemmeClientAjouter;
        private System.Windows.Forms.RadioButton radioHommeClientAjouter;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailClientAjouter;
        private System.Windows.Forms.TextBox TelClientAjouter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CpClientAjouter;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RueAdrClientAjouter;
        private System.Windows.Forms.TextBox NumAdrClientAjouter;
        private System.Windows.Forms.LinkLabel linkLabel7;
    }
}