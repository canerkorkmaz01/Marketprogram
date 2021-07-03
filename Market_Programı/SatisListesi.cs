using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class SatisListesi : Form
    {
        public SatisListesi()
        {
            InitializeComponent();
        }

        private void SatisDetaylari()
        {
            dataGridView1.DataSource = SatisDetayORM.SatisListesi();
            Tables.DataGridViewSatisDetaylari(dataGridView1);
          
        }

        private void SatisListesi_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            SatisDetaylari();
            cboSatisAra.Items.AddRange(Enum.GetNames(typeof(SatisTürleri.SatisTürü)));
            lblToplam.Text = "TOPLAM SATIŞLAR" + "  " + ToplamSatis().ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAdArama_TextChanged(object sender, EventArgs e)
        {
            SatisDetaylari sd = new SatisDetaylari();
            sd.UrunAdi = txtAdArama.Text;
            dataGridView1.DataSource = SatisDetayORM.AdGoreSatisArama(sd);
            Tables.DataGridViewSatisDetaylari(dataGridView1);
        }

        /// <summary>
        /// Combobox içinde Seçilen Satış Türüne Göre Arama Yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cboSatisAra.SelectedIndex != -1)
            {
                SatisDetaylari sd = new SatisDetaylari();
                sd.SatisTürü = cboSatisAra.Text;
                dataGridView1.DataSource = SatisDetayORM.SatisTuruneGoreArama(sd);
            }
            

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SatisDetaylari();
            cboSatisAra.SelectedIndex = 0;
            txtAdArama.Clear();
        }

        /// <summary>
        /// Girilen Tarihdeki Satışları Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            SatisDetaylari sd = new SatisDetaylari();
            sd.Tarih = dtpTarih.Value;
            dataGridView1.DataSource= SatisDetayORM.SatisTarihGoreArama(sd);
            Tables.DataGridViewSatisDetaylari(dataGridView1);
        }

        /// <summary>
        /// Seçilen Satışları Siler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("SEÇİLEN SATIŞI SİLMEK İSTEDİĞİNZE EMİNİSİNİZ","SATIŞ SİL",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (resul == DialogResult.OK)
            {
                SatisDetaylari sd = new SatisDetaylari();
                sd.SatisDetayId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                SatisDetayORM.SatisDetaySil(sd);
                SatisDetaylari();
                lblToplam.Text = "TOPLAM SATIŞLAR" + "  " + ToplamSatis().ToString();
            }
            
        }

        /// <summary>
        /// Tüm Satis Detayları Siler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTümünSil_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("TÜM SATIŞLARI SİLMEK İSTEDİGİNİZE EMİNİSİNİZ", "TÜMÜNÜ SİL ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resul == DialogResult.OK)
            {
                SatisDetayORM.SatisDetayTümünüSil();
                SatisDetaylari();
                lblToplam.Text = "TOPLAM SATIŞLAR" + "  " + ToplamSatis().ToString();
            }
        }
        /// <summary>
        /// DatagridViewdeki Toplam Ürünlerin Saysını Verir
        /// </summary>
        /// <returns></returns>
        private int ToplamSatis()
        {
            int Satis = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Satis = i;
            }
            return Satis;
        }

        private void btnSatisRaporlari_Click(object sender, EventArgs e)
        {
            SatisRapor sp = new SatisRapor
            {
                MdiParent =this.MdiParent
            };
            sp.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SatisDuzenle sd = new SatisDuzenle
            {
                MdiParent =this.MdiParent
            };
            sd.Show();
        }
    }
}
