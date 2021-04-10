using System;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace HybridCryptography
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            user_password.PasswordChar = '*';
        }
        public static int getUserId;
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();
        Cryptograf passcrypt = new Cryptograf();
    
        private void userlogin_button_Click(object sender, EventArgs e)
        {
            if (user_name.Text != string.Empty && user_password.Text != string.Empty && textBox_email.Text!=string.Empty)
            {              
                var user = entities.user_table.FirstOrDefault(a => a.user_name.Equals(user_name.Text));
                if (user != null)
                {
                    if (user.user_password.Equals(passcrypt.CreateMD5(user_password.Text)))
                    {
                        MessageBox.Show("Hoşgeldiniz " +user.user_name);
                        user.user_loginDate = DateTime.Now.ToString();
                        getUserId = user.user_ID;
                       // Console.WriteLine(getUserId);
                        entities.SaveChanges();
                        this.Hide();//formu kapatır
                        EncryptForm form = new EncryptForm();
                        form.Show();//encrypt formunu açıyor
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz Hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("Bilgileriniz yalnış");
                }
            }
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            this.Hide();//formu kapatır
            AdminForm form = new AdminForm();
            form.Show();//decrypt formunu açıyor
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.Show();
        }
    }
}
