using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
   public class HizliSatisORM
    {
        public static int satisId { get; set; } = 1;

        /// <summary>
        /// İd Bilgisi Girilen Hızlı Satışlar Tablosundaki Ürün İsimlerini Butonun Text Özellgine 
        /// Ekler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable HizliSatisGetir(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_HizliSatis_HizliSatisGetir",Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@id",id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// id  Bilgisi Gelen Ürün Adı ve Barkod No Hizli Satışlar Tablosuna Ekleme İşlemi Yapar
        /// </summary>
        /// <param name="hs"></param>
        public void HizlSatisEkle(HizliSatis hs)
        {
            SqlCommand cmd = new SqlCommand("prc_HizliSatis_HizliSatisEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", hs.HizliSatisId);
            cmd.Parameters.AddWithValue("@barkod",hs.Barkod);
            cmd.Parameters.AddWithValue("@adi",hs.UrunAdi);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }

        /// <summary>
        /// Bakod No Girlen Ürünleri Ürünler Tablosundan Getirir
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public static DataTable HızlıSatisBarkod(HizliSatis hs)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunBarkodListele", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod", hs.Barkod);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Hızlı Satış İd Gelen Ürünün Barkod Adını Verir
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public static DataTable HizliSatisBarkodGetir(HizliSatis hs)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp=new SqlDataAdapter("prc_HizliSatis_BarkodGetir", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@id", hs.HizliSatisId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Hizli Satıştan Gelen Ürün Bilgisini Combobox Akatarır 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable HizliSatisListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_HizliSatis_SatislariGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Hızlı Satışları Kaldırmak İçin Kullanılan Metot
        /// </summary>
        /// <param name="id"></param>
        public void HizliSatisKaldir(int id)
        {
            SqlCommand cmd = new SqlCommand("prc_HizliSatis_HizliSatisKaldir", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }

    }
}
