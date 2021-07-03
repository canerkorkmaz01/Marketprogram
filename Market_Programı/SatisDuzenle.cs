using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class SatisDuzenle : Form
    {
        public SatisDuzenle()
        {
            InitializeComponent();
        }

        private void SatisDuzenle_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            txtBarkod.MaxLength = 13;
            cboSatisTürü.Items.AddRange(Enum.GetNames(typeof(SatisTürleri.SatisTürü)));
            dataGridView1.DataSource = SatisDetayORM.SatisListesi();
            Tables.DataGridViewSatisDetaylariDuzenle(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrun.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboSatisTürü.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtToplam.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtIndirim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';

        }

        private void txtToplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SatisDetaylari sd = new SatisDetaylari();
            sd.SatisDetayId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            sd.BarkodNo = txtBarkod.Text;
            sd.UrunAdi = txtUrun.Text;
            sd.BirimFiyat =Convert.ToDecimal(txtFiyat.Text);
            sd.Miktar = Convert.ToInt32(txtAdet.Text);
            sd.ToplamTutar = Convert.ToDecimal(txtToplam.Text);
            sd.SatisTürü = cboSatisTürü.Text;
            sd.İndirim = Convert.ToDecimal(txtIndirim.Text);
            sd.Tarih = DateTime.Now;
           bool deger=SatisDetayORM.SatisDetayGuncelle(sd);
            if (deger)
            {
                dataGridView1.DataSource = SatisDetayORM.SatisListesi();
                Tables.DataGridViewSatisDetaylariDuzenle(dataGridView1);
                MessageBox.Show("Satis Güncelleme Başarılı","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           else MessageBox.Show("Satis Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtIndirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
