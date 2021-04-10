namespace HybridCryptography
{
    partial class DecryptForm
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
            this.browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_path = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.rc2decrypt = new System.Windows.Forms.Button();
            this.desdecrypt = new System.Windows.Forms.Button();
            this.aesdecrypt = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.documenttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hybridCryptographyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hybrid_CryptographyDataSet = new HybridCryptography.Hybrid_CryptographyDataSet();
            this.document_tableTableAdapter = new HybridCryptography.Hybrid_CryptographyDataSetTableAdapters.document_tableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentcreateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentextensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logout = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.documenttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridCryptographyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybrid_CryptographyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.ForeColor = System.Drawing.Color.Navy;
            this.browse.Location = new System.Drawing.Point(385, 298);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(87, 28);
            this.browse.TabIndex = 49;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(61, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Path";
            // 
            // textbox_path
            // 
            this.textbox_path.ForeColor = System.Drawing.Color.Navy;
            this.textbox_path.Location = new System.Drawing.Point(96, 267);
            this.textbox_path.Name = "textbox_path";
            this.textbox_path.Size = new System.Drawing.Size(260, 20);
            this.textbox_path.TabIndex = 47;
            // 
            // save_button
            // 
            this.save_button.ForeColor = System.Drawing.Color.Navy;
            this.save_button.Location = new System.Drawing.Point(385, 260);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(87, 32);
            this.save_button.TabIndex = 46;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // rc2decrypt
            // 
            this.rc2decrypt.ForeColor = System.Drawing.Color.Navy;
            this.rc2decrypt.Location = new System.Drawing.Point(96, 325);
            this.rc2decrypt.Name = "rc2decrypt";
            this.rc2decrypt.Size = new System.Drawing.Size(75, 23);
            this.rc2decrypt.TabIndex = 45;
            this.rc2decrypt.Text = "RC2";
            this.rc2decrypt.UseVisualStyleBackColor = true;
            this.rc2decrypt.Click += new System.EventHandler(this.rc2decrypt_Click);
            // 
            // desdecrypt
            // 
            this.desdecrypt.ForeColor = System.Drawing.Color.Navy;
            this.desdecrypt.Location = new System.Drawing.Point(189, 325);
            this.desdecrypt.Name = "desdecrypt";
            this.desdecrypt.Size = new System.Drawing.Size(75, 23);
            this.desdecrypt.TabIndex = 44;
            this.desdecrypt.Text = "DES";
            this.desdecrypt.UseVisualStyleBackColor = true;
            this.desdecrypt.Click += new System.EventHandler(this.desdecrypt_Click);
            // 
            // aesdecrypt
            // 
            this.aesdecrypt.ForeColor = System.Drawing.Color.Navy;
            this.aesdecrypt.Location = new System.Drawing.Point(281, 325);
            this.aesdecrypt.Name = "aesdecrypt";
            this.aesdecrypt.Size = new System.Drawing.Size(75, 23);
            this.aesdecrypt.TabIndex = 43;
            this.aesdecrypt.Text = "AES";
            this.aesdecrypt.UseVisualStyleBackColor = true;
            this.aesdecrypt.Click += new System.EventHandler(this.aesdecrypt_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.ForeColor = System.Drawing.Color.Navy;
            this.textBox_password.Location = new System.Drawing.Point(96, 299);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(260, 20);
            this.textBox_password.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(37, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Password";
            // 
            // documenttableBindingSource
            // 
            this.documenttableBindingSource.DataMember = "document_table";
            this.documenttableBindingSource.DataSource = this.hybridCryptographyDataSetBindingSource;
            // 
            // hybridCryptographyDataSetBindingSource
            // 
            this.hybridCryptographyDataSetBindingSource.DataSource = this.hybrid_CryptographyDataSet;
            this.hybridCryptographyDataSetBindingSource.Position = 0;
            // 
            // hybrid_CryptographyDataSet
            // 
            this.hybrid_CryptographyDataSet.DataSetName = "Hybrid_CryptographyDataSet";
            this.hybrid_CryptographyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // document_tableTableAdapter
            // 
            this.document_tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentIDDataGridViewTextBoxColumn,
            this.documentcreateddateDataGridViewTextBoxColumn,
            this.documentextensionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documenttableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 202);
            this.dataGridView1.TabIndex = 50;
            // 
            // documentIDDataGridViewTextBoxColumn
            // 
            this.documentIDDataGridViewTextBoxColumn.DataPropertyName = "document_ID";
            this.documentIDDataGridViewTextBoxColumn.HeaderText = "document_ID";
            this.documentIDDataGridViewTextBoxColumn.Name = "documentIDDataGridViewTextBoxColumn";
            this.documentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentcreateddateDataGridViewTextBoxColumn
            // 
            this.documentcreateddateDataGridViewTextBoxColumn.DataPropertyName = "document_created_date";
            this.documentcreateddateDataGridViewTextBoxColumn.HeaderText = "document_created_date";
            this.documentcreateddateDataGridViewTextBoxColumn.Name = "documentcreateddateDataGridViewTextBoxColumn";
            this.documentcreateddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentextensionDataGridViewTextBoxColumn
            // 
            this.documentextensionDataGridViewTextBoxColumn.DataPropertyName = "document_extension";
            this.documentextensionDataGridViewTextBoxColumn.HeaderText = "document_extension";
            this.documentextensionDataGridViewTextBoxColumn.Name = "documentextensionDataGridViewTextBoxColumn";
            this.documentextensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logout
            // 
            this.logout.ForeColor = System.Drawing.Color.Navy;
            this.logout.Location = new System.Drawing.Point(429, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(59, 29);
            this.logout.TabIndex = 51;
            this.logout.Text = "Çıkış Yap";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // report
            // 
            this.report.ForeColor = System.Drawing.Color.Navy;
            this.report.Location = new System.Drawing.Point(385, 332);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(87, 28);
            this.report.TabIndex = 53;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 387);
            this.ControlBox = false;
            this.Controls.Add(this.report);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_path);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.rc2decrypt);
            this.Controls.Add(this.desdecrypt);
            this.Controls.Add(this.aesdecrypt);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt";
            this.Load += new System.EventHandler(this.DecryptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documenttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridCryptographyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybrid_CryptographyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_path;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button rc2decrypt;
        private System.Windows.Forms.Button desdecrypt;
        private System.Windows.Forms.Button aesdecrypt;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hybridCryptographyDataSetBindingSource;
        private Hybrid_CryptographyDataSet hybrid_CryptographyDataSet;
        private System.Windows.Forms.BindingSource documenttableBindingSource;
        private Hybrid_CryptographyDataSetTableAdapters.document_tableTableAdapter document_tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentcreateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentextensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button report;
    }
}