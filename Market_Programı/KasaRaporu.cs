using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KasaRaporu : Form
    {
        public KasaRaporu()
        {
            InitializeComponent();
        }
        private void KasaToplam()
        {
            if(Tools.KasaRaporu == 1)
                txtKasadaOlan.Text = KasaİslemORM.GelenKasaToplam().Rows[0]["GelenToplam"].ToString();
            else if(Tools.KasaRaporu == 0)
                txtKasadaOlan.Text = KasaİslemORM.CikanKasaToplam().Rows[0]["CikanToplam"].ToString();
            else if (Tools.KasaRaporu == 2)
                txtKasadaOlan.Text = KasaİslemORM.KasaToplam().Rows[0]["ToplamTutar"].ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void KasaRaporu_Load(object sender, EventArgs e)
        {
            KasaToplam();
        }

        private void TarihArasıRapor(DateTime d1, DateTime d2,string prc,string k)
        {
            try
            {
                using (Report report = new Report())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                    adp.SelectCommand.Parameters.AddWithValue("@baslangic", d1);
                    adp.SelectCommand.Parameters.AddWithValue("@bitis", d2);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.Fill(dt);
                    report.RegisterData(dt, "dt");
                    report.Load(Application.StartupPath + k);
                    report.Show();
                    //report.Design();
                }
            }
            catch (Exception) {; }
        }

        private void btnRaprAl_Click(object sender, EventArgs e)
        {
            if (Tools.KasaRaporu == 1)
             TarihArasıRapor(dtpİlkTarih.Value, dtpSonTarih.Value.AddDays(1),"prc_Kasaİslemleri_TarihGoreRaporGelen", "\\KasaGelen.FRX");
            else if (Tools.KasaRaporu == 0)
                TarihArasıRapor(dtpİlkTarih.Value, dtpSonTarih.Value.AddDays(1), "prc_Kasaİslemleri_TarihGoreRaporCikan", "\\KasaCikan.FRX");
            else if (Tools.KasaRaporu == 2)
                TarihArasıRapor(dtpİlkTarih.Value, dtpSonTarih.Value.AddDays(1), "prc_Kasaİslemleri_TarihGoreKasaRapor", "\\KasaRapor.FRX");
        }

        private void btnBugün_Click(object sender, EventArgs e)
        {
            if (Tools.KasaRaporu == 1)
                TarihArasıRapor(DateTime.Now.AddDays(-1), DateTime.Now,"prc_Kasaİslemleri_TarihGoreRaporGelen", "\\KasaGelen.FRX");
            else if (Tools.KasaRaporu == 0)
                TarihArasıRapor(DateTime.Now.AddDays(-1), DateTime.Now, "prc_Kasaİslemleri_TarihGoreRaporCikan", "\\KasaCikan.FRX");
            else if (Tools.KasaRaporu == 2)
                TarihArasıRapor(DateTime.Now.AddDays(-1), DateTime.Now, "prc_Kasaİslemleri_TarihGoreKasaRapor", "\\KasaRapor.FRX");
        }

        private void btnBirHafta_Click(object sender, EventArgs e)
        {
            if (Tools.KasaRaporu == 1)
                TarihArasıRapor(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1),"prc_Kasaİslemleri_TarihGoreRaporGelen", "\\KasaGelen.FRX");
           else if (Tools.KasaRaporu == 0)
                TarihArasıRapor(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1), "prc_Kasaİslemleri_TarihGoreRaporCikan", "\\KasaCikan.FRX");
            else if (Tools.KasaRaporu == 2)
                TarihArasıRapor(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1), "prc_Kasaİslemleri_TarihGoreKasaRapor", "\\KasaRapor.FRX");
        }

        private void btnSonOtuzGün_Click(object sender, EventArgs e)
        {
            if (Tools.KasaRaporu == 1)
                TarihArasıRapor(DateTime.Now.AddDays(-32), DateTime.Now,"prc_Kasaİslemleri_TarihGoreRaporGelen", "\\KasaGelen.FRX");
            else if (Tools.KasaRaporu == 0)
                TarihArasıRapor(DateTime.Now.AddDays(-32), DateTime.Now, "prc_Kasaİslemleri_TarihGoreRaporCikan", "\\KasaCikan.FRX");
            else if (Tools.KasaRaporu == 2)
                TarihArasıRapor(DateTime.Now.AddDays(-32), DateTime.Now, "prc_Kasaİslemleri_TarihGoreKasaRapor", "\\KasaRapor.FRX");
        }

        private void btnSonBirYıl_Click(object sender, EventArgs e)
        {
            if (Tools.KasaRaporu == 1)
                TarihArasıRapor(DateTime.Now.AddYears(-1), DateTime.Now,"prc_Kasaİslemleri_TarihGoreRaporGelen", "\\KasaGelen.FRX");
            else if (Tools.KasaRaporu == 0)
                TarihArasıRapor(DateTime.Now.AddYears(-1), DateTime.Now,"prc_Kasaİslemleri_TarihGoreRaporCikan", "\\KasaCikan.FRX");
            else if (Tools.KasaRaporu == 2)
                TarihArasıRapor(DateTime.Now.AddYears(-1), DateTime.Now, "prc_Kasaİslemleri_TarihGoreKasaRapor", "\\KasaRapor.FRX");
        }
    }
}
