using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriler m = new Musteriler();
                m.Adi = txtAdi.Text;
                m.Soyadi = txtSoyadi.Text;
                m.Adres = txtAdres.Text;
                m.Telefonu = txtTelefonu.Text;
                m.Borc = Convert.ToDecimal(txteskiBorc.Text);
                m.Limit = Convert.ToDecimal(txtLimit.Text);
                m.Tarih = DateTime.Now;
                bool deger = MusterilerORM.MusteriEkle(m);
                if (deger)
                    MessageBox.Show("Müşteri Bilgisi Başarıyla Eklendi", "MÜŞTERİ EKLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Müşteri Bilgisini Eklenirken Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MusteriTemizle();
        }

        private void txtTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txteskiBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            txtTelefonu.MaxLength = 11;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMüsteriHesaplari_Click(object sender, EventArgs e)
        {
            MusteriHesaplari mh = new MusteriHesaplari
            {
               MdiParent = this.MdiParent
            };
            mh.Show();
        }

        private void MusteriTemizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
            }
        }
    }
}
