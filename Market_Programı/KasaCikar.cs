using Entity;
using ORM;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KasaCikar : Form
    {
        public KasaCikar()
        {
            InitializeComponent();
        }

        private void OdemeYeriTuru()
        {
            cboOdemeYeri.Items.AddRange(Enum.GetNames(typeof(KasaEnum.Odeme)));
            cboOdemeTuru.Items.AddRange(Enum.GetNames(typeof(KasaEnum.Kasa)));
            cboOdemeTuru.SelectedIndex = 0;
            cboOdemeYeri.SelectedIndex = 0;
        }
        private void KasaCikar_Load(object sender, EventArgs e)
        {
            OdemeYeriTuru();
            txtKasadaOlan.Text = KasaİslemORM.CikanKasaToplam().Rows[0]["CikanToplam"].ToString();
        }

        /// <summary>
        /// Kasadan Çıkan Raporları Verir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRapor_Click(object sender, EventArgs e)
        {
            KasaRaporu kp = new KasaRaporu
            {
                MdiParent = this.MdiParent
            };
            kp.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHesapMakinası_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        /// <summary>
        ///Kasadan Çıkan Miktar Bilgisini Veritabnına Gönderir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNakitCikar_Click(object sender, EventArgs e)
        {
            try
            {
                Kasaİslemleri ki = new Kasaİslemleri();
                ki.Aciklama = cboOdemeYeri.Text;
                ki.OdemeTipi = cboOdemeYeri.Text;
                ki.Gelen = 0;
                ki.Cikan = Convert.ToDecimal(txtMiktar.Text);
                ki.Tarih = DateTime.Now;
                ki.Durum = 0;
                bool deger = KasaİslemORM.KasaEkle(ki);
                if (deger)
                {
                    txtKasadaOlan.Text = KasaİslemORM.CikanKasaToplam().Rows[0]["CikanToplam"].ToString();
                    MessageBox.Show("KASADAN ÖDEME YAPILDI", "ODEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMiktar.Text = string.Empty;
                    cboOdemeTuru.SelectedIndex = 0;
                    cboOdemeYeri.SelectedIndex = 0;
                }
                else MessageBox.Show("KASADAN ÖDEME YAPARKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
