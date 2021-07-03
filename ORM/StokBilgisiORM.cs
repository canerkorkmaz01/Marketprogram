using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class StokBilgisiORM
    {
        /// <summary>
        /// Stok Ürün Ekler
        /// </summary>
        /// <param name="sb"></param>
        /// <returns></returns>
        public static bool StokEkle(StokBilgisi sb)
        {
            SqlCommand cmd = new SqlCommand("prc_StokBilgisi_StokEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@barkod",sb.BarkodNo);
            cmd.Parameters.AddWithValue("@urunAdi",sb.UrunAdi);
            cmd.Parameters.AddWithValue("@alisFiyati",sb.AlisFiyati);
            cmd.Parameters.AddWithValue("@satisFiyati",sb.SatisFiyati);
            cmd.Parameters.AddWithValue("@gelenAdet",sb.GelenAdet);
            cmd.Parameters.AddWithValue("@stokMikatri",sb.StokMiktari);
            cmd.Parameters.AddWithValue("@toplamStok",sb.ToplamStok);
            cmd.Parameters.AddWithValue("@tarih",sb.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Stok Bilgisi Getrir 
        /// </summary>
        /// <returns></returns>
        public static DataTable StokUrunMaliyeti()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Stok_StokUrunMaliyetiRapor",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Stok Ürün Satis Bilgisini Getirir 
        /// </summary>
        /// <returns></returns>
        public static DataTable StokUrunSatis()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Stok_StokUrunSatisRapor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Stok Satis Kar Tutari
        /// </summary>
        /// <returns></returns>
        public static DataTable StokSatisKarRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Stok_SatisKarTutariRapor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Toplam Urun Raporu
        /// </summary>
        /// <returns></returns>
        public static DataTable StokToplamUrunRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Stok_ToplamUrunSayisiRapor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
    }
}

