using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
   public class TedarikciORM
    {
        /// <summary>
        /// Veritabnından Tedarikçi Bilgisini Getirir
        /// </summary>
        /// <returns></returns>
        public static DataTable TedarikciGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikciler_TedarikciGetir", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Girilen Bilgileri Veritabanındaki Tedarikciler  Tablosuna Ekler
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool TedarikciEkle(Tedarikciler t)
        {
            SqlCommand cmd = new SqlCommand("prc_Tedarikciler_Ekle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@sirketadi",t.SirketAdi);
            cmd.Parameters.AddWithValue("@yetkili",t.Yetkili);
            cmd.Parameters.AddWithValue("@telefon",t.Telefon);
            cmd.Parameters.AddWithValue("@web",t.WebSayfasi);
            cmd.Parameters.AddWithValue("@adres",t.Adres);
            cmd.Parameters.AddWithValue("@mail", t.Email);
            cmd.Parameters.AddWithValue("@borcun",t.Borcun);
            cmd.Parameters.AddWithValue("@aldiklarim",t.Aldiklarim);
            cmd.Parameters.AddWithValue("@odemlerim",t.Odemelerim);
            cmd.Parameters.AddWithValue("@tarih",t.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
           return Tools.Connect(cmd);

        }

        /// <summary>
        /// Tedarikci Tablsounda Odemeleri Ekler Borç Azaltma Yapar
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool TedarikciBorcEkle(Tedarikciler t)
        {
            SqlCommand cmd = new SqlCommand("prc_Tedarikci_BorcEkle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",t.TedarikciId);
            cmd.Parameters.AddWithValue("@Odeme",t.Odemelerim);
            cmd.Parameters.AddWithValue("@borc",t.Borcun);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Tedarikci Tablsounda Aldıklarıma Borç Ekler
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool TedarikciAldiklarim(Tedarikciler t)
        {
            SqlCommand cmd = new SqlCommand("prc_Tedarikci_UrunAl", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", t.TedarikciId);
            cmd.Parameters.AddWithValue("@aldiklarim", t.Aldiklarim);
            cmd.Parameters.AddWithValue("@borc", t.Borcun);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Tedarikciler Tablosunda İade İşlemleri Yapar
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool TedarikciİadeVer(Tedarikciler t)
        {
            SqlCommand cmd = new SqlCommand("prc_Tedarikci_İadeVer", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id", t.TedarikciId);
            cmd.Parameters.AddWithValue("@aldiklarim", t.Aldiklarim);
            cmd.Parameters.AddWithValue("@borc", t.Borcun);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }

        /// <summary>
        /// Tedarikci Bilgilerini Güncellemeek İçin Kullanılır
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool TedarikciGuncelle(Tedarikciler t)
        {
            SqlCommand cmd = new SqlCommand("prc_Tedarikci_Guncelle", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@id",t.TedarikciId);
            cmd.Parameters.AddWithValue("@firma",t.SirketAdi);
            cmd.Parameters.AddWithValue("@yetkili",t.Yetkili);
            cmd.Parameters.AddWithValue("@tel",t.Telefon);
            cmd.Parameters.AddWithValue("@adres",t.Adres);
            cmd.Parameters.AddWithValue("@mail",t.Email);
            cmd.Parameters.AddWithValue("@web",t.WebSayfasi);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);

        }

        /// <summary>
        /// Tedarikci Bilgisini Veritabnında Arama Yapar
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static DataTable TedarikciAra(Tedarikciler t)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikci_TedarikciAra", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@ad",t.SirketAdi);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

    }
}
