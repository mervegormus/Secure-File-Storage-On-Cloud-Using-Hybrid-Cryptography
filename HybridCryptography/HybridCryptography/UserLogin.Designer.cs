namespace HybridCryptography
{
    partial class UserLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.admin_login = new System.Windows.Forms.Button();
            this.userlogin_button = new System.Windows.Forms.Button();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_login
            // 
            this.admin_login.ForeColor = System.Drawing.Color.Navy;
            this.admin_login.Location = new System.Drawing.Point(199, 227);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(71, 22);
            this.admin_login.TabIndex = 16;
            this.admin_login.Text = "Admin ";
            this.admin_login.UseVisualStyleBackColor = true;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // userlogin_button
            // 
            this.userlogin_button.ForeColor = System.Drawing.Color.Navy;
            this.userlogin_button.Location = new System.Drawing.Point(117, 136);
            this.userlogin_button.Name = "userlogin_button";
            this.userlogin_button.Size = new System.Drawing.Size(98, 26);
            this.userlogin_button.TabIndex = 15;
            this.userlogin_button.Text = "Login";
            this.userlogin_button.UseVisualStyleBackColor = true;
            this.userlogin_button.Click += new System.EventHandler(this.userlogin_button_Click);
            // 
            // user_password
            // 
            this.user_password.ForeColor = System.Drawing.Color.Navy;
            this.user_password.Location = new System.Drawing.Point(87, 100);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(169, 20);
            this.user_password.TabIndex = 14;
            // 
            // user_name
            // 
            this.user_name.ForeColor = System.Drawing.Color.Navy;
            this.user_name.Location = new System.Drawing.Point(87, 39);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(169, 20);
            this.user_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.ForeColor = System.Drawing.Color.Navy;
            this.textBox_email.Location = new System.Drawing.Point(87, 71);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(169, 20);
            this.textBox_email.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Create account ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admin_login);
            this.Controls.Add(this.userlogin_button);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_email);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.Button userlogin_button;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
    }
}

