namespace HybridCryptography
{
    partial class AdminForm
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
            this.admin_login = new System.Windows.Forms.Button();
            this.admin_password = new System.Windows.Forms.TextBox();
            this.admin_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_login
            // 
            this.admin_login.ForeColor = System.Drawing.Color.Navy;
            this.admin_login.Location = new System.Drawing.Point(128, 126);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(97, 23);
            this.admin_login.TabIndex = 19;
            this.admin_login.Text = "Login";
            this.admin_login.UseVisualStyleBackColor = true;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // admin_password
            // 
            this.admin_password.Location = new System.Drawing.Point(86, 89);
            this.admin_password.Name = "admin_password";
            this.admin_password.Size = new System.Drawing.Size(180, 20);
            this.admin_password.TabIndex = 18;
            // 
            // admin_name
            // 
            this.admin_name.Location = new System.Drawing.Point(86, 37);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(180, 20);
            this.admin_name.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(86, 63);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(180, 20);
            this.email_text.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(194, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Create account ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(289, 236);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admin_login);
            this.Controls.Add(this.admin_password);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.TextBox admin_password;
        private System.Windows.Forms.TextBox admin_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label4;
    }
}