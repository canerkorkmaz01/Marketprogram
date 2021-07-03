using Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
   public class SatisDetayORM
    {
        /// <summary>
        /// Satışı Yapılan Ürünler SatışDetay Tablsonu Yazdırılır
        /// </summary>
        /// <param name="sd"></param>
        public void SatisDetaylariEkle(SatisDetaylari sd )
        {
                SqlCommand cmd = new SqlCommand("prc_SatisDetaylari_Ekle", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@barkod", sd.BarkodNo);
                cmd.Parameters.AddWithValue("@urunAdi", sd.UrunAdi);
                cmd.Parameters.AddWithValue("@fiyat", sd.BirimFiyat);
                cmd.Parameters.AddWithValue("@miktar", sd.Miktar);
                cmd.Parameters.AddWithValue("@toplam", sd.ToplamTutar);
                cmd.Parameters.AddWithValue("@satistürü", sd.SatisTürü);
                cmd.Parameters.AddWithValue("@indirim", sd.İndirim);
                cmd.Parameters.AddWithValue("@Kar", sd.Kar);
                cmd.Parameters.AddWithValue("@tarih", sd.Tarih);
                cmd.CommandType = CommandType.StoredProcedure;
                Tools.Connect(cmd);  
        }

        /// <summary>
        /// Satis Lisatesini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable SatisListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetaylari_SatislarıGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        ///  Girilen İsimlere Göre Arama Yapar
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable AdGoreSatisArama(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetay_AdGoreSatisArama", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@AdArama",sd.UrunAdi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Seçilen Satis Türüne Göre Arama Yapar
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable SatisTuruneGoreArama(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetaylari_SatisTuruneGoreArama",Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@satisTürü", sd.SatisTürü);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Seçilen Tarihe Göre Arama Yapar
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable SatisTarihGoreArama(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetaylari_SatisTarihGoreArama", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@baslangic", sd.Tarih);
            adp.SelectCommand.Parameters.AddWithValue("@bitis", sd.Tarih.AddDays(1));
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// İd Girilen Ürünleri Veritabanından Siler
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static bool SatisDetaySil(SatisDetaylari sd)
        {
            SqlCommand cmd = new SqlCommand("prc_SatisDetaylari_SatisSil",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",sd.SatisDetayId);
            cmd.CommandType = CommandType.StoredProcedure;
           return Tools.Connect(cmd);
        }

        /// <summary>
        /// Tüm Satışları Veritabnından Siler
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static bool SatisDetayTümünüSil()
        {
            SqlCommand cmd = new SqlCommand("prc_SatisDetaylari_SatisTümünüSil", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// SatisDetay Tablosundaki Verileri Güncellemek İçin Kullanılır
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static bool SatisDetayGuncelle(SatisDetaylari sd)
        {
            SqlCommand cmd = new SqlCommand("prc_SatisDetayları_SatislariGuncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",sd.SatisDetayId);
            cmd.Parameters.AddWithValue("@barkod",sd.BarkodNo);
            cmd.Parameters.AddWithValue("@urunAdi",sd.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat",sd.BirimFiyat);
            cmd.Parameters.AddWithValue("@miktar",sd.Miktar);
            cmd.Parameters.AddWithValue("@toplam",sd.BirimFiyat*sd.Miktar);
            cmd.Parameters.AddWithValue("@satisTürü",sd.SatisTürü);
            cmd.Parameters.AddWithValue("@indirim",sd.İndirim);
            cmd.Parameters.AddWithValue("@tarih",sd.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Barkod Girilen SatisDetyların İd Numarasını Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static int SatisDetayId(SatisDetaylari sd)
        {
            int id = 0;
            Tools.Baglanti.Open();
            SqlCommand cmd = new SqlCommand("prc_SatisDetaylari_BarkodGoreIDGetir", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@barkod", sd.BarkodNo);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                id =Convert.ToInt32(oku["SatisDetayId"]);
            }
            Tools.Baglanti.Close();
            return id;
        }

        /// <summary>
        /// Ürünler Tablsounda alıs Fiyatı ve Satis Fiyatından Çıkan Kar Bilgisini Getirir
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static decimal Kar(SatisDetaylari sd)
        {
            decimal kar = 0;
            Tools.Baglanti.Open();
            SqlCommand cmd = new SqlCommand("prc_Urunler_KarHesabi", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@barkod", sd.BarkodNo);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                kar =Convert.ToDecimal( oku["Kar"]);
            }
            Tools.Baglanti.Close();
            return kar;
        }
    }
}
