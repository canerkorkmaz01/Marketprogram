using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Market_Programı
{
    public class VeritabaniOlustur
    {
        string BaglantiOlustur()
        {
            string txt = @".";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            if (!String.IsNullOrEmpty(txt.ToString()))
                builder.DataSource = txt.ToString();
            else
                builder.DataSource = Environment.MachineName;
            builder.InitialCatalog = "master";
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        public void VeritabanıKurulumu()
        {
            SqlConnection baglanti = new SqlConnection(BaglantiOlustur());
            string dosya = File.ReadAllText(Application.StartupPath + @"\script.sql".ToString());
            string[] komutlar = Regex.Split(dosya, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            baglanti.Open();
            bool sonuc = true;

            foreach (string komut in komutlar)
            {
                if (komut.Trim() != "")
                {
                    try
                    {
                        new SqlCommand(komut, baglanti).ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        sonuc = false;
                        //MessageBox.Show("Bu Veritabanı Zaten Var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
           
            baglanti.Close();
        }
    }
}
