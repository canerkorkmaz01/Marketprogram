using Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
   public class SatisRaporlariORM
    {
        /// <summary>
        /// Bugün Satış Yapılan Ürünleri Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable BugunSatisRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_BugünküSatışRaporlari", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Bugün Yapılan Nakit Satışlarını Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable BugunNakitRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_BugünküPesinSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Bugün Yapılan Pos Satışlarını Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable BugunPosRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_BugünküPosSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son Bir Haftaki Raporları Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirHaftaRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirHaftaSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son Bir Hafta Nakit Raporları Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirHaftaNakitRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirHaftaNakitSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son Bir Hafta Pos Raporları Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirHaftaPosRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirHaftaPosSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son 1 Aylık Satış Raporları
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirAySatisRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirAySatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son 1 Aylık Nakit Yapılan Satışlar
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirAyNakitSatisRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirAyNakitSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Son 1 Ayda Yapılan Pos Satışlar
        /// </summary>
        /// <returns></returns>
        public static DataTable SonBirAyPosSatisRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_SonBirAyPosSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// İki Tarih Arası Raporları Getirir
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static DataTable İkiTarihArası(DateTime d1,DateTime d2)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_İkiTarihArasıSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@baslangic", d1);
            adp.SelectCommand.Parameters.AddWithValue("@bitis", d2);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Barkoda Göre Raporları Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable BarkodaGoreSatisRapor(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_BarkodSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod",sd.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Urun Adına Göre Raporları Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable UrunAdınaGoreSatisRapor(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_UrunAdıSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@adi", sd.UrunAdi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Turune Göre Raporları Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable TuruneGoreSatisRapor(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_TuruneGoreSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@satis", sd.SatisTürü);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Personel Adına Göre Rapor Getirir
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable PersonelAdıSatisRapor(Personeller p)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Satislar_PersoneleGoreSatisRaporları", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@personelAdi",p.Adi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tüm Satis Raporlarini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable TumSatisRapor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetaylari_TumSatislar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
    }
}
