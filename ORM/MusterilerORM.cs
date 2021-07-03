using Entity;
using System;
using System.Data;
using System.Data.SqlClient;


namespace ORM
{
    public class MusterilerORM
    {

        /// <summary>
        /// Veritabaından Müşteri Bilgisini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable MusterileriGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Musteriler_MusteriGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Veritabnından İd Girilen Müşterinin Borcunu Tek Sorgu Olarak Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static decimal MusterilerBorcGetir(int id)
        {
            decimal top = 0;
            Tools.Baglanti.Open();
            SqlCommand cmd = new SqlCommand("prc_Musteriler_MusteriBorcGetir", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", id);
            cmd. CommandType = CommandType.StoredProcedure;
            top =Convert.ToDecimal(cmd.ExecuteScalar());
            Tools.Baglanti.Close();
            return top;
        }

        /// <summary>
        /// Borç Bilgisi Üzerinden Güncelleme Yapılır
        /// </summary>
        /// <param name="id"></param>
        /// <param name="borc"></param>
        public void MusteriBorcEkle(int id, decimal borc)
        {
            SqlCommand cmd = new SqlCommand("prc_Musteriler_MusteriBorcEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@borc",borc);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }

        /// <summary>
        /// id Numarası Girilen Müşterinin Borç Bilgisini Getirir
        /// label Etiketlerinde Gösteririr
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable MusterilerBorcBilgisi(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Musteriler_BorcBilgisi", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@id",id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Veresiye Eklemek İçin Müşteri Adınanda Arama İşlemi Yapar
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static DataTable MusteriAra(Musteriler m)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Musteriler_MusteriAra", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@ad", m.Adi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Veritabnına Müşteri Eklemek İçin Kullanılır
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool MusteriEkle(Musteriler m)
        {
            SqlCommand cmd = new SqlCommand("prc_Musteriler_Ekle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@adi",m.Adi);
            cmd.Parameters.AddWithValue("@soyadi",m.Soyadi);
            cmd.Parameters.AddWithValue("@adres",m.Adres);
            cmd.Parameters.AddWithValue("@telefon",m.Telefonu);
            cmd.Parameters.AddWithValue("@borc",m.Borc);
            cmd.Parameters.AddWithValue("@limit", m.Limit);
            cmd.Parameters.AddWithValue("@tarih",m.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Borcu Olan Müşterilerin Listesini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable MusteriBorclari()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Musteriler_BorcuOlanlar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// İd bilgisi Gelen Müşterinin Müşteri Bilgisini Günceller
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool MusteriGuncelle(Musteriler m)
        {
            SqlCommand cmd = new SqlCommand("prc_Musteriler_Guncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",m.MusteriId);
            cmd.Parameters.AddWithValue("@adi",m.Adi);
            cmd.Parameters.AddWithValue("@soyadi",m.Soyadi);
            cmd.Parameters.AddWithValue("@adres",m.Adres);
            cmd.Parameters.AddWithValue("@telefon",m.Telefonu);
            cmd.Parameters.AddWithValue("@borc",m.Borc);
            cmd.Parameters.AddWithValue("@limit",m.Limit);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Müşteri Ödeme Yaptıgı Zaman Ödeme Bilgisinde Güncelleme Yapar
        /// </summary>
        /// <param name="m"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool MusteriOdeme(Musteriler m,decimal t)
        {
            SqlCommand cmd = new SqlCommand("prc_Musteriler_Odeme", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", m.MusteriId);
            cmd.Parameters.AddWithValue("@borcOdeme", m.BorcOdemeleri*2);
            cmd.Parameters.AddWithValue("@borc", m.Borc);
            cmd.Parameters.AddWithValue("@borcToplam", t);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// İd Gelen Müşterileri Veritabanından Silmek İçin Kullanılır
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool MusteriSil(Musteriler m)
        {
            SqlCommand cmd = new SqlCommand("prc_Musteriler_MusteriSil", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",m.MusteriId);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);

        }
    }

}
