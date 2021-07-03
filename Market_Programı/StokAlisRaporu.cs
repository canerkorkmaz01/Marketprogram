using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class StokAlisRaporu : Form
    {
        public StokAlisRaporu()
        {
            InitializeComponent();
        }

        private void Rapor(string prc)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\StokAlis.FRX");
                report.Show();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBugün_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_BugunkuStokRaporlari");
        }

        private void btnBirHafta_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_SonBirHaftaStokRaporlari");
        }

        private void btnSonOtuzGün_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_SonBirAyStokRaporlari");
        }

        private void btnSonBirYıl_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_SonBirAyStokRaporlari");
        }

        private void btnRaprAl_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_StokBilgisi_İkiTarihArasıRaporlari", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@baslangic",dtpİlkTarih.Value);
                adp.SelectCommand.Parameters.AddWithValue("@bitis",dtpSonTarih.Value.AddDays(1));
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\StokAlis.FRX");
                report.Show();
            }
        }
    }
}
