using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridCryptography
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            passtext.PasswordChar = '*';
            confirmpass.PasswordChar = '*';
        }
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();
        Cryptograf passcrypt = new Cryptograf();

        private void register_button_Click(object sender, EventArgs e)
        {
            if (string.Equals(passtext.Text,confirmpass.Text))
            {
                var pass = passcrypt.CreateMD5(passtext.Text);
                try
                {
                    user_table user_table = new user_table();
                    user_table.user_name = nametext.Text;
                    user_table.user_password = pass;
                    user_table.user_createdDate = DateTime.Now.ToString();
                    user_table.user_email = emailtext.Text;
                    entities.user_table.Add(user_table);
                    entities.SaveChanges();
                   switch (MessageBox.Show("Başarılı","Onay Kutusu", MessageBoxButtons.OKCancel,MessageBoxIcon.Information))
                    {
                        case DialogResult.OK:
                            this.Hide();
                            UserLogin form = new UserLogin();
                            form.Show();
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                    } 
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
            }

        }

        private void register_admin_Click(object sender, EventArgs e)
        {
            if (string.Equals(passtext.Text, confirmpass.Text))
            {
                var pass = passcrypt.CreateMD5(passtext.Text);
                try
                {
                    admin_table admin_Table = new admin_table();
                    admin_Table.admin_name = nametext.Text;
                    admin_Table.admin_password = pass;
                    admin_Table.admin_createdDate = DateTime.Now.ToString();
                    admin_Table.admin_email = emailtext.Text;
                    entities.admin_table.Add(admin_Table);
                    entities.SaveChanges();
                    switch (MessageBox.Show("Başarılı", "Onay Kutusu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                    {
                        case DialogResult.OK:
                            this.Hide();
                            UserLogin form = new UserLogin();
                            form.Show();
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
            }
        }
    }
}
