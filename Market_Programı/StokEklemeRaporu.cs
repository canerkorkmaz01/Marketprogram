using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class StokEklemeRaporu : Form
    {
        public StokEklemeRaporu()
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
                report.Load(Application.StartupPath + "\\StokRapor.FRX");
                report.Show();
            }
        }

        private void btnBugün_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_BugunkuRaporlar");
        }

        private void btnBirHafta_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_BirHaftaRaporlar");
        }

        private void btnSonOtuzGün_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_SonOtuzGunRapor");
        }

        private void btnSonBirYıl_Click(object sender, EventArgs e)
        {
            Rapor("prc_StokBilgisi_SonBirYılRapor");
        }
        
        private void btnRaprAl_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_StokBilgisi_İkiTarihArası", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@baslangic", DateTime.Now);
                adp.SelectCommand.Parameters.AddWithValue("@bitis", DateTime.Now.AddDays(1));
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\StokRapor.FRX");
                report.Show();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
