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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.tbCpAdr = new System.Windows.Forms.TextBox();
            this.labelAdr = new System.Windows.Forms.LinkLabel();
            this.labelRue = new System.Windows.Forms.Label();
            this.labelNumAdr = new System.Windows.Forms.Label();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbNumAdr = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioFemme = new System.Windows.Forms.RadioButton();
            this.radioHomme = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
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
            this.gvClientAll.Location = new System.Drawing.Point(292, 37);
            this.gvClientAll.Name = "gvClientAll";
            this.gvClientAll.Size = new System.Drawing.Size(936, 491);
            this.gvClientAll.TabIndex = 1;
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(32, 160);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(231, 36);
            this.btnAddCli.TabIndex = 3;
            this.btnAddCli.Text = "+ Ajouter +";
            this.btnAddCli.UseVisualStyleBackColor = true;
            this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
            // 
            // btnOkCli
            // 
            this.btnOkCli.Location = new System.Drawing.Point(505, 785);
            this.btnOkCli.Name = "btnOkCli";
            this.btnOkCli.Size = new System.Drawing.Size(231, 36);
            this.btnOkCli.TabIndex = 4;
            this.btnOkCli.Text = "✓ Valider les modifications ✓";
            this.btnOkCli.UseVisualStyleBackColor = true;
            this.btnOkCli.Click += new System.EventHandler(this.btnOkCli_Click);
            // 
            // btnDelCli
            // 
            this.btnDelCli.Location = new System.Drawing.Point(32, 365);
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
            this.labelPartModif.Location = new System.Drawing.Point(29, 545);
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
            this.linkLabel2.Location = new System.Drawing.Point(151, 693);
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
            this.linkLabel1.Location = new System.Drawing.Point(626, 598);
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
            this.label1.Location = new System.Drawing.Point(639, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tel";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(642, 644);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(301, 20);
            this.tbEmail.TabIndex = 36;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(949, 644);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(144, 20);
            this.tbTel.TabIndex = 35;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(963, 713);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(64, 13);
            this.labelCP.TabIndex = 34;
            this.labelCP.Text = "Code Postal";
            // 
            // tbCpAdr
            // 
            this.tbCpAdr.Location = new System.Drawing.Point(966, 729);
            this.tbCpAdr.Name = "tbCpAdr";
            this.tbCpAdr.Size = new System.Drawing.Size(92, 20);
            this.tbCpAdr.TabIndex = 33;
            // 
            // labelAdr
            // 
            this.labelAdr.ActiveLinkColor = System.Drawing.Color.Black;
            this.labelAdr.AutoSize = true;
            this.labelAdr.DisabledLinkColor = System.Drawing.Color.Black;
            this.labelAdr.LinkColor = System.Drawing.Color.Black;
            this.labelAdr.Location = new System.Drawing.Point(627, 684);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(109, 13);
            this.labelAdr.TabIndex = 32;
            this.labelAdr.TabStop = true;
            this.labelAdr.Text = "ADRESSE                 ";
            this.labelAdr.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Location = new System.Drawing.Point(708, 713);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(27, 13);
            this.labelRue.TabIndex = 31;
            this.labelRue.Text = "Rue";
            // 
            // labelNumAdr
            // 
            this.labelNumAdr.AutoSize = true;
            this.labelNumAdr.Location = new System.Drawing.Point(640, 713);
            this.labelNumAdr.Name = "labelNumAdr";
            this.labelNumAdr.Size = new System.Drawing.Size(19, 13);
            this.labelNumAdr.TabIndex = 30;
            this.labelNumAdr.Text = "N°";
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(711, 729);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(233, 20);
            this.tbRue.TabIndex = 29;
            // 
            // tbNumAdr
            // 
            this.tbNumAdr.Location = new System.Drawing.Point(643, 729);
            this.tbNumAdr.Name = "tbNumAdr";
            this.tbNumAdr.Size = new System.Drawing.Size(50, 20);
            this.tbNumAdr.TabIndex = 28;
            // 
            // labelId
            // 
            this.labelId.ActiveLinkColor = System.Drawing.Color.Black;
            this.labelId.AutoSize = true;
            this.labelId.DisabledLinkColor = System.Drawing.Color.Black;
            this.labelId.LinkColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(151, 599);
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
            this.label3.Location = new System.Drawing.Point(368, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 644);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 644);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 23;
            // 
            // radioFemme
            // 
            this.radioFemme.AutoSize = true;
            this.radioFemme.Location = new System.Drawing.Point(259, 729);
            this.radioFemme.Name = "radioFemme";
            this.radioFemme.Size = new System.Drawing.Size(59, 17);
            this.radioFemme.TabIndex = 22;
            this.radioFemme.TabStop = true;
            this.radioFemme.Text = "Femme";
            this.radioFemme.UseVisualStyleBackColor = true;
            // 
            // radioHomme
            // 
            this.radioHomme.AutoSize = true;
            this.radioHomme.Location = new System.Drawing.Point(167, 729);
            this.radioHomme.Name = "radioHomme";
            this.radioHomme.Size = new System.Drawing.Size(61, 17);
            this.radioHomme.TabIndex = 21;
            this.radioHomme.TabStop = true;
            this.radioHomme.Text = "Homme";
            this.radioHomme.UseVisualStyleBackColor = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 833);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.tbCpAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.labelRue);
            this.Controls.Add(this.labelNumAdr);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.tbNumAdr);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radioFemme);
            this.Controls.Add(this.radioHomme);
            this.Controls.Add(this.labelPartModif);
            this.Controls.Add(this.btnDelCli);
            this.Controls.Add(this.btnOkCli);
            this.Controls.Add(this.btnAddCli);
            this.Controls.Add(this.gvClientAll);
            this.Controls.Add(this.btnRetour);
            this.Name = "FormClient";
            this.Text = "FormClient";
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
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox tbCpAdr;
        private System.Windows.Forms.LinkLabel labelAdr;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.Label labelNumAdr;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbNumAdr;
        private System.Windows.Forms.LinkLabel labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioFemme;
        private System.Windows.Forms.RadioButton radioHomme;
    }
}