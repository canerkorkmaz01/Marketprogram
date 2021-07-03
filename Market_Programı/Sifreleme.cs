using System;
using System.Security.Cryptography;
using System.Text;

namespace Market_Programı
{
    public class Sifreleme
    {
        public static string Hash { get; set; } = "ShiftCtrl";

        /// <summary>
        /// Şifreleme
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public static string Encrypt(string sifre)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        /// <summary>
        /// Şifre Çözme
        /// </summary>
        /// <param name="SifrelenmisDeger"></param>
        /// <returns></returns>
        public static string Decrypt(string SifrelenmisDeger)
        {
            string res = string.Empty;
            try
            {
                byte[] data = Convert.FromBase64String(SifrelenmisDeger);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        res = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch (Exception) {; }
            return res;
        }
    }
}

