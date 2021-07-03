using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class ToptancıEkle : Form
    {
        public ToptancıEkle()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Girilien Bilgileri TedarikciORM TedarikciEkle Metotduna Gönderir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTopatanciKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tedarikciİslem ti = new Tedarikciİslem();
                
                Tedarikciler t = new Tedarikciler();
                ti.FirmaAdi = txtFirmaAdi.Text;
                ti.İslem = "Firma Kaydı";
                ti.Borcun = Convert.ToDecimal(txtBorc.Text);
                ti.Aldiklarim = 0;
                ti.Odemelerim = 0;
                ti.Tarih = DateTime.Now;
                t.SirketAdi = txtFirmaAdi.Text;
                t.Yetkili = txtYetkili.Text;
                t.Telefon = txtTelefon.Text;
                t.Email = txtMail.Text;
                t.WebSayfasi = txtWebSayfası.Text;
                t.Adres = txtAdres.Text;
                t.Borcun = Convert.ToDecimal(txtBorc.Text);
                t.Aldiklarim = 0;
                t.Odemelerim = 0;
                t.Tarih = DateTime.Now;
                bool deger = TedarikciORM.TedarikciEkle(t);
                bool deger2 = TedarikciİslemORM.TedarikciİslemEkle(ti);
                if (deger && deger2)
                {
                    MessageBox.Show("Toptancı Başarı İle Eklendi", "Toptancılar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("Toptancı Eklenirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ToptancıEkle_Load(object sender, EventArgs e)
        {
            txtTelefon.MaxLength = 11;
        }

        private void btnToptanciHesaplari_Click(object sender, EventArgs e)
        {
            ToptanciHesaplari th = new ToptanciHesaplari
            {
                MdiParent = this.MdiParent
            }; th.Show();
        }
    }
}
