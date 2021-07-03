using Entity;
using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class SatisRaporu : Form
    {
        public SatisRaporu()
        {
            InitializeComponent();
        }
        public int rapor { get; set; }
        private void Rapor(string prc,string path,string prm)
        {
            try
            {
                using (Report report = new Report())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.Fill(dt);
                    report.RegisterData(dt, "dt");
                    report.Load(Application.StartupPath + path);
                    report.SetParameterValue("Rapor ", prm);
                    report.Show();
                    //report.Design();
                }
            }
            catch (Exception) {; }
        }

        /// <summary>
        /// İade Etiket Bilgisini Gizler
        /// </summary>
        private void İadeEtiketleriniGizle(bool deger)
        {
            lblİade.Visible = deger;
            lblMiktar.Visible = deger;
        }

        /// <summary>
        /// Kar Adet Toplam Etiketlerini Gizler
        /// </summary>
        /// <param name="deger"></param>
        private void EtiketleriGizle(bool deger)
        {
            lblKar.Visible = deger;
            lblAdet.Visible = deger;
            lblToplam.Visible = deger;
        }

        /// <summary>
        /// Toplam Kar Tutarını Verir
        /// </summary>
        private void Kar()
        {
            decimal kar = 0;
            for (int i = 0; i <dataGridView1.RowCount; i++)
            {
                kar +=Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
            }
            lblKar.Text ="Toplam Kazancınız"+" "+ kar.ToString()+" "+"TL";
        }

        /// <summary>
        /// Toplam SAtışların Bilgisini Verir
        /// </summary>
        private void Toplam()
        {
            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblToplam.Text = "Toplam Satışınız" + " " + toplam.ToString() + " " + "TL";
        }

        /// <summary>
        /// DatagridView deki Toplam Satışların Sayısımı Verir
        /// </summary>
        private void ToplamAdet()
        {
            int adet = 0;
            for (int i = 0; i <dataGridView1.RowCount; i++)
            {
                adet += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lblAdet.Text = "Toplamda" + " " + adet.ToString()+" "+"Adet Ürün Satışı Yapıldı"+  " " + "TL";
        }

        /// <summary>
        /// İADE Adetlerini Toplam Bilgisini Verir
        /// </summary>
        private void İadeAdet()
        {
            int adet = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                adet += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblİade.Text = "Toplamda" + " " + adet.ToString() + " " + "Adet Ürün İadesi Yapıldı" + " " + "TL";
        }

        /// <summary>
        /// Toplam İade Tutarını Verir
        /// </summary>
        private void Toplamİade()
        {
            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }
            lblMiktar.Text = "Toplam İade Miktarı" + " " + toplam.ToString() + " " + "TL";
        }

        /// <summary>
        /// Butonları Ayraç Olarak Kullanmak İçin Çizgi Çizer
        /// </summary>
        //private void Cizgi()
        //{
        //    label1.AutoSize = false;
        //    label1.Width = 140;
        //    label1.Height = 10;
        //    label1.BorderStyle = BorderStyle.Fixed3D;
        //    label1.BackColor = Color.Black;
        //    label2.AutoSize = false;
        //    label2.Width = 140;
        //    label2.Height = 10;
        //    label2.BorderStyle = BorderStyle.Fixed3D;
        //    label2.BackColor = Color.Black;
        //}

        /// <summary>
        /// Veritabnından Gelen Bilgileri Combobox Ekler
        /// </summary>
        private void Combobox()
        {
            cboPersonel.DataSource = PersonellerORM.KullaniciAdlari();
            cboPersonel.DisplayMember = "Adi";
            cboPersonel.ValueMember = "PersonelId";
            cboPersonel.Text = string.Empty;
        }
        private void SatisRaporu_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            Combobox();
            txtBarkod.MaxLength = 13;
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Bugünkü Satışlar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBugünküSatisRapor_Click(object sender, EventArgs e)
        {
            rapor = 1;
            dataGridView1.DataSource=  SatisRaporlariORM.BugunSatisRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Bugünkü Nakit Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBugunkuNakitSaisRapor_Click(object sender, EventArgs e)
        {
            rapor = 2;
            dataGridView1.DataSource = SatisRaporlariORM.BugunNakitRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Bugünkü Pos Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBugunkuPosSatisRapor_Click(object sender, EventArgs e)
        {
            rapor = 3;
            dataGridView1.DataSource = SatisRaporlariORM.BugunPosRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Bugün İade Gelenler Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBugunİadeGelenler_Click(object sender, EventArgs e)
        {
            rapor = 4;
            dataGridView1.DataSource = UrunİadeORM.İadeBilgileri();
            Tables.DataGridViewİadeler(dataGridView1);
            İadeAdet();
            Toplamİade();
            EtiketleriGizle(false);
            İadeEtiketleriniGizle(true);
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// Son Bir Haftada Yapılan Satışlar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1HaftaSatisRapor_Click(object sender, EventArgs e)
        {
            rapor = 5;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirHaftaRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            EtiketleriGizle(true);
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Son Bir Haftada Nakit Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1HaftaNakitSatis_Click(object sender, EventArgs e)
        {
            rapor = 6;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirHaftaNakitRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            EtiketleriGizle(true);
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Son Bir Haftada Yapılan Pos Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1HaftaPosSatis_Click(object sender, EventArgs e)
        {
            rapor = 7;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirHaftaPosRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            EtiketleriGizle(true);
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Son Bir Haftada Yapılan İadeler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1HaftaİadeGelenler_Click(object sender, EventArgs e)
        {
            rapor = 8;
            dataGridView1.DataSource = UrunİadeORM.SonBirHaftadaGelenİade();
            Tables.DataGridViewİadeler(dataGridView1);
            İadeAdet();
            Toplamİade();
            EtiketleriGizle(false);
            İadeEtiketleriniGizle(true);
        }

        /// <summary>
        /// Son Bir Ayda Yapılan Satışları
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1AySatisRaporu_Click(object sender, EventArgs e)
        {
            rapor = 9;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirAySatisRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            EtiketleriGizle(true);
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Son Bir Ayda Yapılan Nakit Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1AyNakitSatisRapor_Click(object sender, EventArgs e)
        {
            rapor = 10;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirAyNakitSatisRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
        }

        /// <summary>
        /// Son Bir Ayda Yapılan Pos Satışlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1AyPosSatisRaporu_Click(object sender, EventArgs e)
        {
            rapor = 11;
            dataGridView1.DataSource = SatisRaporlariORM.SonBirAyPosSatisRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            İadeEtiketleriniGizle(false);
            EtiketleriGizle(true);
        }

        /// <summary>
        /// Son Bir Ayda Gelen İadeler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSon1AyİadeGelenRapor_Click(object sender, EventArgs e)
        {
            rapor = 12;
            dataGridView1.DataSource = UrunİadeORM.SonBirAyGelenİade();
            Tables.DataGridViewİadeler(dataGridView1);
            İadeAdet();
            Toplamİade();
            İadeEtiketleriniGizle(true);
            EtiketleriGizle(false);
        }

        /// <summary>
        /// 2 Tarih Arasındaki Raporları Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSonTarih_ValueChanged(object sender, EventArgs e)
        {
          rapor = 13;
          dataGridView1.DataSource= SatisRaporlariORM.İkiTarihArası(dtpİlkTarih.Value,dtpSonTarih.Value.AddDays(1));
          Tables.DataGridViewSatisRaporlari(dataGridView1);
          Kar();
          Toplam();
          ToplamAdet();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Barkod Bilgisine Göre Satış Bilgisini Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            rapor = 14;
            SatisDetaylari sd = new SatisDetaylari();
            sd.BarkodNo = txtBarkod.Text;
            dataGridView1.DataSource = SatisRaporlariORM.BarkodaGoreSatisRapor(sd);
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
        }

        /// <summary>
        /// Ürün Adına Göre Satış Bilgisini Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            rapor = 15;
            SatisDetaylari sd = new SatisDetaylari();
            sd.UrunAdi = txtUrunAdi.Text;
            dataGridView1.DataSource = SatisRaporlariORM.UrunAdınaGoreSatisRapor(sd);
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
        }

        /// <summary>
        /// Türüne Göre Satış Bilgisini Getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSatışTürü_TextChanged(object sender, EventArgs e)
        {
            rapor = 16;
            SatisDetaylari sd = new SatisDetaylari();
            sd.SatisTürü = cboSatışTürü.Text;
            dataGridView1.DataSource = SatisRaporlariORM.TuruneGoreSatisRapor(sd);
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = string.Empty;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = string.Empty;
        }

        private void cboPersonel_TextChanged(object sender, EventArgs e)
        {
            rapor = 17;
            Personeller p = new Personeller();
            p.Adi = cboPersonel.Text;
            dataGridView1.DataSource = SatisRaporlariORM.PersonelAdıSatisRapor(p);
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            cboPersonel.Text = string.Empty;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            switch (rapor)
            {
                case 1: Rapor("prc_Satislar_BugünküSatışRaporlari", "\\SatisRaporlari.FRX", "Bugün Yapılan Satışlar");
                    break;
                case 2:
                    Rapor("prc_Satislar_BugünküPesinSatisRaporları", "\\SatisRaporlari.FRX", "Bugün Yapılan Peşin Satışlar");
                    break;
                case 3:
                    Rapor("prc_Satislar_BugünküPosSatisRaporları", "\\SatisRaporlari.FRX", "Bugün Yapılan Pos Satışlar");
                    break;
                case 4:
                    Rapor("prc_Urunİade_İadeBilgisi", "\\İadeRapor.FRX", "Bugün Yapılan İade Satışlar");
                    break;
                case 5:
                    Rapor("prc_Satislar_SonBirHaftaSatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Haftanın Satışları");
                    break;
                case 6:
                    Rapor("prc_Satislar_SonBirHaftaNakitSatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Haftanın Nakit Satışları");
                    break;
                case 7:
                    Rapor("prc_Satislar_SonBirHaftaPosSatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Haftanın Pos Satışları");
                    break;
                case 8:
                    Rapor("prc_Urunİade_SonBirHaftaİadeGelen", "\\İadeRapor.FRX", "Son 1 Haftanın İade Satışları");
                    break;
                case 9:
                    Rapor("prc_Satislar_SonBirAySatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Ay  Satışları");
                    break;
                case 10:
                    Rapor("prc_Satislar_SonBirAyNakitSatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Ay Nakit Satışları");
                    break;
                case 11:
                    Rapor("prc_Satislar_SonBirAyPosSatisRaporları", "\\SatisRaporlari.FRX", "Son 1 Ay Pos Satışları");
                    break;
                case 12:
                    Rapor("prc_Urunİade_SonBirAyİadeGelen", "\\İadeRapor.FRX", "Son 1 Ay İade  Satışları");
                    break;
                case 13:
                    Rapor("prc_Satislar_İkiTarihArasıSatisRaporları", "\\SatisRaporlari.FRX", "Girilen Tarihler Arası Satışlar");
                    break;
                case 14:
                    Rapor("prc_Satislar_BarkodSatisRaporları", "\\SatisRaporlari.FRX", "Barkod Girilen Satışlar");
                    break;
                case 15:
                    Rapor("prc_Satislar_UrunAdıSatisRaporları", "\\SatisRaporlari.FRX", "Ürün Adı Girilen Satışlar");
                    break;
                case 16:
                    Rapor("prc_Satislar_TuruneGoreSatisRaporları", "\\SatisRaporlari.FRX", "Satış Türüne Göre Satışlar");
                    break;
                case 17:
                    Rapor("prc_Satislar_PersoneleGoreSatisRaporları", "\\SatisRaporlari.FRX", "Personele Göre Satışlar");
                    break;
                case 18:
                    Rapor("prc_SatisDetaylari_TumSatislar", "\\SatisRaporlari.FRX", "Tüm Satış Raporları");
                    break;
                default:
                    break;
            }


        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            rapor = 18;
            dataGridView1.DataSource = SatisRaporlariORM.TumSatisRapor();
            Tables.DataGridViewSatisRaporlari(dataGridView1);
            Kar();
            Toplam();
            ToplamAdet();
            EtiketleriGizle(true);
            İadeEtiketleriniGizle(false);
        }
    }
}

