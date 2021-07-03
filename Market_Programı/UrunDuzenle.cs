using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class UrunDuzenle : Form
    {
        private Urunler urun;
        public UrunDuzenle(Urunler u)
        {
            urun = u;
            InitializeComponent();
        }

        private void Combobox()
        {
            cboKategori.DataSource = KategoriORM.KategoriGetir();
            cboKategori.DisplayMember = "KategoriAdi";
            cboKategori.ValueMember = "KategoriId";

            cboToptanci.DataSource = TedarikciORM.TedarikciGetir();
            cboToptanci.DisplayMember = "SirketAdi";
            cboToptanci.ValueMember = "TedarikciId";
        }
        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            Combobox();
            txtBarkod.Text = urun.BarkodNo;
            txtUrunAdi.Text = urun.UrunAdi;
            txtStok.Text =urun.Stok.ToString();
            txtSatisFiyati.Text = urun.SatisFiyati.ToString();
            txtAlisFiyati.Text = urun.AlisFiyati.ToString();
            cboBirim.Text = urun.Birim;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunlerORM uORM = new UrunlerORM();
            urun.BarkodNo = txtBarkod.Text;
            urun.UrunAdi = txtUrunAdi.Text;
            urun.KategoriID =(int) cboKategori.SelectedValue;
            urun.TedarikciID =(int) cboToptanci.SelectedValue;
            urun.KalanStok =Convert.ToInt32(txtStok.Text);
            urun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            urun.AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
            urun.Birim = cboBirim.Text;
            urun.Stok =Convert.ToInt32(txtStok.Text);
            urun.Tarih = DateTime.Now;
            urun.SKTarih = dtpSonKullanmaTarihi.Value;
         bool deger= uORM.UrunGuncelle(urun);
            if (deger)
                MessageBox.Show("Ürün Güncellemesi Başarılı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Ürün Güncellemesi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            UrunlerORM.UrunSil(urun.UrunId);
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KategoriEkle"]==null)
            {
                KategoriEkle ke = new KategoriEkle
                {
                    MdiParent = this.MdiParent
                };
                ke.Show();
            }
        }
       private void btnToptancı_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["ToptancıEkle"] ==null)
            {
                ToptancıEkle te = new ToptancıEkle
                {
                    MdiParent = this.MdiParent
                };
                te.Show();
            }
           
        }
    }
}
