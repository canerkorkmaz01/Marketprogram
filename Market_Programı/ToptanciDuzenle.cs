using Entity;
using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class ToptanciDuzenle : Form
    {
        private Tedarikciler ted;
        public int textbox { get; set; }
        public ToptanciDuzenle(Tedarikciler te)
        {
            ted = te;
            InitializeComponent();
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

        /// <summary>
        /// Toptancı Hesaplarından Gelen Bilgileri Tutar Burda Bilgilere Ulaşırız
        /// </summary>
        private void Bilgiler()
        {
            txtFirmaAdi.Text = ted.SirketAdi;
            txtYetkili.Text = ted.Yetkili;
            txtTelefon.Text = ted.Telefon;
            txtWebSayfası.Text = ted.WebSayfasi;
            txtAdres.Text = ted.Adres;
            txtMail.Text = ted.Email;
            txtBorc.Text = ted.Borcun.ToString();
        }
        private void ToptanciDuzenle_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            Cizgi();
            Bilgiler();
            txtTelefon.MaxLength = 11;
            Butonlar();
        }

        /// <summary>
        /// Ödeme İşlemi Yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdemeyiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("TOPTANCI ÖDEMESİNİ ONAYLIYORMUSNUZ","ÖDEME",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (result== DialogResult.Yes)
            {
                if (txtOdemeYap.Text != string.Empty)
                {
                    Tedarikciİslem ti = new Tedarikciİslem();
                    ted.Odemelerim = Convert.ToDecimal(txtOdemeYap.Text);
                    ted.Borcun = Convert.ToDecimal(txtOdemeYap.Text);

                    ti.FirmaAdi = txtFirmaAdi.Text;
                    ti.İslem = "Ödeme Yapıldı";
                    ti.Odemelerim = Convert.ToDecimal(txtOdemeYap.Text);
                    ti.Aldiklarim = 0;
                    ti.Borcun = 0;
                    ti.Tarih = DateTime.Now;
                    bool deger = TedarikciİslemORM.TedarikciİslemEkle(ti);
                    bool deger2 = TedarikciORM.TedarikciBorcEkle(ted);
                    if (deger && deger2)
                    {
                        MessageBox.Show("MÜŞTERİ ÖDEMESİ GERÇEKLETİ", "öDEME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("öDEME YAPILIRKEN HATA OLUŞTU", "öDEME HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("ÖDEME MİKTARI GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        /// <summary>
        /// Borca Ürün Alır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrunAlmayiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ALDIGIN ÜRÜN MİKTARINI ONAYLIYORMUSNUZ", "ÖDEME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (txtBorcUrunAl.Text != string.Empty)
                {
                    Tedarikciİslem ti = new Tedarikciİslem();
                    ted.Aldiklarim = Convert.ToDecimal(txtBorcUrunAl.Text);
                    ted.Borcun = Convert.ToDecimal(txtBorcUrunAl.Text);
                    ti.FirmaAdi = txtFirmaAdi.Text;
                    ti.İslem = "Ürün Aldım";
                    ti.Odemelerim = 0;
                    ti.Aldiklarim = Convert.ToDecimal(txtBorcUrunAl.Text);
                    ti.Borcun = 0;
                    ti.Tarih = DateTime.Now;
                    bool deger = TedarikciİslemORM.TedarikciİslemEkle(ti);
                    bool deger2 = TedarikciORM.TedarikciAldiklarim(ted);
                    if (deger && deger2)
                    {
                        MessageBox.Show("İŞLEM GERÇEKLEŞTİ", "öDEME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("ÜRÜN MİKTARI YAPILIRKEN HATA OLUŞTU", "öDEME HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("ÖDEME MİKTARI GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Alınan Ürünü İADE Edilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnİadeOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ALDIGIN ÜRÜN İADESİNİ ONAYLIYORMUSNUZ", "İADE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (txtİadeVer.Text != string.Empty)
                {
                    Tedarikciİslem ti = new Tedarikciİslem();
                    ted.Aldiklarim = Convert.ToDecimal(txtİadeVer.Text);
                    ted.Borcun = Convert.ToDecimal(txtİadeVer.Text);
                    ti.FirmaAdi = txtFirmaAdi.Text;
                    ti.İslem = "İade Verdim";
                    ti.Odemelerim = Convert.ToDecimal(txtİadeVer.Text);
                    ti.Aldiklarim = 0;
                    ti.Borcun = 0;
                    ti.Tarih = DateTime.Now;
                    bool deger = TedarikciİslemORM.TedarikciİslemEkle(ti);
                    bool deger2 = TedarikciORM.TedarikciİadeVer(ted);
                    if (deger && deger2)
                    {
                        MessageBox.Show("İŞLEM GERÇEKLEŞTİ", "öDEME BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("ÜRÜN MİKTARI YAPILIRKEN HATA OLUŞTU", "İADE HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("ÖDEME MİKTARI GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtOdemeYap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtBorcUrunAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtİadeVer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ted.SirketAdi = txtFirmaAdi.Text;
            ted.Yetkili = txtYetkili.Text;
            ted.Telefon = txtTelefon.Text;
            ted.Adres = txtAdres.Text;
            ted.Email = txtMail.Text;
            ted.WebSayfasi = txtWebSayfası.Text;
            bool deger= TedarikciORM.TedarikciGuncelle(ted);
            if (deger)
            {
                MessageBox.Show("TOPTANCI HESABI GÜNCELLENDİ","GÜNCELLEME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            else MessageBox.Show("HESAP GÜNCELLENİRKEN HATA OLUŞTU","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Adet Girilen Butonları Sayı Bilgisini Alır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buton(object sender, EventArgs e)
        {
            Button btnn = (Button)sender;
            foreach (Control btn in panel1.Controls)
            {
                if (btn is TextBox)
                {
                    continue;
                }
              
                else if (btn.Text != btnSil.Text & btn.Text != btnSag.Text & btn.Text != btnSol.Text)
                {
                    if (btn.Name == btnn.Name)
                    {
                        if (textbox == 1)
                        {
                            txtOdemeYap.Text += btn.Text;
                            break;
                        }
                        else if(textbox == 2)
                        {
                            txtBorcUrunAl.Text += btn.Text;
                            break;
                        }
                        else if (textbox == 3)
                        {
                            txtİadeVer.Text += btn.Text;
                            break;
                        }
                    }
                }
               
            }
        }

        private void Butonlar()
        {
            btn0.Click += new EventHandler(Buton);
            btn00.Click += new EventHandler(Buton);
            btn1.Click += new EventHandler(Buton);
            btn2.Click += new EventHandler(Buton);
            btn3.Click += new EventHandler(Buton);
            btn4.Click += new EventHandler(Buton);
            btn5.Click += new EventHandler(Buton);
            btn6.Click += new EventHandler(Buton);
            btn7.Click += new EventHandler(Buton);
            btn8.Click += new EventHandler(Buton);
            btn9.Click += new EventHandler(Buton);
            btnVirgül.Click += new EventHandler(Buton);
        }

        private void txtOdemeYap_Click(object sender, EventArgs e)
        {
            textbox = 1;
        }

        private void txtBorcUrunAl_Click(object sender, EventArgs e)
        {
            textbox = 2;
        }

        private void txtİadeVer_Click(object sender, EventArgs e)
        {
            textbox = 3;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textbox == 1) txtOdemeYap.Text = string.Empty;
            else if (textbox == 2) txtBorcUrunAl.Text = string.Empty;
            else if (textbox == 3) txtİadeVer.Text = string.Empty;
        }

        /// <summary>
        /// Textbox İçinde İmlecin Butona Basılınca Hangi Yöne Gidecegini Gösteririr
        /// </summary>
        /// <param name="yon"></param>
        private void ImleciKaydirma(string yon)
        {
            if (textbox == 1)
            {
                txtOdemeYap.Focus();
                SendKeys.Send(yon);
            }
            else if (textbox == 2)
            {
                txtBorcUrunAl.Focus();
                SendKeys.Send(yon);
            }
            else if (textbox == 3)
            {
                txtİadeVer.Focus();
                SendKeys.Send(yon);
            }
        }

        /// <summary>
        /// Girilen Miktarda Sag Dogru Bir Bir İleri Gider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSag_Click(object sender, EventArgs e)
        {
            ImleciKaydirma("{RIGHT}");
        }

        /// <summary>
        /// Girilen Miktarda Sola Dogru Bir Bir İleri Gider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSol_Click(object sender, EventArgs e)
        {
            ImleciKaydirma("{LEFT}");
        }

        private void btnOdemeRapor_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikciİslem_TarihRapor", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@baslangic", dtpTarih1.Value);
                adp.SelectCommand.Parameters.AddWithValue("@bitis", dtpTarih2.Value.AddDays(1));
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\Toptanciİslemleri.FRX");
                report.Show();
            }
        }

        private void btnTumRaporlar_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikciİslem_TedarikciRapor", Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\TumToptancilar.FRX");
                report.Show();
            }
        }
    }
}
