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
            this.gvClientEdit = new System.Windows.Forms.DataGridView();
            this.btnAddCli = new System.Windows.Forms.Button();
            this.btnEditCli = new System.Windows.Forms.Button();
            this.btnDelCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientEdit)).BeginInit();
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
            this.btnRetour.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvClientAll
            // 
            this.gvClientAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientAll.Location = new System.Drawing.Point(12, 85);
            this.gvClientAll.Name = "gvClientAll";
            this.gvClientAll.Size = new System.Drawing.Size(503, 316);
            this.gvClientAll.TabIndex = 1;
            // 
            // gvClientEdit
            // 
            this.gvClientEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientEdit.Location = new System.Drawing.Point(832, 85);
            this.gvClientEdit.Name = "gvClientEdit";
            this.gvClientEdit.Size = new System.Drawing.Size(503, 316);
            this.gvClientEdit.TabIndex = 2;
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(558, 145);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(231, 36);
            this.btnAddCli.TabIndex = 3;
            this.btnAddCli.Text = "Ajouter";
            this.btnAddCli.UseVisualStyleBackColor = true;
            // 
            // btnEditCli
            // 
            this.btnEditCli.Location = new System.Drawing.Point(558, 216);
            this.btnEditCli.Name = "btnEditCli";
            this.btnEditCli.Size = new System.Drawing.Size(231, 36);
            this.btnEditCli.TabIndex = 4;
            this.btnEditCli.Text = "Modifier >>";
            this.btnEditCli.UseVisualStyleBackColor = true;
            // 
            // btnDelCli
            // 
            this.btnDelCli.Location = new System.Drawing.Point(558, 288);
            this.btnDelCli.Name = "btnDelCli";
            this.btnDelCli.Size = new System.Drawing.Size(231, 36);
            this.btnDelCli.TabIndex = 5;
            this.btnDelCli.Text = "Supprimer";
            this.btnDelCli.UseVisualStyleBackColor = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.btnDelCli);
            this.Controls.Add(this.btnEditCli);
            this.Controls.Add(this.btnAddCli);
            this.Controls.Add(this.gvClientEdit);
            this.Controls.Add(this.gvClientAll);
            this.Controls.Add(this.btnRetour);
            this.Name = "FormClient";
            this.Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.gvClientAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView gvClientAll;
        private System.Windows.Forms.DataGridView gvClientEdit;
        private System.Windows.Forms.Button btnAddCli;
        private System.Windows.Forms.Button btnEditCli;
        private System.Windows.Forms.Button btnDelCli;
    }
}