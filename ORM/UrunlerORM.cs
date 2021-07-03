using Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class UrunlerORM
    {
       public static DataTable dt = new DataTable();

        /// <summary>
        /// Barkodu Okutulan Ürünün Fiyatını Ögrenmek İçin Kullanılan Metot
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static DataTable UrunFiyatıGor(Urunler u)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunFiyatiniGor", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod",u.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Ürünler Bilgisini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable Urunler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunleriGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Veritabanındaki Ürünü Adına Göre Arama Yapar
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static DataTable UrunArama(Urunler u)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunArama", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@ad",u.UrunAdi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Girilen Barkod Numarasına Göre Ürünleri Listeler
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static DataTable UrunListele(Urunler u)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunBarkodListele", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod", u.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Satisi Yapılan Ürünleri Stok Düşürmek İçin Kullanılan Metot
        /// </summary>
        /// <param name="sd"></param>
        public static void StokAzalat(SatisDetaylari sd)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_StokAzalat", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@barkod", sd.BarkodNo);
            cmd.Parameters.AddWithValue("@stokazalt", sd.Miktar);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.Connect(cmd);
        }

        /// <summary>
        /// Ürünler Tablsoundaki Stok Miktarının Bilgisini Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static int StokMiktariGetir(SatisDetaylari sd)
        {
            int stok =0;
            try
            {
                Tools.Baglanti.Open();
                SqlCommand cmd = new SqlCommand("prc_Urunler_StokMiktariniGetir", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@barkod", sd.BarkodNo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    stok = Convert.ToInt32(oku["KalanStok"]);
                }
                Tools.Baglanti.Close();
            }
            catch (Exception) {; }
          
            return stok;
        }
        /// <summary>
        /// Barkod Bilgisi Girilen Ürünün Stok 0 Olan Ürünlerin Adını Getirir
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DataTable StokUrunAdi(SatisDetaylari sd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_StokUrunAdi", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod", sd.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Ürün Bilgisini joinle Tedarikçi ve Kategorilerleri ile Birlikte Listesini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable UrunListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunListesi", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Ürünleri Veritabnına Kaydeder
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool UrunEkle(Urunler u)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_UrunEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@tedId",u.TedarikciID);
            cmd.Parameters.AddWithValue("@katId",u.KategoriID);
            cmd.Parameters.AddWithValue("@barkod",u.BarkodNo);
            cmd.Parameters.AddWithValue("@urunAdi",u.UrunAdi);
            cmd.Parameters.AddWithValue("@kalanstok",u.KalanStok);
            cmd.Parameters.AddWithValue("@satisFiyati",u.SatisFiyati);
            cmd.Parameters.AddWithValue("@alisFiyati",u.AlisFiyati);
            cmd.Parameters.AddWithValue("@birim",u.Birim);
            cmd.Parameters.AddWithValue("@stok",u.Stok);
            cmd.Parameters.AddWithValue("@tarih",u.Tarih);
            cmd.Parameters.AddWithValue("@sktTarih",u.SKTarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// id Girilen Ürünleri Veritabnından Silmek İçin Kullanılır
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UrunSil(int id)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_UrunSil", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Seçilen Ürünleri Güncellemek İçin Kullanılır
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool UrunGuncelle(Urunler u)
        {
            SqlCommand cmd= new SqlCommand("prc_Urunler_Guncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", u.UrunId);
            cmd.Parameters.AddWithValue("@barkod", u.BarkodNo);
            cmd.Parameters.AddWithValue("@urunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@katId", u.KategoriID);
            cmd.Parameters.AddWithValue("@tedId", u.TedarikciID);
            cmd.Parameters.AddWithValue("@kalanStok", u.KalanStok);
            cmd.Parameters.AddWithValue("@satisFiyati", u.SatisFiyati);
            cmd.Parameters.AddWithValue("@alisFiyati", u.AlisFiyati);
            cmd.Parameters.AddWithValue("@birim", u.Birim);
            cmd.Parameters.AddWithValue("@stok", u.Stok);
            cmd.Parameters.AddWithValue("@tarih", u.Tarih);
            cmd.Parameters.AddWithValue("@sktTarih", u.SKTarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Girilen İsim bilgisine Göre Veritabanında Arama Yapar
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static DataTable AdGoreUrunArama(Urunler u)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_AdArama",Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@adi",u.UrunAdi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Girilen Barkod bilgisine Göre Veritabanında Arama Yapar
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static DataTable BarkodGoreUrunArama(Urunler u)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_BarkodArama", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@barkod", u.BarkodNo);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Urunler Tablsoundaki Urunlere Stok Eklemek İçin Kullanılır
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool UrunStokEkle(Urunler u)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_StokEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",u.UrunId);
            cmd.Parameters.AddWithValue("@alisFiyati",u.AlisFiyati);
            cmd.Parameters.AddWithValue("@satisFiyati",u.SatisFiyati);
            cmd.Parameters.AddWithValue("@kalanstok",u.KalanStok);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Ürünler Listesini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable UrunListesiniExcelAktar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_UrunleriExcelAktar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        /// <summary>
        /// Müşteri Lisesini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable MusteriListesiniExcelAktar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Musteriler_MusterileriExcelAktar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }

        public static DataTable ToptanciListesiniExcelAktar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikciler_ExcelAktar", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            Tools.Baglanti.Close();
            return dt;
        }
    }
}
