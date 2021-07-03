using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class UrunİadeORM
    {
        /// <summary>
        /// Barkod Girilen Ürünler Tablosundaki Bilgileri Textboxlara Getirir
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public static DataTable İadeBilgisi(Urunİade ui)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_UrunIade_IadeEdilecekUrunBilgisi", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod",ui.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// İade Edilen Bilgilerini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable İadeBilgileri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunİade_İadeBilgisi", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// İade Tablsuna İade Bilgilerini Ekler
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public static bool İadeEkle(Urunİade ui)
        {
            SqlCommand cmd = new SqlCommand("prc_UrunIade_IadeEdilecekUrunEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@personelId", ui.PersonelID);
            cmd.Parameters.AddWithValue("@barkod", ui.BarkodNo);
            cmd.Parameters.AddWithValue("@urun", ui.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", ui.Fiyat);
            cmd.Parameters.AddWithValue("@miktar", ui.Miktar);
            cmd.Parameters.AddWithValue("@toplam", ui.Toplam);
            cmd.Parameters.AddWithValue("@İade", ui.İadeSebeb);
            cmd.Parameters.AddWithValue("@tarih", ui.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);

        }

        /// <summary>
        /// İade Bilgilerini Siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool İadeSil(int id)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunİade_İadeSil",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// İade Bilgilerini Günceller
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public static bool İadeGuncelle(Urunİade ui)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunİade_İadeGuncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", ui.İadeId);
            cmd.Parameters.AddWithValue("@barkod", ui.BarkodNo);
            cmd.Parameters.AddWithValue("@urunAdi", ui.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", ui.Fiyat);
            cmd.Parameters.AddWithValue("@miktar", ui.Miktar);
            cmd.Parameters.AddWithValue("@toplam", ui.Toplam);
            cmd.Parameters.AddWithValue("@sebebi", ui.İadeSebeb);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Son Bir Hafta İade Gelen Bilgisini Getirir
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public static DataTable SonBirHaftadaGelenİade()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunİade_SonBirHaftaİadeGelen", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son 1 Ayda Gelen İadeleri Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirAyGelenİade()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunİade_SonBirAyİadeGelen", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
    }
}
