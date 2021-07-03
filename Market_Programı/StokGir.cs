using Entity;
using ORM;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class StokGir : Form
    {
        public StokGir()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Textboxlar Boşmu Dolumu Kontrol Ediyor 
        /// </summary>
        /// <returns></returns>
        private bool Controller()
        {
            bool Deger = true;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    if (ctrl.Text == string.Empty)
                        Deger = false;
            }
            return Deger;
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StokGir_Load(object sender, System.EventArgs e)
        {
            txtBarkod.MaxLength = 13;
        }

        private void txtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunAdeti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTemizle_Click(object sender, System.EventArgs e)
        {
            txtUrunAdeti.BackColor = Color.White;
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                        ctrl.Text = string.Empty;
                }
            }
            catch (System.Exception) {; }
        }

        private void btnUrunAra_Click(object sender, System.EventArgs e)
        {
            StokUrunleri su = new StokUrunleri();
            su.TopLevel = false;
            panel1.Controls.Add(su);
            su.BringToFront();
            su.Show();
        }

        private void txtBarkod_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                Urunler u = new Urunler();
                u.BarkodNo = txtBarkod.Text;
                UrunlerORM.BarkodGoreUrunArama(u);
                txtUrunAdi.Tag = UrunlerORM.BarkodGoreUrunArama(u).Rows[0]["UrunID"].ToString();
                txtUrunAdi.Text = UrunlerORM.BarkodGoreUrunArama(u).Rows[0]["UrunAdi"].ToString();
                txtAlisFiyati.Text = UrunlerORM.BarkodGoreUrunArama(u).Rows[0]["AlisFiyati"].ToString();
                txtSatisFiyati.Text = UrunlerORM.BarkodGoreUrunArama(u).Rows[0]["SatisFiyati"].ToString();
                txtStok.Text = UrunlerORM.BarkodGoreUrunArama(u).Rows[0]["KalanStok"].ToString();
                txtUrunAdeti.BackColor = Color.Red;
                btnTamam.Enabled = true;
            }
            catch (Exception) {; }
        }

        private void btnKapat_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnTamam_Click(object sender, System.EventArgs e)
        {
                if (Controller())
                {
                    StokBilgisi sb = new StokBilgisi();
                    Urunler u = new Urunler();
                    u.UrunId = Convert.ToInt32(txtUrunAdi.Tag);
                    u.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
                    u.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                    u.KalanStok = Convert.ToInt32(txtUrunAdeti.Text);
                    btnTamam.Enabled = false;
                    sb.BarkodNo = txtBarkod.Text;
                    sb.UrunAdi = txtUrunAdi.Text;
                    sb.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
                    sb.SatisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
                    sb.GelenAdet = Convert.ToInt32(txtUrunAdeti.Text);
                    sb.StokMiktari = Convert.ToInt32(txtStok.Text);
                    sb.ToplamStok = sb.GelenAdet + sb.StokMiktari;
                    sb.Tarih = DateTime.Now;
                    bool deger = UrunlerORM.UrunStokEkle(u);
                    bool deger2 = StokBilgisiORM.StokEkle(sb);
                    if (deger & deger2)
                        MessageBox.Show("Gelen Ürün Stogunuza Eklenmiştir", "EKLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ürün Stogunuza Eklenirken Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnTemizle_Click(null, null);

                }
                else MessageBox.Show("Tüm Alanları Doldurnuz");
        }
    }
}
