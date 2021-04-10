using System;
using System.IO;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;

namespace HybridCryptography
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();
        }
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();
        document_table document_Table = new document_table();
        user_table user_Table = new user_table();
        Cryptograf keycrypt = new Cryptograf();
        string extension;
        public static int docId;
        public static string path;
        public string aesKey = Cryptograf.aesKey, desKey = Cryptograf.desKey, rc2Key = Cryptograf.rc2Key;
        private void browse_Click(object sender, EventArgs e)
        {
            // file seçme ekranı açılır ve seçilen dosyanın uzantısıyla path alınır
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = openFile.FileName;
            }
            extension = openFile.FileName.ToString();
            extension = Path.GetExtension(extension);
            path = textBox_path.Text;
        }

        private void aesencrypt_Click(object sender, EventArgs e)
        {
            Cryptograf cryptic = new Cryptograf();//yeni nesne üretiliyor
            string plainText = textBox_path.Text;//path alınıyor
            cryptic = new Cryptograf("Rijndael");//kullanılacak algoritma
            if (string.Equals(aesKey, textBox_password.Text))
            {
                cryptic.Key = keycrypt.CreateSHA(textBox_password.Text);
                //cryptic.Key = textBox_password.Text;//kullanılacak key
                cryptic.Encrypt(plainText); //encrypt yapmak için veriyi gönderiyoruz 
            }
            else
            {
                switch (MessageBox.Show("Hatalı Key", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        this.Refresh();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }

        private void desencrypt_Click(object sender, EventArgs e)
        {
            Cryptograf cryptic = new Cryptograf();
            cryptic = new Cryptograf("DES");
            string plainText = textBox_path.Text;
            if (string.Equals(desKey, textBox_password.Text))
            {
                cryptic.Key = keycrypt.CreateSHA256(textBox_password.Text);
                cryptic.Encrypt(plainText); //encrypt yapmak için veriyi gönderiyoruz 
            }
            else
            {
                switch (MessageBox.Show("Hatalı Key", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        this.Refresh();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }

        private void rc2encrypt_Click(object sender, EventArgs e)
        {
            Cryptograf cryptic = new Cryptograf();
            cryptic = new Cryptograf("rc2");
            string plainText = textBox_path.Text;
            if (string.Equals(rc2Key, textBox_password.Text))
            {
                cryptic.Key = keycrypt.CreateSHA384(textBox_password.Text);
                cryptic.Encrypt(plainText); //encrypt yapmak için veriyi gönderiyoruz 
            }
            else
            {
                switch (MessageBox.Show("Hatalı Key", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        this.Refresh();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {

                string rc2 = keycrypt.CreateSHA(rc2Key);
                string des = keycrypt.CreateSHA256(desKey);
                string aes = keycrypt.CreateSHA384(aesKey);
                //şifrelenmiş veri veritabanına kaydetme
                byte[] buffer = File.ReadAllBytes(textBox_path.Text);//şifrelenmiş veri aynı dosya üzerine yazıldığı için dosyayı okuma yapıyoruz.
                int userId = UserLogin.getUserId;// login olan user ıd alınıyor
                document_Table.document_content = buffer;//şifrelenmiş veri kaydı
                document_Table.document_extension = extension;//dosya uzantısının kaydı
                document_Table.document_created_date = DateTime.Now.ToString();//işlemin yapıldığı tarih ve saat
                document_Table.user_ID = userId;//ilgili kısma user ıd kaydı

                document_Table.document_keyAes = aes;
                document_Table.document_keyDes = des;
                document_Table.document_keyRc2 = rc2;

                entities.document_table.Add(document_Table);//yapılan işlemlerin kaydı
                entities.SaveChanges();//değişikliklerin kaydı
                MessageBox.Show("Kayıt başarılı", "onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete(path);//şifrelenmiş dosya silinir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void logout_Click(object sender, EventArgs e)
        {   //user login ekranına dönmek için
            // FormsAuthentication.SignOut();
            switch (MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Onay Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.No:
                    this.Hide();
                    UserLogin form = new UserLogin();
                    form.Show();
                    break;
                case DialogResult.Yes:
                    this.Close();
                    break;
            }
        }
    }
}
