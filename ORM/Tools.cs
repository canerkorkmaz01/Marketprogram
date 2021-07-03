using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ORM
{
    public class Tools
    {
        public static int Keypad { get; set; }
        public static bool UrunArama { get; set; }
        public static int btnTag { get; set; }
        public static int hizliSatisButon { get; set; } = 1;
        public static int PersonelID { get; set; }
        public static int KasaRaporu { get; set; }

        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection("Server = .; Database=MARKET; Integrated Security=true;");
                }
                return baglanti;
            }
           
        }

        public static bool Connect(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }
    }
}
