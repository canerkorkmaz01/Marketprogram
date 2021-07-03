using Entity;
using ORM;
using System;
using System.Drawing;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        public void SatışYap()
        {
            SatislarListesi sl = new SatislarListesi();
            SatisDetayORM sdORM = new SatisDetayORM();
            SatisDetaylari sd = new SatisDetaylari();
            Kasaİslemleri ki = new Kasaİslemleri();
            Urunler u = new Urunler();

            if (dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    sd.İndirim = Convert.ToDecimal(txtİskonto.Text);
                    if (i == 1) sd.İndirim = 0;
                    sd.BarkodNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    sd.UrunAdi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    sd.BirimFiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    sd.Miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    sd.ToplamTutar = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    sd.SatisTürü = cboSatisTuru.Text;
                    sd.Kar =Convert.ToDecimal(SatisDetayORM.Kar(sd));//Kar Mikatr Bilgisini Getirir
                    sd.Tarih = DateTime.Now;
                    if (UrunlerORM.StokMiktariGetir(sd) != 0)
                    {
                        
                        sdORM.SatisDetaylariEkle(sd);
                        UrunlerORM.StokAzalat(sd);
                    }
                    else { }
                    if (UrunlerORM.StokMiktariGetir(sd) == 0) MessageBox.Show(UrunlerORM.StokUrunAdi(sd).Rows[0]["UrunAdi"].ToString() + " " + "Stokta Bulunmamaktadır...");
                }
                sl.Satislar(0); //Satışı Yapılan Ürünleri Satışlar Tablosuna Kimin Hangi Üründen Satıldıgını

            }
            ki.Aciklama = "Peşin Müşteri Satışı Yapıldı";
            ki.OdemeTipi = cboSatisTuru.Text;
            ki.Gelen = Toplam();
            ki.Cikan = 0;
            ki.Tarih = DateTime.Now;
            ki.Durum = 1;
            KasaİslemORM.KasaEkle(ki);
            UrunlerORM.dt.Clear();
            lblToplam.Text = "0";
        }

        /// <summary>
        /// Barkodu Okutulan Ürünlerin Toplam Tutarının toplamını Alır
        /// </summary>
        /// <returns></returns>
        public decimal Toplam()
        {
            decimal toplam = 0;
            foreach (DataGridViewRow dvr in dataGridView1.Rows)
            {
                toplam += Convert.ToDecimal(dvr.Cells[4].Value);
            }
            return toplam;
        }

        /// <summary>
        /// Tablo İçersindeki Toplam Ürün Saysını Degerini Döndürür
        /// </summary>
        /// <returns></returns>
        private int ToplamUrun()
        {
            int urun = 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                urun = i;
            }
            return urun+1;
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
                else if (btn.Text != btnArtır.Text & btn.Text != btnAzalt.Text)
                {
                    if (btn.Name == btnn.Name)
                    {
                        cboAdet.Text += btn.Text;

                        break;
                    }
                }
            }
            if (cboAdet.Text.Length > 3)
            {
                cboAdet.Text = "";
            }
        }
        /// <summary>
        /// Basılan Butonların Click Olaylarını Yakalar
        /// </summary>
        private void ButtonOlayları()
        {
            btn0.Click += new EventHandler(Buton);
            btn1.Click += new EventHandler(Buton);
            btn2.Click += new EventHandler(Buton);
            btn3.Click += new EventHandler(Buton);
            btn4.Click += new EventHandler(Buton);
            btn5.Click += new EventHandler(Buton);
            btn6.Click += new EventHandler(Buton);
            btn7.Click += new EventHandler(Buton);
            btn8.Click += new EventHandler(Buton);
            btn9.Click += new EventHandler(Buton);
        }

        /// <summary>
        /// Barkodu Okutulan Ürünlerin Eklenmsi İçin Sanal Tabloların Oluşmasını Sağlar
        /// </summary>
        private void Tablolar()
        {

                UrunlerORM.dt.Columns.Add("Barkod No");
                UrunlerORM.dt.Columns.Add("Urun Adı");
                UrunlerORM.dt.Columns.Add("Fiyatı");
                UrunlerORM.dt.Columns.Add("Adet");
                UrunlerORM.dt.Columns.Add("Toplam"); 
        }
             
        private void Satis_Load(object sender, EventArgs e)
        {
            cboAdet.SelectedIndex = 0;
            Urunler u = new Urunler();
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            cboSatisTuru.Items.AddRange(Enum.GetNames(typeof(SatisTürleri.SatisTürü)));
            cboSatisTuru.SelectedIndex = 0;
            ButtonOlayları();
            Tablolar();
            dataGridView1.DataSource = UrunlerORM.dt;
            Tables.DataGridViewUrunListele(dataGridView1);
            FlowLayouyPanel1.Controls.Clear();
            HizliSatisButonlari(1);
            HizliKategoriler();

        }
        private void btnMoney1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("05.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("1.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney3_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("5.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney4_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("10.jpg");
            btnVerilen.BackgroundImage = b;
        } 
        private void btnMoney5_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("020.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney6_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("50.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney7_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("100.jpg");
            btnVerilen.BackgroundImage = b;
        }
        private void btnMoney8_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap("200.jpg");
            btnVerilen.BackgroundImage = b;
        }

        /// <summary>
        /// Hızlı Satış Butonlarını Dinamik Olarak Oluşturur
        /// </summary>
        public void HizliSatisButonlari(int sayi)
        {
            FlowLayouyPanel1.Controls.Clear();
            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();
                btn.Height = 42;
                btn.Width = 104;
                btn.Tag = sayi;
                btn.BackColor = Color.FromArgb(247, 243, 144);
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                btn.Text = HizliSatisORM.HizliSatisGetir(sayi).Rows[0]["UrunAdi"].ToString();
                FlowLayouyPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
                sayi++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Tools.btnTag = (int)btn.Tag;
            if (btn.Text == "HIZLI SATIŞ ATA")
            {
                if (Application.OpenForms["HizliSatisAta"] == null)
                {
                    HizliSatisAta hs = new HizliSatisAta();
                    btn.Text = HizliSatisORM.HizliSatisGetir(Tools.btnTag).Rows[0]["UrunAdi"].ToString();
                    hs.Show();
                }
            }
            else
            {
                HizliSatis hs = new HizliSatis();
                hs.HizliSatisId = Tools.btnTag;
                Urunler u = new Urunler();
                u.BarkodNo = HizliSatisORM.HizliSatisBarkodGetir(hs).Rows[0]["BarkodNo"].ToString();
                u.UrunAdi = UrunlerORM.UrunListele(u).Rows[0]["UrunAdi"].ToString();
                u.SatisFiyati = (decimal)UrunlerORM.UrunListele(u).Rows[0]["SatisFiyati"];
                u.Toplam = Convert.ToDecimal(u.SatisFiyati * Convert.ToInt32(cboAdet.Text));
                UrunlerORM.dt.Rows.Add(u.BarkodNo, u.UrunAdi, u.SatisFiyati.ToString("N2"), cboAdet.Text, u.Toplam.ToString("N2"));
                dataGridView1.DataSource = UrunlerORM.dt;
                Tables.DataGridViewUrunListele(dataGridView1);
                lblToplam.Text = ToplamUrun().ToString();
                btnToplam.Text = Toplam().ToString();
            }
        }

        /// <summary>
        /// Girilen Adet Sayını Artırmak İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArtır_Click(object sender, EventArgs e)
        {
            if (cboAdet.Text != string.Empty)
            {
                int Adet = Convert.ToInt32(cboAdet.Text);
                Adet++;
                cboAdet.Text = Adet.ToString(); 
            }
        }

        /// <summary>
        /// Girilen Adet Sayını Artırmak İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (cboAdet.Text != string.Empty)
            {
                int Adet = Convert.ToInt32(cboAdet.Text);
                Adet--;
                cboAdet.Text = Adet.ToString();
            }
        }

        /// <summary>
        /// Barkodu Okutulan Ürünün Fiyatını Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            FiyatGor fg = new FiyatGor();
            fg.Show();
        }

        /// <summary>
        /// Manuel Olarak Ürün Getirmek İçin Kullanılan Metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            Tools.UrunArama = false;
            ManuelUrunArama mua = new ManuelUrunArama();
            mua.ShowDialog();
        }

        /// <summary>
        /// Okutulan Barkod Kodunu Veritabnından Sorgulayıp Dogru Olanları Ürün
        /// Bilgileri Getirir 
        /// </summary>
        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBarkod.MaxLength = 13;
                Urunler u = new Urunler();
                u.BarkodNo = txtBarkod.Text;
                u.UrunAdi = UrunlerORM.UrunListele(u).Rows[0]["UrunAdi"].ToString();
                u.SatisFiyati = (decimal)UrunlerORM.UrunListele(u).Rows[0]["SatisFiyati"];
                u.Toplam =Convert.ToDecimal(u.SatisFiyati * Convert.ToInt32(cboAdet.Text));
                UrunlerORM.dt.Rows.Add(u.BarkodNo, u.UrunAdi, u.SatisFiyati.ToString("N2"), cboAdet.Text, u.Toplam.ToString("N2"));
                dataGridView1.DataSource = UrunlerORM.dt;
                Tables.DataGridViewUrunListele(dataGridView1);
                txtBarkod.Clear();
                lblToplam.Text = ToplamUrun().ToString();

            }
            catch (Exception) {;}
    }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Ürünün Eski Fiyatından Satışını Yapmak için Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMünferitSatis_Click(object sender, EventArgs e)
        {
            MunferitSatis mf = new MunferitSatis();
            mf.Show();
        }

        /// <summary>
        /// Satışları Veritabanına Kaydetmek İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSatisKaydet_Click(object sender, EventArgs e)
        {
            SatışYap();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// DataGridView deki Seçilen Satırı Silmek İçin Kullanılan Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            int top = ToplamUrun() -1;
            lblToplam.Text = top.ToString();
        }

        /// <summary>
        /// Veresiye Müşterilere Bilgilerini Tutmak İçin Kullanılan Metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVeresiyeMüsteri_Click(object sender, EventArgs e)
        {
            MusteriListesi ml = new MusteriListesi();
            ml.ShowDialog();
            Toplam();
        }

        /// <summary>
        /// Barkodu Okutun Ürünler Tablosundaki Tüm Ürünleri Satışını İptal Eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSatisİptal_Click(object sender, EventArgs e)
        {
            UrunlerORM.dt.Clear();
            lblToplam.Text = "0";
            btnToplam.Text = "0,00";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblPesinMusteri.Text = "Musteri";
            lblMusteriBorcu.Text = "0";
            lblMusteriLimit.Text = "0";
        }

        /// <summary>
        /// Butona Basıldıgında Seçilen Kategorinin Hızlı Satış Butonlarını Getiren
        /// Metot
        /// </summary>
        /// <param name="btn"></param>
        private void ButonListele(int btn)
        {
            FlowLayouyPanel1.Controls.Clear();
            HizliSatisButonlari(btn);
            KategoriAta ka = new KategoriAta();
            HizliKategori hk = new HizliKategori();
            ka.TopLevel = false;
            groupBox3.Controls.Add(ka);
            ka.BringToFront();
            ka.Show();
        }

        private void btnKategori1_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 1;
            if (btnKategori1.Text == "KATEGORİ ATA")
            {
                ButonListele(1);
                HizliKategori.HizliKategoriId = 1;
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(1);
            }
        }
        private void btnKategori2_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 13;
            if (btnKategori2.Text == "KATEGORİ ATA")
            {
                ButonListele(13);
                HizliKategori.HizliKategoriId = 2;
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(13);
            }
        }

        private void btnKategori3_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 25;
            if (btnKategori3.Text == "KATEGORİ ATA")
            {
                ButonListele(25);
                HizliKategori.HizliKategoriId = 3;
                
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(25);
            }
        }

        private void btnKategori4_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 37;
            if (btnKategori4.Text == "KATEGORİ ATA")
            {
                ButonListele(37);
                HizliKategori.HizliKategoriId = 4;
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(37);
            }
        }

        private void btnKategori5_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 49;
            if (btnKategori5.Text == "KATEGORİ ATA")
            {
                ButonListele(49);
                HizliKategori.HizliKategoriId = 5;
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(49);
            }
        }

        private void btnKategori6_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 61;
            if (btnKategori6.Text == "KATEGORİ ATA")
            {
                ButonListele(61);
                HizliKategori.HizliKategoriId = 6;
               
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(61);
            }
        }

        private void btnKategori7_Click(object sender, EventArgs e)
        {
            Tools.hizliSatisButon = 73;
            if (btnKategori7.Text == "KATEGORİ ATA")
            {
                ButonListele(73);
                HizliKategori.HizliKategoriId = 7;
                
            }
            else
            {
                FlowLayouyPanel1.Controls.Clear();
                HizliSatisButonlari(73);
            }
        }

        /// <summary>
        /// Kategori Butonlarının Veritabnından İsimlerini Getirir
        /// </summary>
        public void HizliKategoriler()
        {
            btnKategori1.Text = HizliKategoriORM.HizliKategoriGetir(1).Rows[0]["HizliBaslik"].ToString();
            btnKategori2.Text = HizliKategoriORM.HizliKategoriGetir(2).Rows[0]["HizliBaslik"].ToString();
            btnKategori3.Text = HizliKategoriORM.HizliKategoriGetir(3).Rows[0]["HizliBaslik"].ToString();
            btnKategori4.Text = HizliKategoriORM.HizliKategoriGetir(4).Rows[0]["HizliBaslik"].ToString();
            btnKategori5.Text = HizliKategoriORM.HizliKategoriGetir(5).Rows[0]["HizliBaslik"].ToString();
            btnKategori6.Text = HizliKategoriORM.HizliKategoriGetir(6).Rows[0]["HizliBaslik"].ToString();
            btnKategori7.Text = HizliKategoriORM.HizliKategoriGetir(7).Rows[0]["HizliBaslik"].ToString();

        }

        private void Satis_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                UrunlerORM.dt.Columns.Remove("Barkod No");
                UrunlerORM.dt.Columns.Remove("Urun Adı");
                UrunlerORM.dt.Columns.Remove("Fiyatı");
                UrunlerORM.dt.Columns.Remove("Adet");
                UrunlerORM.dt.Columns.Remove("Toplam");
            }
            catch (Exception) {; }
        }

        /// <summary>
        /// Seçilen Kategorileri Kaldırır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblKategoriKaldir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KategoriKaldir"] == null)
            {
                KategoriKaldir kk = new KategoriKaldir();
                kk.TopLevel = false;
                groupBox3.Controls.Add(kk);
                kk.BringToFront();
                kk.Show(); 
            }
        }

        /// <summary>
        /// Seçilen hızlı Satışları Kaldırır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHizliSatisKaldir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HizliSatisKaldir"] == null)
            {
                HizliSatisKaldir hsk = new HizliSatisKaldir();
                hsk.TopLevel = false;
                groupBox3.Controls.Add(hsk);
                hsk.BringToFront();
                hsk.Show();
            }
        }

        private void btnIskonto_Click(object sender, EventArgs e)
        {
            btnToplam.Text = Convert.ToString(Toplam() - Convert.ToDecimal(txtİskonto.Text));
        }

        private void btnMoney1_Click(object sender, EventArgs e)
        {
            decimal money = 0.50m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney2_Click(object sender, EventArgs e)
        {
            decimal money = 1m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney3_Click(object sender, EventArgs e)
        {
            decimal money = 5m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney4_Click(object sender, EventArgs e)
        {
            decimal money = 10m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney5_Click(object sender, EventArgs e)
        {
            decimal money = 20m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney6_Click(object sender, EventArgs e)
        {
            decimal money = 50m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney7_Click(object sender, EventArgs e)
        {
            decimal money = 100m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnMoney8_Click(object sender, EventArgs e)
        {
            decimal money = 200m;
            btnVerilenPara.Text = money.ToString("N2");
            btnParaÜstü.Text = Convert.ToString(money - Toplam());
        }

        private void btnParaUstuİptal_Click(object sender, EventArgs e)
        {
            btnParaÜstü.Text = "";
            btnToplam.Text = "0,00";
            btnVerilenPara.Text = "";
        }

        private void Satis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FiyatGor fg = new FiyatGor();
                fg.Show();
            }
            else if(e.KeyCode == Keys.F4)
            {
                MunferitSatis mf = new MunferitSatis();
                mf.Show();
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnSatisKaydet_Click(null, null);
            }
            else if(e.KeyCode == Keys.F11)
            {
                if (dataGridView1.RowCount != 0)
                {
                    MarketprintPreviewDialog.Document = MarketprintDocument;
                    MarketprintPreviewDialog.ShowDialog();
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                MarketprintPreviewDialog.Document = MarketprintDocument;
                MarketprintPreviewDialog.ShowDialog();
            }
        }

        private void MarketprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //string adres, adress = string.Empty;
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);
            myFont = new Font("Calibri", 12, FontStyle.Bold);
            //--------------------------------------------------------------------------------------------------------------------
            e.Graphics.DrawLine(myPen, 10, 10, 800, 10);

            e.Graphics.DrawString("Market Fişi ", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(350, 15));
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12), Brushes.Black, new Point(7, 50));
            e.Graphics.DrawString("Saat: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 12), Brushes.Black, new Point(7, 75));
            e.Graphics.DrawLine(myPen, 10, 100, 800, 100);
            //--------------------------------------------------------------------------------------------------------------------
            e.Graphics.DrawString("Ürün Adı", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(7, 100));
            e.Graphics.DrawString("Fiyati", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 100));
            e.Graphics.DrawString("Miktar", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(670, 100));
            e.Graphics.DrawString("Tutar", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(740, 100));
            e.Graphics.DrawLine(myPen, 10, 130, 800, 130);
            //---------------------------------------------------------------------------------------------------------------------
            int y = 140;
            foreach (DataGridViewRow dgrid in dataGridView1.Rows)
            {
                e.Graphics.DrawString(dgrid.Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(7, y));
                e.Graphics.DrawString(dgrid.Cells[2].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, y));
                e.Graphics.DrawString(dgrid.Cells[3].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(670, y));
                e.Graphics.DrawString(dgrid.Cells[4].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(740, y));
                y += 30;
            }
            y += 5;
            e.Graphics.DrawLine(myPen, 10, y, 800, y);
            e.Graphics.DrawString("Toplam Tutar :"+Toplam() , new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, y += 5));
            e.Graphics.DrawLine(myPen, 10, y += 25, 800, y); 
        }
    }
}