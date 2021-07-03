using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class KasaİslemORM
    {
       /// <summary>
       /// Veritabnına Nakit Kasa Bilgsini Ekler
       /// </summary>
       /// <param name="ki"></param>
       /// <returns></returns>
        public static bool KasaEkle(Kasaİslemleri ki)
        {
            SqlCommand cmd = new SqlCommand("prc_Kasaİslemleri_KasaGelen", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@Aciklama",ki.Aciklama);
            cmd.Parameters.AddWithValue("@Odeme",ki.OdemeTipi);
            cmd.Parameters.AddWithValue("@gelen",ki.Gelen);
            cmd.Parameters.AddWithValue("@cikan",ki.Cikan);
            cmd.Parameters.AddWithValue("@tarih",ki.Tarih);
            cmd.Parameters.AddWithValue("@durum",ki.Durum);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Kasada Bulunan Gelen Miktarın Toplamını Verir
        /// </summary>
        /// <returns></returns>
        public static DataTable GelenKasaToplam()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Kasaİslemleri_GelenToplamTutar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;      
        }

        /// <summary>
        /// Kasada Bulunan Cikan Miktarın Toplamını Verir 
        /// </summary>
        /// <returns></returns>
        public static DataTable CikanKasaToplam()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Kasaİslemleri_CikanToplamTutar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Kasada Bulunan Tümünü Toplamını Verir
        /// </summary>
        /// <returns></returns>
        public static DataTable KasaToplam()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Kasaİslemleri_ToplamTutar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Veritabnına Çıkan Kasa Bilgsini Ekler
        /// </summary>
        /// <param name="ki"></param>
        /// <returns></returns>
        public static bool KasaCikan(Kasaİslemleri ki)
        {
            SqlCommand cmd = new SqlCommand("prc_Kasaİslemleri_KasaCikan", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@Aciklama", ki.Aciklama);
            cmd.Parameters.AddWithValue("@Odeme", ki.OdemeTipi);
            cmd.Parameters.AddWithValue("@gelen", ki.Gelen);
            cmd.Parameters.AddWithValue("@cikan", ki.Cikan);
            cmd.Parameters.AddWithValue("@tarih", ki.Tarih);
            cmd.Parameters.AddWithValue("@durum", ki.Durum);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }
    }
}
