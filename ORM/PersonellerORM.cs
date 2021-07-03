using Entity;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ORM
{
    public class PersonellerORM 
    {
        public static bool Dönüs { get; set; }

        /// <summary>
        /// /Personel Bilgisini Combobox İçinde Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable KullaniciAdlari()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personel_KullanıcıAdları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        public void PersonelGiris(Personeller p)
        {
           
            SqlCommand cmd = new SqlCommand("prc_Personel_Giris", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@kadi", p.KAdi);
            cmd.Parameters.AddWithValue("@pass", p.Sifre);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Baglanti.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                if (oku.GetInt32(1) == 1)
                {
                    Dönüs = true;
                    //PersonelBilgisi = 1;
                }
                else if(oku.GetInt32(1) == 2)
                {
                    Dönüs = true;
                }
            }
            else
            { MessageBox.Show("Hatalı Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); Dönüs = false; }
            Tools.Baglanti.Close();
        }

        public static DataTable Personeller()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personel_KullanıcıAdları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Kullanıcı Tipini Getirir 
        /// </summary>
        /// <returns></returns>
        public static DataTable KullaniciTipi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Kullanici_Tipi", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        public bool KullaniciEkle(Personeller p)
        {
            SqlCommand cmd = new SqlCommand("prc_Kullanici_TipEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@tipId",p.TipID);
            cmd.Parameters.AddWithValue("@adi",p.Adi);
            cmd.Parameters.AddWithValue("@soyadi",p.Soyadi);
            cmd.Parameters.AddWithValue("@unvan",p.Unvani);
            cmd.Parameters.AddWithValue("@kadi",p.KAdi);
            cmd.Parameters.AddWithValue("@sifre", p.Sifre);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        public bool KullaniciDüzenle(Personeller p)
        {
            SqlCommand cmd = new SqlCommand("prc_Kullanici_TipGüncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@tipId", p.TipID);
            cmd.Parameters.AddWithValue("@adi", p.Adi);
            cmd.Parameters.AddWithValue("@soyadi", p.Soyadi);
            cmd.Parameters.AddWithValue("@unvan", p.Unvani);
            cmd.Parameters.AddWithValue("@kadi", p.KAdi);
            cmd.Parameters.AddWithValue("@sifre", p.Sifre);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        public bool KullaniciSil(Personeller p)
        {
            SqlCommand cmd = new SqlCommand("prc_Kullanici_TipSil", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", p.PersonelId);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }
    }
}
