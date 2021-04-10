namespace HybridCryptography
{
    partial class EncryptForm
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
            this.save_button = new System.Windows.Forms.Button();
            this.rc2encrypt = new System.Windows.Forms.Button();
            this.desencrypt = new System.Windows.Forms.Button();
            this.aesencrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.ForeColor = System.Drawing.Color.Navy;
            this.save_button.Location = new System.Drawing.Point(261, 152);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(92, 24);
            this.save_button.TabIndex = 43;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // rc2encrypt
            // 
            this.rc2encrypt.ForeColor = System.Drawing.Color.Navy;
            this.rc2encrypt.Location = new System.Drawing.Point(412, 134);
            this.rc2encrypt.Name = "rc2encrypt";
            this.rc2encrypt.Size = new System.Drawing.Size(75, 23);
            this.rc2encrypt.TabIndex = 42;
            this.rc2encrypt.Text = "RC2";
            this.rc2encrypt.UseVisualStyleBackColor = true;
            this.rc2encrypt.Click += new System.EventHandler(this.rc2encrypt_Click);
            // 
            // desencrypt
            // 
            this.desencrypt.ForeColor = System.Drawing.Color.Navy;
            this.desencrypt.Location = new System.Drawing.Point(412, 93);
            this.desencrypt.Name = "desencrypt";
            this.desencrypt.Size = new System.Drawing.Size(75, 23);
            this.desencrypt.TabIndex = 41;
            this.desencrypt.Text = "DES";
            this.desencrypt.UseVisualStyleBackColor = true;
            this.desencrypt.Click += new System.EventHandler(this.desencrypt_Click);
            // 
            // aesencrypt
            // 
            this.aesencrypt.ForeColor = System.Drawing.Color.Navy;
            this.aesencrypt.Location = new System.Drawing.Point(412, 48);
            this.aesencrypt.Name = "aesencrypt";
            this.aesencrypt.Size = new System.Drawing.Size(75, 23);
            this.aesencrypt.TabIndex = 40;
            this.aesencrypt.Text = "AES";
            this.aesencrypt.UseVisualStyleBackColor = true;
            this.aesencrypt.Click += new System.EventHandler(this.aesencrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(426, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Path";
            // 
            // textBox_password
            // 
            this.textBox_password.ForeColor = System.Drawing.Color.Navy;
            this.textBox_password.Location = new System.Drawing.Point(80, 100);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(302, 20);
            this.textBox_password.TabIndex = 36;
            // 
            // textBox_path
            // 
            this.textBox_path.ForeColor = System.Drawing.Color.Navy;
            this.textBox_path.Location = new System.Drawing.Point(80, 51);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(302, 20);
            this.textBox_path.TabIndex = 35;
            // 
            // browse
            // 
            this.browse.ForeColor = System.Drawing.Color.Navy;
            this.browse.Location = new System.Drawing.Point(104, 152);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(92, 24);
            this.browse.TabIndex = 34;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.ForeColor = System.Drawing.Color.Navy;
            this.logout.Location = new System.Drawing.Point(517, 6);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(59, 29);
            this.logout.TabIndex = 44;
            this.logout.Text = "Çıkış Yap";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 234);
            this.ControlBox = false;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.rc2encrypt);
            this.Controls.Add(this.desencrypt);
            this.Controls.Add(this.aesencrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.browse);
            this.Name = "EncryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button rc2encrypt;
        private System.Windows.Forms.Button desencrypt;
        private System.Windows.Forms.Button aesencrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button logout;
    }
}