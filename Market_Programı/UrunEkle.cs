using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Comboxlara VeriTabanından Gelen Kategori ve Tedarikci Bilgilerini Ekler
        /// </summary>
        private void ComboBox()
        {
            cboKategori.DataSource = KategoriORM.KategoriGetir();
            cboKategori.DisplayMember = "KategoriAdi";
            cboKategori.ValueMember = "KategoriId";

            cboToptanci.DataSource = TedarikciORM.TedarikciGetir();
            cboToptanci.DisplayMember = "SirketAdi";
            cboToptanci.ValueMember = "TedarikciId";
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            txtBarkod.MaxLength = 13;
            cboBirim.SelectedIndex = 0;
            ComboBox();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Ürün Ekleme İşlemi Bittikten Sonra Urun Listesindeki Bilgileri
        /// Tazelemek İçin Kullanılan Metot 
        /// </summary>
        private void UrunBilgileriniTazele()
        {
            try
            {
                UrunListesi ul = (UrunListesi)Application.OpenForms["UrunListesi"];
                ul.UrunListele();
            }
            catch (Exception) {; }
           
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            UrunBilgileriniTazele();
            this.Dispose();
        }

        /// <summary>
        /// Girilen Verileri Ürünler Tablosuna Kaydeder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                UrunlerORM uORM = new UrunlerORM();
                Urunler u = new Urunler();
                u.TedarikciID = (int)cboToptanci.SelectedValue;
                u.KategoriID = (int)cboKategori.SelectedValue;
                u.BarkodNo = txtBarkod.Text;
                u.UrunAdi = txtUrunAdi.Text;
                u.KalanStok = Convert.ToInt32(txtStok.Text);
                u.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                u.AlisFiyati = Convert.ToInt32(txtAlisFiyati.Text);
                u.Birim = cboBirim.Text;
                u.Stok = Convert.ToInt32(txtStok.Text);
                u.Tarih = DateTime.Now;
                u.SKTarih = dtpSonKullanmaTarihi.Value;
                bool deger = uORM.UrunEkle(u);
                if (deger) MessageBox.Show("Ürün Kaydedildi", "Ürün Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Ürün Kaydedilirken Sorun Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UrunEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            UrunBilgileriniTazele();
            this.Dispose();
        }

        /// <summary>
        /// Girilen Bilgileri Veritabnına Kaydettikten Sonra Ürün Ekleme Sayfasını Kapatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydetCik_Click(object sender, EventArgs e)
        {
            btnKaydet_Click(null, null);
            UrunBilgileriniTazele();
            this.Dispose();
        }

        /// <summary>
        /// Ürün Ekle Formundaki Textboxları İçerigini Temizler
        /// </summary>
        private void ControllerClear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ControllerClear();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle ke = new KategoriEkle
            {
                MdiParent = this.MdiParent
            };
            ke.Show();

        }

        private void btnToptancı_Click(object sender, EventArgs e)
        {
            ToptancıEkle te = new ToptancıEkle
            {
                MdiParent =this.MdiParent
            };
            te.Show();
        }
    }
}
