using System;
using System.Linq;
using System.Windows.Forms;

namespace HybridCryptography
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            admin_password.PasswordChar = '*'; //password *** şeklinde yazar
        }
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();
        Cryptograf passcrypt = new Cryptograf();
        public static int adminID;
        private void admin_login_Click(object sender, EventArgs e)
        {

            if (admin_name.Text != string.Empty && admin_password.Text != string.Empty)
            {
                var admin = entities.admin_table.FirstOrDefault(a => a.admin_name.Equals(admin_name.Text));
                if (admin != null)
                {
                    if (admin.admin_password.Equals(passcrypt.CreateMD5( admin_password.Text)))
                    {
                        MessageBox.Show("Hoşgeldiniz " + admin.admin_name);
                        adminID = admin.admin_ID;
                        admin.admin_loginDate = DateTime.Now.ToString();
                        entities.SaveChanges();
                        this.Hide();//formu kapatır
                        DecryptForm form = new DecryptForm();
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.Show();
        }
    }
}

