namespace AppClient
{
    partial class FormPagePrincipale
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdentiteUtilisateur = new System.Windows.Forms.Label();
            this.buttonGestionArticles = new System.Windows.Forms.Button();
            this.buttonGestionClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue";
            // 
            // labelIdentiteUtilisateur
            // 
            this.labelIdentiteUtilisateur.AutoSize = true;
            this.labelIdentiteUtilisateur.Location = new System.Drawing.Point(164, 18);
            this.labelIdentiteUtilisateur.Name = "labelIdentiteUtilisateur";
            this.labelIdentiteUtilisateur.Size = new System.Drawing.Size(66, 13);
            this.labelIdentiteUtilisateur.TabIndex = 1;
            this.labelIdentiteUtilisateur.Text = "Lorem ipsum";
            // 
            // buttonGestionArticles
            // 
            this.buttonGestionArticles.Location = new System.Drawing.Point(102, 67);
            this.buttonGestionArticles.Name = "buttonGestionArticles";
            this.buttonGestionArticles.Size = new System.Drawing.Size(128, 23);
            this.buttonGestionArticles.TabIndex = 2;
            this.buttonGestionArticles.Text = "Gestion des articles";
            this.buttonGestionArticles.UseVisualStyleBackColor = true;
            this.buttonGestionArticles.Click += new System.EventHandler(this.buttonGestionArticles_Click);
            // 
            // buttonGestionClient
            // 
            this.buttonGestionClient.Location = new System.Drawing.Point(102, 130);
            this.buttonGestionClient.Name = "buttonGestionClient";
            this.buttonGestionClient.Size = new System.Drawing.Size(128, 23);
            this.buttonGestionClient.TabIndex = 3;
            this.buttonGestionClient.Text = "Gestion des clients";
            this.buttonGestionClient.UseVisualStyleBackColor = true;
            this.buttonGestionClient.Click += new System.EventHandler(this.buttonGestionClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Passer commande";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGestionClient);
            this.Controls.Add(this.buttonGestionArticles);
            this.Controls.Add(this.labelIdentiteUtilisateur);
            this.Controls.Add(this.label1);
            this.Name = "FormPagePrincipale";
            this.Text = "PagePrincipale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIdentiteUtilisateur;
        private System.Windows.Forms.Button buttonGestionArticles;
        private System.Windows.Forms.Button buttonGestionClient;
        private System.Windows.Forms.Button button1;
    }
}