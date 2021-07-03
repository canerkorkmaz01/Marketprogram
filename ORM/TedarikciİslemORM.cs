using Entity;
using System.Data;
using System.Data.SqlClient;


namespace ORM
{
    public  class TedarikciİslemORM
    {
        public static bool TedarikciİslemEkle(Tedarikciİslem ti)
        {
           SqlCommand cmd = new SqlCommand("prc_Tedarikciİslem_Ekle",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@Firma",ti.FirmaAdi);
            cmd.Parameters.AddWithValue("@islem",ti.İslem);
            cmd.Parameters.AddWithValue("@Borcu",ti.Borcun);
            cmd.Parameters.AddWithValue("@Aldiklarim",ti.Aldiklarim);
            cmd.Parameters.AddWithValue("@Odemeler",ti.Odemelerim);
            cmd.Parameters.AddWithValue("@Tarih",ti.Tarih);
            cmd.CommandType = CommandType.StoredProcedure;
            return Tools.Connect(cmd);
        }
    }
}
