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
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(23, 24);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "←";
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
            this.btnOkCli.Location = new System.Drawing.Point(997, 534);
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 581);
            this.Controls.Add(this.btnDelCli);
            this.Controls.Add(this.btnOkCli);
            this.Controls.Add(this.btnAddCli);
            this.Controls.Add(this.gvClientAll);
            this.Controls.Add(this.btnRetour);
            this.Name = "FormClient";
            this.Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView gvClientAll;
        private System.Windows.Forms.Button btnAddCli;
        private System.Windows.Forms.Button btnOkCli;
        private System.Windows.Forms.Button btnDelCli;
    }
}