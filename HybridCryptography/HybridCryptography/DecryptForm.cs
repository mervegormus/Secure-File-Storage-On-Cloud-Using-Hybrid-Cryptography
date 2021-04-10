using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;

namespace HybridCryptography
{
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();
        Cryptograf keycrypt = new Cryptograf();
        string currentID;
        int intcurrentID;
        string extension;
        public string doc_aesKey, doc_desKey, doc_rc2Key;
        public string aesKey = Cryptograf.aesKey, desKey = Cryptograf.desKey, rc2Key = Cryptograf.rc2Key;
        public static string pathd;
        private void save_button_Click(object sender, EventArgs e)
        {
            /*  currentID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
              intcurrentID = Convert.ToInt32(currentID);
              Console.WriteLine(intcurrentID);*/

            //seçilen dosya ıd si alınır
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                currentID = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            }
            intcurrentID = Convert.ToInt32(currentID);
            // Console.WriteLine(intcurrentID);
            int adminId = AdminForm.adminID;
            var admin = entities.admin_table.FirstOrDefault(a => a.admin_ID == adminId);
            admin.document_ID = intcurrentID;
            entities.SaveChanges();

            /*   var data = entities.document_table.AsNoTracking().OrderByDescending(o => o.document_ID).
          Select(q => new
          {
              q.document_ID,
              q.document_content,
          }).ToList();
               if (data.Equals(currentID))
               {
                   byte[] doc_content =data.;
                   string fileExt = @"C:\Users\Merve Görmüş\Desktop";
                   SaveFileDialog sd = new SaveFileDialog();
                   sd.Filter = "Files(*" + fileExt + ")|*" + fileExt;
                   if (sd.ShowDialog() == DialogResult.OK)
                   {
                       File.WriteAllBytes(sd.FileName, doc_content);
                   }
               }*/

            foreach (var doc in entities.document_table)
            {
                //db tablodan alınan örnekle datagridviewden alınan id karşılaştırılması yapılır
                int docID = doc.document_ID;
                Console.WriteLine(docID);
                if (docID == intcurrentID)
                {   //id ler eşitse tablodan ilgili veri alınıp verilen konuma savefile ile kaydedilir dosya şifreli haliyle konuma yazdırılmış olur
                    byte[] doc_content = doc.document_content;
                    doc_aesKey = doc.document_keyAes;
                    doc_desKey = doc.document_keyDes;
                    doc_rc2Key = doc.document_keyRc2;
                    //Console.WriteLine(doc_aesKey);
                    //Console.WriteLine(doc_desKey);
                    //Console.WriteLine(doc_rc2Key);


                    string fileExt = @"C:\Users\Merve Görmüş\Desktop";
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = "Files(*" + fileExt + ")|*" + fileExt;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, doc_content);
                    }
                }
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            //db den locale alınan dosyayı seçmek için 
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textbox_path.Text = openFile.FileName;
            }
            extension = openFile.FileName.ToString();
            extension = Path.GetExtension(extension);
            pathd = textbox_path.Text;
        }

        private void rc2decrypt_Click(object sender, EventArgs e)
        {
            Cryptograf cryptic = new Cryptograf();//nesne üretilir
            string plainText = textbox_path.Text;//path alınır
            cryptic = new Cryptograf("rc2");//algoritma seçilir
                if (string.Equals(rc2Key, textBox_password.Text))
                {
                //cryptic.Key = keycrypt.CreateSHA384(textBox_password.Text);
                cryptic.Key = doc_rc2Key;
                    cryptic.Decrypt(plainText);// decrypt başlatılır
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

        private void desdecrypt_Click(object sender, EventArgs e)
        {

            Cryptograf cryptic = new Cryptograf();
            cryptic = new Cryptograf("DES");
            string plainText = textbox_path.Text;
                if (string.Equals(desKey, textBox_password.Text))
                {
                //cryptic.Key = keycrypt.CreateSHA256(textBox_password.Text);
                cryptic.Key = doc_desKey;
                    cryptic.Decrypt(plainText);
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

        private void aesdecrypt_Click(object sender, EventArgs e)
        {
            Cryptograf cryptic = new Cryptograf();
            string plainText = textbox_path.Text;
            cryptic = new Cryptograf("Rijndael");
                if (string.Equals(aesKey, textBox_password.Text))
                {
                //cryptic.Key = keycrypt.CreateSHA(textBox_password.Text);
                cryptic.Key = doc_aesKey;
                    cryptic.Decrypt(plainText);

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

        private void DecryptForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hybrid_CryptographyDataSet.document_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.document_tableTableAdapter.Fill(this.hybrid_CryptographyDataSet.document_table);

        }

        private void logout_Click(object sender, EventArgs e)
        {   //admin login ekranına dönmek için
            //  FormsAuthentication.SignOut();
            switch (MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Onay Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.No:
                    this.Hide();
                    AdminForm form = new AdminForm();
                    form.Show();
                    break;
                case DialogResult.Yes:
                    this.Close();
                    break;
            }

        }

        private void report_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();          
        }
    }
}
