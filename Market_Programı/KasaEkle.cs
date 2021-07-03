using Entity;
using ORM;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KasaEkle : Form
    {
        public KasaEkle()
        {
            InitializeComponent();
        }

        private void btnHesapMakinası_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void KasaEkle_Load(object sender, EventArgs e)
        {
            txtKasadaOlan.Text = KasaİslemORM.GelenKasaToplam().Rows[0]["GelenToplam"].ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNakitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kasaİslemleri ki = new Kasaİslemleri();
                ki.Aciklama = txtNakitEkle.Text;
                ki.OdemeTipi = "PEŞİN";
                ki.Gelen = Convert.ToDecimal(txtMiktar.Text);
                ki.Cikan = 0;
                ki.Tarih = DateTime.Now;
                ki.Durum = 1;
                bool deger = KasaİslemORM.KasaEkle(ki);
                if (deger)
                {
                    txtKasadaOlan.Text = KasaİslemORM.GelenKasaToplam().Rows[0]["GelenToplam"].ToString();
                    MessageBox.Show("NAKİT KASAYA EKLENDİ", "NAKİT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMiktar.Text = string.Empty;
                    txtNakitEkle.Text = string.Empty;
                }
                else MessageBox.Show("NAKİT EKLENİRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Tools.KasaRaporu = 1;
            KasaRaporu kr = new KasaRaporu
            {
                MdiParent=this.MdiParent
            };
            kr.Show();
        }
    }
}
