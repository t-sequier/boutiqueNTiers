namespace AppClient
{
    partial class FormCommandes
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
            this.dataGridViewCommandes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPanierDansCommande = new System.Windows.Forms.DataGridView();
            this.buttonValiderPanier = new System.Windows.Forms.Button();
            this.buttonViderPanier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanierDansCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCommandes
            // 
            this.dataGridViewCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommandes.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewCommandes.Name = "dataGridViewCommandes";
            this.dataGridViewCommandes.Size = new System.Drawing.Size(651, 559);
            this.dataGridViewCommandes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes commandes passées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mon panier";
            // 
            // dataGridViewPanierDansCommande
            // 
            this.dataGridViewPanierDansCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPanierDansCommande.Location = new System.Drawing.Point(749, 65);
            this.dataGridViewPanierDansCommande.Name = "dataGridViewPanierDansCommande";
            this.dataGridViewPanierDansCommande.Size = new System.Drawing.Size(583, 530);
            this.dataGridViewPanierDansCommande.TabIndex = 3;
            // 
            // buttonValiderPanier
            // 
            this.buttonValiderPanier.Location = new System.Drawing.Point(749, 601);
            this.buttonValiderPanier.Name = "buttonValiderPanier";
            this.buttonValiderPanier.Size = new System.Drawing.Size(282, 23);
            this.buttonValiderPanier.TabIndex = 4;
            this.buttonValiderPanier.Text = "Valider mon panier";
            this.buttonValiderPanier.UseVisualStyleBackColor = true;
            this.buttonValiderPanier.Click += new System.EventHandler(this.buttonValiderPanier_Click);
            // 
            // buttonViderPanier
            // 
            this.buttonViderPanier.Location = new System.Drawing.Point(1061, 601);
            this.buttonViderPanier.Name = "buttonViderPanier";
            this.buttonViderPanier.Size = new System.Drawing.Size(271, 23);
            this.buttonViderPanier.TabIndex = 5;
            this.buttonViderPanier.Text = "Vider mon panier";
            this.buttonViderPanier.UseVisualStyleBackColor = true;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.buttonViderPanier);
            this.Controls.Add(this.buttonValiderPanier);
            this.Controls.Add(this.dataGridViewPanierDansCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCommandes);
            this.Name = "FormCommandes";
            this.Text = "FormCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanierDansCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCommandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPanierDansCommande;
        private System.Windows.Forms.Button buttonValiderPanier;
        private System.Windows.Forms.Button buttonViderPanier;
    }
}