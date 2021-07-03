using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Rapor(string prc,string path)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + path);
                report.Show();
            }
        }
        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            SatisRaporu sr = new SatisRaporu
            {
                MdiParent = this.MdiParent
            };
            sr.Show();
        }

        private void btnStokEklenen_Click(object sender, EventArgs e)
        {
            StokEklemeRaporu ser = new StokEklemeRaporu
            {
                MdiParent = this.MdiParent
            };
            ser.Show();
        }

        private void btnAlisRaporu_Click(object sender, EventArgs e)
        {
            StokAlisRaporu sar = new StokAlisRaporu
            {
                MdiParent = this.MdiParent
            };
            sar.Show();
        }

        private void btnStokRaporu_Click(object sender, EventArgs e)
        {
            StokRaporlari sp = new StokRaporlari
            {
                MdiParent = this.MdiParent
            };
            sp.Show();
        }

        private void btnAzKalanUrunRaporu_Click(object sender, EventArgs e)
        {
            Rapor("prc_Stok_StokMiktariRapor", "\\KalanStokRapor.FRX");
      
        }

        private void btnSKTGecenler_Click(object sender, EventArgs e)
        {
            Rapor("prc_Stok_SKTGecenUrunRaporu", "\\SKTRapor.FRX");
        }

        private void btnUrunListesiRaporu_Click(object sender, EventArgs e)
        {
            Rapor("prc_Urunler_UrunlerRaporu", "\\UrunlerRapor.FRX");
        }

        private void btnKasaRaporu_Click(object sender, EventArgs e)
        {
            KasaRaporu kr = new KasaRaporu
            {
                MdiParent = this.MdiParent
            };
            kr.Show();
        }

        private void btnGünlüCiroRapor_Click(object sender, EventArgs e)
        {
            Rapor("prc_SatisDetaylari_CiroRapor", "\\CiroRaporu.FRX");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
