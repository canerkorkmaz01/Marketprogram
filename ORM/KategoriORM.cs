using Entity;
using System.Data;
using System.Data.SqlClient;


namespace ORM
{
    public class KategoriORM
    {

        /// <summary>
        /// Veritabnından Kategori Bilgisini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable KategoriGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Kategoriler_KategoriGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Veritabnındaki Kategoriler Tablosuna Girilen Bilgileri Ekler
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool KategoriEkle(Kategoriler k)
        {
            SqlCommand cmd = new SqlCommand("prc_Kategoriler_Ekle",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@adi",k.KategoriAdi);
            cmd.Parameters.AddWithValue("@kdv",k.Kdv);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Veritabanından Kategorileri Siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool KategorGuncelle(Kategoriler k)
        {
            SqlCommand cmd = new SqlCommand("prc_Kategoriler_Guncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",k.KategoriId);
            cmd.Parameters.AddWithValue("@ad", k.KategoriAdi);
            cmd.Parameters.AddWithValue("@kdv",k.Kdv);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }
    }
}
