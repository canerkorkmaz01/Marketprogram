using Entity;
using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class MusteriDuzenle : Form
    {
        private Musteriler musteriler;
        public MusteriDuzenle(Musteriler m)
        {
            InitializeComponent();
            musteriler = m;
        }
        /// <summary>
        /// Form Arasına Ayıraç Koymak İçin Kullanılır
        /// </summary>
        private void Cizgi()
        {
            label10.AutoSize = false;
            label10.Width = 700;
            label10.Height = 3;
            label10.BorderStyle = BorderStyle.Fixed3D;
        }
        private void MusteriDuzenle_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            txtTelefon.MaxLength = 11;
            txtMusteriAdi.Text = musteriler.Adi;
            txtSoyadi.Text = musteriler.Soyadi;
            txtTelefon.Text = musteriler.Telefonu;
            txtAdres.Text = musteriler.Adres;
            txtBorc.Text = musteriler.Borc.ToString();
            txtLimit.Text = musteriler.Limit.ToString();
            txtMBorcu.Text = musteriler.Borc.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                musteriler.Adi = txtMusteriAdi.Text;
                musteriler.Soyadi = txtSoyadi.Text;
                musteriler.Telefonu = txtTelefon.Text;
                musteriler.Adres = txtAdres.Text;
                musteriler.Borc = Convert.ToDecimal(txtBorc.Text);
                musteriler.Limit = Convert.ToDecimal(txtLimit.Text);
                bool deger = MusterilerORM.MusteriGuncelle(musteriler);
                if (deger)
                {
                    MessageBox.Show("MÜŞTERİ GÜNCELLEME BAŞARILI", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else MessageBox.Show("MÜŞTERİ GÜNCELLENİRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtMBorcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtOdediğiTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("MÜŞTERİNİN ÖDEMESİNİ ONAYLIYORMUSUNUZ!","öDEME",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {
                decimal bt = Convert.ToDecimal(txtOdediğiTutar.Text);
                musteriler.BorcOdemeleri = Convert.ToDecimal(txtOdediğiTutar.Text);
                musteriler.Borc = Convert.ToDecimal(txtBorc.Text);
                bool deger = MusterilerORM.MusteriOdeme(musteriler,bt);
                if (deger)
                {
                    MessageBox.Show("MÜŞTERİ ODEMESİ BAŞARILI", "ODEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else MessageBox.Show("MÜŞTERİ ODEMEDE HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RaporAl(string prc, DateTime dtp1,DateTime dtp2,string pat)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@id", musteriler.MusteriId);
                adp.SelectCommand.Parameters.AddWithValue("@baslangic", dtp1);
                adp.SelectCommand.Parameters.AddWithValue("@bitis", dtp2.AddDays(1));
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + pat);
                report.Show();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporAl("prc_MusteriSatislari_Raporlari",dtpTarih1.Value,dtpTarih2.Value, "\\MusteriAldiklariRapor.FRX");
        }

        private void btnOdemeRapor_Click(object sender, EventArgs e)
        {
            RaporAl("prc_MusterilerBorc_Raporlari", dtpTarih3.Value, dtpTarih4.Value, "\\MusteriOdemeBilgisi.FRX");
        }
    }
}
