using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class SatisRapor : Form
    {
        public SatisRapor()
        {
            InitializeComponent();
        }
        private void TarihArasıRapor(DateTime d1,DateTime d2)
        {
            try
            {
                using (Report report = new Report())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter("prc_SatisDetaylari_TarihGoreRapor", Tools.Baglanti);
                    adp.SelectCommand.Parameters.AddWithValue("@baslangic",d1);
                    adp.SelectCommand.Parameters.AddWithValue("@bitis", d2);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.Fill(dt);
                    report.RegisterData(dt, "dt");
                    report.Load(Application.StartupPath + "\\SatisRaporlari.FRX");
                    report.Show();
                    //report.Design();
                }
            }
            catch (Exception) {; }
        }

        private void btnRaprAl_Click(object sender, EventArgs e)
        {
            if (dtpİlkTarih.Checked == true)
                TarihArasıRapor(dtpİlkTarih.Value, dtpSonTarih.Value.AddDays(1));
            else
                MessageBox.Show("Lütfen Tarih Giriniz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnBugün_Click(object sender, EventArgs e)
        {
            TarihArasıRapor(DateTime.Now.AddDays(-1), DateTime.Now);
        }

        private void SatisRapor_Load(object sender, EventArgs e)
        {
           
        }

        private void dtpİlkTarih_ValueChanged(object sender, EventArgs e)
        {
            dtpİlkTarih.Checked = true;
        }

        private void btnBirHafta_Click(object sender, EventArgs e)
        {
            TarihArasıRapor(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1));
        }

        private void btnSonOtuzGün_Click(object sender, EventArgs e)
        {
            TarihArasıRapor(DateTime.Now.AddDays(-32), DateTime.Now);
        }

        private void btnSonBirYıl_Click(object sender, EventArgs e)
        {
            TarihArasıRapor(DateTime.Now.AddYears(-1), DateTime.Now);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
