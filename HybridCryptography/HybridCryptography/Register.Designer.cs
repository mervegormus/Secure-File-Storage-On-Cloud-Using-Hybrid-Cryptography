namespace HybridCryptography
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.register_admin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // nametext
            // 
            this.nametext.ForeColor = System.Drawing.Color.Navy;
            this.nametext.Location = new System.Drawing.Point(111, 30);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(247, 20);
            this.nametext.TabIndex = 4;
            // 
            // emailtext
            // 
            this.emailtext.ForeColor = System.Drawing.Color.Navy;
            this.emailtext.Location = new System.Drawing.Point(111, 58);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(247, 20);
            this.emailtext.TabIndex = 5;
            // 
            // passtext
            // 
            this.passtext.ForeColor = System.Drawing.Color.Navy;
            this.passtext.Location = new System.Drawing.Point(111, 83);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(247, 20);
            this.passtext.TabIndex = 6;
            // 
            // register_button
            // 
            this.register_button.ForeColor = System.Drawing.Color.Navy;
            this.register_button.Location = new System.Drawing.Point(135, 145);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(87, 23);
            this.register_button.TabIndex = 10;
            this.register_button.Text = "Register User";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_admin
            // 
            this.register_admin.ForeColor = System.Drawing.Color.Navy;
            this.register_admin.Location = new System.Drawing.Point(251, 145);
            this.register_admin.Name = "register_admin";
            this.register_admin.Size = new System.Drawing.Size(87, 23);
            this.register_admin.TabIndex = 11;
            this.register_admin.Text = "Register Admin";
            this.register_admin.UseVisualStyleBackColor = true;
            this.register_admin.Click += new System.EventHandler(this.register_admin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm Password";
            // 
            // confirmpass
            // 
            this.confirmpass.ForeColor = System.Drawing.Color.Navy;
            this.confirmpass.Location = new System.Drawing.Point(111, 109);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(247, 20);
            this.confirmpass.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.ControlBox = false;
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_admin);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button register_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmpass;
    }
}