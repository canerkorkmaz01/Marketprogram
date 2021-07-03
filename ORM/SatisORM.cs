using Entity;
using System.Data;
using System.Data.SqlClient;

namespace ORM
{
    public class SatisORM
    {
        /// <summary>
        /// Satışı Yapılan Ürünlerin Hangi Personel Hangi :Müşteriye Ne Satışmıştır
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool SatisEkle(Satislar s)
        {
            SqlCommand cmd = new SqlCommand("prc_Satislar_Ekle",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@sid",s.SatisDetayID);
            cmd.Parameters.AddWithValue("@mid",s.MusteriID);
            cmd.Parameters.AddWithValue("@pid",s.PersonelID);
            cmd.Parameters.AddWithValue("@tarih",s.SatisTarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }
    }
}
