using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class NeredenBaslamaliyim : Form
    {
        public NeredenBaslamaliyim()
        {
            InitializeComponent();
        }

        private void Rapor(string prc, string path)
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            KategoriEkle ke = new KategoriEkle
            {
                MdiParent =this.MdiParent
            };
            ke.Show();
        }

        private void btnToptanciKaydet_Click(object sender, EventArgs e)
        {
            ToptancıEkle te = new ToptancıEkle
            {
                MdiParent=this.MdiParent
            };
            te.Show();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            UrunEkle ue = new UrunEkle
            {
                MdiParent = this.MdiParent
            };
            ue.Show();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {

        }

        private void btnAzKalanUrunler_Click(object sender, EventArgs e)
        {
            Rapor("prc_Stok_StokMiktariRapor", "\\KalanStokRapor.FRX");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            StokGir sg = new StokGir
            {
              MdiParent = this.MdiParent
            };
            sg.Show();
        }

        private void btnGunlukCiro_Click(object sender, EventArgs e)
        {
            SatisRaporu sr = new SatisRaporu
            {
                MdiParent = this.MdiParent
            };
            sr.Show();
        }

        private void btnKarBak_Click(object sender, EventArgs e)
        {
            StokRaporlari sr = new StokRaporlari
            {
                MdiParent=this.MdiParent
            };
            sr.Show();
        }

        private void btnMusteriAlacaklari_Click(object sender, EventArgs e)
        {
            Rapor("prc_Musteriler_MusteriGetir", "\\MusteriBorcRaporlari.FRX");
        }

        private void btnToptanciBorclari_Click(object sender, EventArgs e)
        {
            Rapor("prc_Tedarikciler_TedarikciGetir", "\\TedarikciRaporlari.FRX");
           
        }
    }
}
