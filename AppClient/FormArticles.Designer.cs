namespace AppClient
{
    partial class FormArticles
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
            this.buttonAjoutArticle = new System.Windows.Forms.Button();
            this.treeViewInfosArticles = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.PoidsArticleModif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RubriqueArticleModif = new System.Windows.Forms.TextBox();
            this.DescriptionArticleModif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NomArticleModif = new System.Windows.Forms.TextBox();
            this.ButtonModiferArticle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.QuantiteStockArticleModif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PrixArticleModif = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IdModifArticle = new System.Windows.Forms.TextBox();
            this.PrixArticleAjouter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantiteStockArticleAjouter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PoidsArticleAjouter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionArticleAjouter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NomArticleAjouter = new System.Windows.Forms.TextBox();
            this.RubriqueArticleAjouter = new System.Windows.Forms.ComboBox();
            this.ButtonSupprimerArticle = new System.Windows.Forms.Button();
            this.buttonAjoutPanier = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewPanier = new System.Windows.Forms.DataGridView();
            this.QuantiteArticleAjoutPanier = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteArticleAjoutPanier)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjoutArticle
            // 
            this.buttonAjoutArticle.Location = new System.Drawing.Point(12, 764);
            this.buttonAjoutArticle.Name = "buttonAjoutArticle";
            this.buttonAjoutArticle.Size = new System.Drawing.Size(365, 23);
            this.buttonAjoutArticle.TabIndex = 0;
            this.buttonAjoutArticle.Text = "Ajouter un article";
            this.buttonAjoutArticle.UseVisualStyleBackColor = true;
            this.buttonAjoutArticle.Click += new System.EventHandler(this.ajoutArticle);
            // 
            // treeViewInfosArticles
            // 
            this.treeViewInfosArticles.Location = new System.Drawing.Point(12, 12);
            this.treeViewInfosArticles.Name = "treeViewInfosArticles";
            this.treeViewInfosArticles.Size = new System.Drawing.Size(228, 383);
            this.treeViewInfosArticles.TabIndex = 1;
            this.treeViewInfosArticles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewInfosArticles_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajout d\'un article";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(246, 12);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticles.Size = new System.Drawing.Size(1230, 383);
            this.dataGridViewArticles.TabIndex = 14;
            this.dataGridViewArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickSurUnProduit);
            this.dataGridViewArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticles_CellContentClick);
            // 
            // PoidsArticleModif
            // 
            this.PoidsArticleModif.BackColor = System.Drawing.Color.Azure;
            this.PoidsArticleModif.Location = new System.Drawing.Point(626, 623);
            this.PoidsArticleModif.Name = "PoidsArticleModif";
            this.PoidsArticleModif.Size = new System.Drawing.Size(365, 20);
            this.PoidsArticleModif.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Poids";
            // 
            // RubriqueArticleModif
            // 
            this.RubriqueArticleModif.BackColor = System.Drawing.Color.Azure;
            this.RubriqueArticleModif.Location = new System.Drawing.Point(626, 574);
            this.RubriqueArticleModif.Name = "RubriqueArticleModif";
            this.RubriqueArticleModif.ReadOnly = true;
            this.RubriqueArticleModif.Size = new System.Drawing.Size(365, 20);
            this.RubriqueArticleModif.TabIndex = 21;
            // 
            // DescriptionArticleModif
            // 
            this.DescriptionArticleModif.BackColor = System.Drawing.Color.Azure;
            this.DescriptionArticleModif.Location = new System.Drawing.Point(626, 520);
            this.DescriptionArticleModif.Name = "DescriptionArticleModif";
            this.DescriptionArticleModif.Size = new System.Drawing.Size(365, 20);
            this.DescriptionArticleModif.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Modification d\'un article (Séléctionnez un article dans la liste plus haut)";
            // 
            // NomArticleModif
            // 
            this.NomArticleModif.BackColor = System.Drawing.Color.Azure;
            this.NomArticleModif.Location = new System.Drawing.Point(626, 462);
            this.NomArticleModif.Name = "NomArticleModif";
            this.NomArticleModif.Size = new System.Drawing.Size(365, 20);
            this.NomArticleModif.TabIndex = 16;
            // 
            // ButtonModiferArticle
            // 
            this.ButtonModiferArticle.Location = new System.Drawing.Point(626, 750);
            this.ButtonModiferArticle.Name = "ButtonModiferArticle";
            this.ButtonModiferArticle.Size = new System.Drawing.Size(174, 23);
            this.ButtonModiferArticle.TabIndex = 15;
            this.ButtonModiferArticle.Text = "Modifier l\'article";
            this.ButtonModiferArticle.UseVisualStyleBackColor = true;
            this.ButtonModiferArticle.Click += new System.EventHandler(this.BoutonModiferArticle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rubrique";
            // 
            // QuantiteStockArticleModif
            // 
            this.QuantiteStockArticleModif.BackColor = System.Drawing.Color.Azure;
            this.QuantiteStockArticleModif.Location = new System.Drawing.Point(626, 724);
            this.QuantiteStockArticleModif.Name = "QuantiteStockArticleModif";
            this.QuantiteStockArticleModif.Size = new System.Drawing.Size(365, 20);
            this.QuantiteStockArticleModif.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(623, 708);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Quantité Stock";
            // 
            // PrixArticleModif
            // 
            this.PrixArticleModif.BackColor = System.Drawing.Color.Azure;
            this.PrixArticleModif.Location = new System.Drawing.Point(626, 671);
            this.PrixArticleModif.Name = "PrixArticleModif";
            this.PrixArticleModif.Size = new System.Drawing.Size(365, 20);
            this.PrixArticleModif.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(623, 655);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Prix";
            // 
            // IdModifArticle
            // 
            this.IdModifArticle.BackColor = System.Drawing.Color.Azure;
            this.IdModifArticle.Enabled = false;
            this.IdModifArticle.Location = new System.Drawing.Point(997, 462);
            this.IdModifArticle.Name = "IdModifArticle";
            this.IdModifArticle.ReadOnly = true;
            this.IdModifArticle.Size = new System.Drawing.Size(36, 20);
            this.IdModifArticle.TabIndex = 30;
            // 
            // PrixArticleAjouter
            // 
            this.PrixArticleAjouter.BackColor = System.Drawing.Color.Azure;
            this.PrixArticleAjouter.Location = new System.Drawing.Point(12, 671);
            this.PrixArticleAjouter.Name = "PrixArticleAjouter";
            this.PrixArticleAjouter.Size = new System.Drawing.Size(365, 20);
            this.PrixArticleAjouter.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Prix";
            // 
            // QuantiteStockArticleAjouter
            // 
            this.QuantiteStockArticleAjouter.BackColor = System.Drawing.Color.Azure;
            this.QuantiteStockArticleAjouter.Location = new System.Drawing.Point(12, 724);
            this.QuantiteStockArticleAjouter.Name = "QuantiteStockArticleAjouter";
            this.QuantiteStockArticleAjouter.Size = new System.Drawing.Size(365, 20);
            this.QuantiteStockArticleAjouter.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 708);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantité Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rubrique";
            // 
            // PoidsArticleAjouter
            // 
            this.PoidsArticleAjouter.BackColor = System.Drawing.Color.Azure;
            this.PoidsArticleAjouter.Location = new System.Drawing.Point(12, 623);
            this.PoidsArticleAjouter.Name = "PoidsArticleAjouter";
            this.PoidsArticleAjouter.Size = new System.Drawing.Size(365, 20);
            this.PoidsArticleAjouter.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Poids";
            // 
            // DescriptionArticleAjouter
            // 
            this.DescriptionArticleAjouter.BackColor = System.Drawing.Color.Azure;
            this.DescriptionArticleAjouter.Location = new System.Drawing.Point(12, 520);
            this.DescriptionArticleAjouter.Name = "DescriptionArticleAjouter";
            this.DescriptionArticleAjouter.Size = new System.Drawing.Size(365, 20);
            this.DescriptionArticleAjouter.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nom";
            // 
            // NomArticleAjouter
            // 
            this.NomArticleAjouter.BackColor = System.Drawing.Color.Azure;
            this.NomArticleAjouter.Location = new System.Drawing.Point(12, 462);
            this.NomArticleAjouter.Name = "NomArticleAjouter";
            this.NomArticleAjouter.Size = new System.Drawing.Size(365, 20);
            this.NomArticleAjouter.TabIndex = 31;
            // 
            // RubriqueArticleAjouter
            // 
            this.RubriqueArticleAjouter.Location = new System.Drawing.Point(12, 572);
            this.RubriqueArticleAjouter.Name = "RubriqueArticleAjouter";
            this.RubriqueArticleAjouter.Size = new System.Drawing.Size(365, 21);
            this.RubriqueArticleAjouter.TabIndex = 43;
            // 
            // ButtonSupprimerArticle
            // 
            this.ButtonSupprimerArticle.Location = new System.Drawing.Point(806, 750);
            this.ButtonSupprimerArticle.Name = "ButtonSupprimerArticle";
            this.ButtonSupprimerArticle.Size = new System.Drawing.Size(185, 23);
            this.ButtonSupprimerArticle.TabIndex = 44;
            this.ButtonSupprimerArticle.Text = "Supprimer l\'article";
            this.ButtonSupprimerArticle.UseVisualStyleBackColor = true;
            this.ButtonSupprimerArticle.Click += new System.EventHandler(this.BoutonSupprimerArticle_Click_1);
            // 
            // buttonAjoutPanier
            // 
            this.buttonAjoutPanier.Location = new System.Drawing.Point(1284, 462);
            this.buttonAjoutPanier.Name = "buttonAjoutPanier";
            this.buttonAjoutPanier.Size = new System.Drawing.Size(174, 20);
            this.buttonAjoutPanier.TabIndex = 45;
            this.buttonAjoutPanier.Text = "Ajouter au panier";
            this.buttonAjoutPanier.UseVisualStyleBackColor = true;
            this.buttonAjoutPanier.Click += new System.EventHandler(this.AjoutPanier);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1120, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Mon panier";
            // 
            // dataGridViewPanier
            // 
            this.dataGridViewPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPanier.Location = new System.Drawing.Point(1123, 535);
            this.dataGridViewPanier.Name = "dataGridViewPanier";
            this.dataGridViewPanier.Size = new System.Drawing.Size(335, 252);
            this.dataGridViewPanier.TabIndex = 47;
            // 
            // QuantiteArticleAjoutPanier
            // 
            this.QuantiteArticleAjoutPanier.Location = new System.Drawing.Point(1120, 462);
            this.QuantiteArticleAjoutPanier.Name = "QuantiteArticleAjoutPanier";
            this.QuantiteArticleAjoutPanier.Size = new System.Drawing.Size(155, 20);
            this.QuantiteArticleAjoutPanier.TabIndex = 48;
            this.QuantiteArticleAjoutPanier.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1120, 409);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Panier";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1120, 446);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Quantité à ajouter au panier";
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 836);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.QuantiteArticleAjoutPanier);
            this.Controls.Add(this.dataGridViewPanier);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonAjoutPanier);
            this.Controls.Add(this.ButtonSupprimerArticle);
            this.Controls.Add(this.RubriqueArticleAjouter);
            this.Controls.Add(this.PrixArticleAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuantiteStockArticleAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PoidsArticleAjouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescriptionArticleAjouter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NomArticleAjouter);
            this.Controls.Add(this.IdModifArticle);
            this.Controls.Add(this.PrixArticleModif);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.QuantiteStockArticleModif);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PoidsArticleModif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RubriqueArticleModif);
            this.Controls.Add(this.DescriptionArticleModif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NomArticleModif);
            this.Controls.Add(this.ButtonModiferArticle);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewInfosArticles);
            this.Controls.Add(this.buttonAjoutArticle);
            this.Name = "FormArticles";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteArticleAjoutPanier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjoutArticle;
        private System.Windows.Forms.TreeView treeViewInfosArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.TextBox PoidsArticleModif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RubriqueArticleModif;
        private System.Windows.Forms.TextBox DescriptionArticleModif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomArticleModif;
        private System.Windows.Forms.Button ButtonModiferArticle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox QuantiteStockArticleModif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PrixArticleModif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IdModifArticle;
        private System.Windows.Forms.TextBox PrixArticleAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantiteStockArticleAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PoidsArticleAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptionArticleAjouter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NomArticleAjouter;
        private System.Windows.Forms.ComboBox RubriqueArticleAjouter;
        private System.Windows.Forms.Button ButtonSupprimerArticle;
        private System.Windows.Forms.Button buttonAjoutPanier;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewPanier;
        private System.Windows.Forms.NumericUpDown QuantiteArticleAjoutPanier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}