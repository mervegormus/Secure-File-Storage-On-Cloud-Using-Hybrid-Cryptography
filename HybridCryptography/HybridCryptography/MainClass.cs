using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridCryptography
{
    class Cryptograf
    {
        Hybrid_CryptographyEntities entities = new Hybrid_CryptographyEntities();//entity tanımı
        document_table document_Table = new document_table();// ilgili tablo
        private string mKey = string.Empty;
        private string mSalt = string.Empty;
        private ServiceProviderEnum mAlgorithm;
        private SymmetricAlgorithm mCryptoService;
        public string path = EncryptForm.path;
        public string pathd = DecryptForm.pathd;
        public static string aesKey = "rB%n7m.Kcf?-Vc52";
        public static string desKey = "gY1,+7smF/5_";
        public static string rc2Key = "dyrua55!aöx^^";

        private void SetLegalIV()
        {
            // algoritma ayarlamaları gerekli tanımların yapımı
            switch (mAlgorithm)
            {
                case ServiceProviderEnum.Rijndael:
                    mCryptoService.IV = new byte[] {0xf, 0x6f, 0x13, 0x2e, 0x35,
 0xc2, 0xcd, 0xf9, 0x5, 0x46, 0x9c, 0xea, 0xa8, 0x4b, 0x73,0xcc};
                    break;
                default:
                    mCryptoService.IV = new byte[] {0xf, 0x6f, 0x13, 0x2e,
      0x35, 0xc2, 0xcd, 0xf9};
                    break;
            }
        }



        #region Public interfaces...

        public enum ServiceProviderEnum : int
        {
            // kullanacabileceğimiz algoritmalar
            Rijndael,
            RC2,
            DES,
            TripleDES
        }

        public Cryptograf()
        {
            // varsayılan olarak seçilen algoritma
            mCryptoService = new RijndaelManaged();
            mCryptoService.Mode = CipherMode.CBC;
            mAlgorithm = ServiceProviderEnum.Rijndael;
        }

        public Cryptograf(ServiceProviderEnum serviceProvider)
        {
            //seçim yapıldığı halde işleyecek kod
            switch (serviceProvider)
            {
                case ServiceProviderEnum.Rijndael:
                    mCryptoService = new RijndaelManaged();
                    mAlgorithm = ServiceProviderEnum.Rijndael;
                    break;
                case ServiceProviderEnum.RC2:
                    mCryptoService = new RC2CryptoServiceProvider();
                    mAlgorithm = ServiceProviderEnum.RC2;
                    break;
                case ServiceProviderEnum.DES:
                    mCryptoService = new DESCryptoServiceProvider();
                    mAlgorithm = ServiceProviderEnum.DES;
                    break;
                case ServiceProviderEnum.TripleDES:
                    mCryptoService = new TripleDESCryptoServiceProvider();
                    mAlgorithm = ServiceProviderEnum.TripleDES;
                    break;
            }
            mCryptoService.Mode = CipherMode.CBC;
        }

        public Cryptograf(string serviceProviderName)
        {
            try
            {
                // formda belirlediğimiz algoritmalardan çağırılan algoritma seçimi
                switch (serviceProviderName.ToLower())
                {
                    case "rijndael":
                        serviceProviderName = "Rijndael";
                        mAlgorithm = ServiceProviderEnum.Rijndael;
                        break;
                    case "rc2":
                        serviceProviderName = "RC2";
                        mAlgorithm = ServiceProviderEnum.RC2;
                        break;
                    case "des":
                        serviceProviderName = "DES";
                        mAlgorithm = ServiceProviderEnum.DES;
                        break;
                    case "tripledes":
                        serviceProviderName = "TripleDES";
                        mAlgorithm = ServiceProviderEnum.TripleDES;
                        break;
                }

                // seçilen algoritma işlemin yapılacağı koda gönderiliyor
                mCryptoService = (SymmetricAlgorithm)
                  CryptoConfig.CreateFromName(serviceProviderName);
                mCryptoService.Mode = CipherMode.CBC;
            }
            catch
            {
                throw;
            }
        }

        public virtual byte[] GetLegalKey()
        {
            // anahtar değeri ayarlama ve geçerli anahtar değerini döndürme
            // anahtar denetleme yapılıyor daha çok
            if (mCryptoService.LegalKeySizes.Length > 0)
            {
                // bit cinsinden anahtar boyutu
                int keySize = mKey.Length * 8;
                int minSize = mCryptoService.LegalKeySizes[0].MinSize;
                int maxSize = mCryptoService.LegalKeySizes[0].MaxSize;
                int skipSize = mCryptoService.LegalKeySizes[0].SkipSize;

                if (keySize > maxSize)
                {
                    // izin verilen max boyut için
                    mKey = mKey.Substring(0, maxSize / 8);
                }
                else if (keySize < maxSize)
                {
                    // geçerli bir boyut ayarlamak için 
                    int validSize = (keySize <= minSize) ? minSize :
                         (keySize - keySize % skipSize) + skipSize;
                    if (keySize < validSize)
                    {
                        // boşta kalan yerler * ile doldurulur
                        mKey = mKey.PadRight(validSize / 8, '*');
                    }
                }
            }
            PasswordDeriveBytes key = new PasswordDeriveBytes(mKey,
                 ASCIIEncoding.ASCII.GetBytes(mSalt));
            return key.GetBytes(mKey.Length);
        }
        public virtual string Encrypt(string plainText)
        {
            byte[] plainByte = File.ReadAllBytes(plainText); //dosya byte olarak okundu

            byte[] keyByte = GetLegalKey();

            mCryptoService.Key = keyByte;
            SetLegalIV();

            // Encryptor nesnesi
            ICryptoTransform cryptoTransform = mCryptoService.CreateEncryptor();

            // Memory stream nesnesi
            MemoryStream ms = new MemoryStream();

            // Crpto stream nesnesi
            CryptoStream cs = new CryptoStream(ms, cryptoTransform,
                 CryptoStreamMode.Write);

            // şifrelenmiş veri byte olarak memory yazılıyor
            cs.Write(plainByte, 0, plainByte.Length);
            cs.FlushFinalBlock();

            // şifrelenmiş veriyi alıyoruz 
            byte[] cryptoByte = ms.ToArray();
            SaveFile(path, cryptoByte);
            // alttaki kod algoritmaların düzgün çalışması için eklenmiştir sonuç xml de kullanılabilmesi için base64 seçilmiştir.
            return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));
        }

        public virtual string Decrypt(string plainText)
        {

            byte[] cryptoByte = File.ReadAllBytes(plainText);

            byte[] keyByte = GetLegalKey();

            // key ayarları
            mCryptoService.Key = keyByte;
            SetLegalIV();

            // Decryptor nesnesi
            ICryptoTransform cryptoTransform = mCryptoService.CreateDecryptor();
            try
            {
                // Memory stream nesnesi
                MemoryStream ms = new MemoryStream(cryptoByte, 0, cryptoByte.Length);

                // Crpto stream nesnesi okumak için
                CryptoStream cs = new CryptoStream(ms, cryptoTransform,
                    CryptoStreamMode.Read);
                // Crpto stream nesnesi yazmak için
                CryptoStream csw = new CryptoStream(ms, cryptoTransform,
                     CryptoStreamMode.Write);

                // şifresi çözülmüş veriyi memorye yazma
                csw.Write(cryptoByte, 0, cryptoByte.Length);

                // şifresi çözülmüş verinin diziye aktarımı
                byte[] dcryptoByte = ms.ToArray();
                SaveFile(pathd, dcryptoByte);

                //Crypto stream den sonucu alır
                StreamReader sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public string Key
        {
            get
            {
                return mKey;
            }
            set
            {
                mKey = value;
            }
        }

        public string Salt
        {
            // salt değeri ayarlama
            get
            {
                return mSalt;
            }
            set
            {
                mSalt = value;
            }
        }
        #endregion
        private static void SaveFile(string savePath, byte[] saveContent)
        {
            try
            {   // dosyayı aynı konuma kaydet
                File.WriteAllBytes(savePath, saveContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string CreateMD5(string passdata)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashdata = md5.ComputeHash(Encoding.Default.GetBytes(passdata));//ASCIIEncoding.ASCII.GetBytes
            return Convert.ToBase64String(hashdata);

        }
        public string CreateSHA(string keydata)
        {
            SHA1 sha = SHA1.Create();
            byte[] sha1 = sha.ComputeHash(Encoding.Default.GetBytes(keydata));//ASCIIEncoding.ASCII.GetBytes
            return Convert.ToBase64String(sha1);
           

        }
        public string CreateSHA256(string keydata)
        {
            SHA256 sha = SHA256.Create();
            byte[] sha256 = sha.ComputeHash(Encoding.Default.GetBytes(keydata));//ASCIIEncoding.ASCII.GetBytes
            return Convert.ToBase64String(sha256);
        
        }
        public string CreateSHA384(string keydata)
        {
            SHA384 sha = SHA384.Create();
            byte []sha384 = sha.ComputeHash(Encoding.Default.GetBytes(keydata));//ASCIIEncoding.ASCII.GetBytes
            return Convert.ToBase64String(sha384);
        }

    }
}
