using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Toptanciİslemleri : Form
    {
        public Toptanciİslemleri()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bntToptanciEkle_Click(object sender, EventArgs e)
        {
            ToptancıEkle te = new ToptancıEkle
            {
                MdiParent = this.MdiParent
            };
            te.Show();
        }

        private void btnToptanciHesaplari_Click(object sender, EventArgs e)
        {
            ToptanciHesaplari th = new ToptanciHesaplari
            {
                MdiParent = this.MdiParent
            };
            th.Show();
        }

        private void btnTumBorçlar_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikci_TedarikciHesapRaporu", Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\TedarikciHesapRaporu.FRX");
                report.Show();
            }
        }
    }
}
