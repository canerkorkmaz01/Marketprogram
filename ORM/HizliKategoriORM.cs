using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class HizliKategoriORM
    {
        /// <summary>
        /// Hızlı Kategori Butonlarına Veritabnından Gelen Adlara Göre Textlerine Ekler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable HizliKategoriGetir(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_HizliKategori_HizliKategoriGetir", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@id", id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Hizli Kategori Eklemek İçin Kullanılan Metot
        /// </summary>
        /// <param name="hk"></param>
        public void HizliKategoriEkle(HizliKategori hk)
        {
            SqlCommand cmd = new SqlCommand("prc_HizliKategori_HizliKategoriEkle",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",HizliKategori.HizliKategoriId);
            cmd.Parameters.AddWithValue("@baslik",hk.HizliBaslik);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }

        /// <summary>
        /// Kategori Kaldır Formunda Combobox Kategorileri Listeler
        /// </summary>
        /// <returns></returns>
        public static DataTable HizliKategoriler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_HizliKategori_Getir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Seçilen Kategori Kaldırmak İçin Kullanılan Metot
        /// </summary>
        /// <param name="id"></param>
        public void KategoriKaldir(int id)
        {
            SqlCommand cmd = new SqlCommand("prc_HizliKategori_KategoriKaldir", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }
    }
}
