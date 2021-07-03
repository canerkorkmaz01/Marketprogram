using Microsoft.Win32;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class MarketOtomasyonu : Form
    {

        public MarketOtomasyonu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Personellere Yetkisini Belirler
        /// </summary>
        private void PersonelYetkisi()
        {
            if(Tools.PersonelID == 1)
            {
                btnKasa.Enabled = true;
                btnRapor.Enabled = true;
                btnKullanicilar.Enabled = true;
                btnServis.Enabled = true;
            }
            else if(Tools.PersonelID == 2)
            {
                btnKasa.Enabled = false;
                btnRapor.Enabled = false;
                btnKullanicilar.Enabled = false;
                btnServis.Enabled = false;
            }
        }

        /// <summary>
        /// Servisler Menüsündeki Butonların Demo Sürümünde Pasif Yapıyor
        /// </summary>
        private void Servis()
        {
            Servis servis= (Servis)Application.OpenForms["Servis"];

            foreach (Control btn in servis.Controls)
            {
                if (btn is Button)
                {
                    if (btn.Text != "LİSANSLAMA")
                    {
                        btn.Enabled = false;
                    }
                }
            }
        }

        Satis s = new Satis();
        private void SatişForm()
        {
            if (s.IsDisposed)
            s = new Satis();
            s.MdiParent = this;
            s.Show();
        }
        private void MarketOtomasyonu_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            SatişForm();
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ads");
            if (Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "1")
            {
                FormText.FormTextPozisyonu(this, "DENEME SÜRÜMÜNÜN BİTMESİNE"+" "+Sifreleme.Decrypt(reg.GetValue("Day").ToString())+" "+"GÜN KALDI");
                btnKasa.Enabled = false;
                btnRapor.Enabled = false;             
                btnKullanicilar.Enabled = false;
                btnCikis.Enabled = false;
            }
            else if(Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "2")
            {
                btnKasa.Enabled = true;
                btnRapor.Enabled = true;
                btnKullanicilar.Enabled = true;
                btnCikis.Enabled = true;
                PersonelYetkisi();
            }
            reg.Close();
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Satis"] == null)
                SatişForm();
            else
                s.BringToFront();
        }

        Urunİslemleri ui = new Urunİslemleri();
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Urunİslemleri"] == null)
            {
                if (ui.IsDisposed)
                    ui = new Urunİslemleri();
                ui.MdiParent = this;
                ui.Show();
            }
            else ui.BringToFront();
        }
        Musteriİslemleri mi = new Musteriİslemleri();
        private void btnMüsteriler_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Musteriİslemleri"] == null)
            {
                if (mi.IsDisposed)
                    mi = new Musteriİslemleri();
                mi.MdiParent = this;
                mi.Show();
            }
            else mi.BringToFront();
        }

        Toptanciİslemleri ti = new Toptanciİslemleri();
        private void btnToptancılar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Toptanciİslemleri"] == null)
            {
                if (ti.IsDisposed)
                    ti = new Toptanciİslemleri();
                ti.MdiParent = this;
                ti.Show();
            }
            else ti.BringToFront();
        }

        KasaHesabi kh = new KasaHesabi();
        private void btnKasa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KasaHesabi"] == null)
            {
                if (kh.IsDisposed)
                    kh = new KasaHesabi();
                kh.MdiParent = this;
                kh.Show();
            }
            else kh.BringToFront();
        }

        Raporlar r = new Raporlar();
        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Raporlar"] == null)
            {
                if (r.IsDisposed)
                    r = new Raporlar();
                r.MdiParent = this;
                r.Show();
            }
            else r.BringToFront();
        }

        Servis se = new Servis();
        private void btnServis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Servis"] == null)
            {
                if (se.IsDisposed)
                    se = new Servis();
                se.MdiParent = this;
                se.Show();
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ads");
                if (Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "1")
                    Servis();
                reg.Close();
            }
            else se.BringToFront();
        }

        Kullaniciİslemleri ki = new Kullaniciİslemleri();
        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Kullaniciİslemleri"] == null)
            {
                if (ki.IsDisposed)
                    ki = new Kullaniciİslemleri();
                ki.MdiParent = this;
                ki.Show();
            }
            else ki.BringToFront();
        }

        Yedekle y = new Yedekle();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Yedekle"] == null)
            {
                if (y.IsDisposed)
                    y = new Yedekle();
                y.MdiParent = this;
                y.Show();
            }
            else y.BringToFront();
        }

        private void MarketOtomasyonu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Programı Kapatmak İstediginizden Emin misiniz?", "PROGRAMI KAPAT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
