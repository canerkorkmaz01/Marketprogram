using System.Windows.Forms;

namespace Table
{
    public class Tables
    {
        /// <summary>
    /// Manuel Ürün Ararken DataGridView Kullanılan Static Metot
    /// </summary>
    /// <param name="d"></param>
        public static void DataGridViewUrunArama(DataGridView d)
        {
            d.Columns[4].Width = 300;
            d.Columns[6].Width = 80;
            d.Columns[7].Width = 80;
            d.Columns[8].Width = 80;
            d.Columns[0].Visible = false;
            d.Columns[1].Visible = false;
            d.Columns[2].Visible = false;
            d.Columns[3].Visible = false;
            d.Columns[5].Visible = false;
            d.Columns[9].Visible = false;
            d.Columns[10].Visible = false;
            d.Columns[11].Visible = false;
            d.Columns[4].HeaderText = "Ürün Adı";
            d.Columns[6].HeaderText = "Satış Fiyatı";
            d.Columns[7].HeaderText = "Alış Fiyatı";
            d.Columns[8].HeaderText = "Stok";
        }

        /// <summary>
        /// Ürün Listelemede DatagridView İçin Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewUrunListele(DataGridView d)
        {
                
                d.Columns[0].Width = 15;
                d.Columns[1].Width = 50;
                d.Columns[2].Width = 7;
                d.Columns[3].Width = 7;
                d.Columns[4].Width = 70;
                d.Columns[0].HeaderText = "Barkod No";
                d.Columns[1].HeaderText = "Ürün Adı";
                d.Columns[2].HeaderText = "Fiyatı";
                d.Columns[3].HeaderText = "Adet";
                d.Columns[4].HeaderText = "Toplam";
        }

        /// <summary>
        /// Müşteri Listelemede DatagridView İçin Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewMusteriListele(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[3].Visible = false;
            d.Columns[4].Visible = false;
            d.Columns[8].Visible = false;
            d.Columns[6].Visible = false;
            d.Columns[1].HeaderText = "Müsteri Adı";
            d.Columns[2].HeaderText = "Müsteri Soyadı";
            d.Columns[5].HeaderText = "Borcu";
            d.Columns[7].HeaderText = "Limit";
        }

        /// <summary>
        /// Ürün İşmlemlerinde Ürünleri Listelemek İçin DatagridView Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewUrunListe(DataGridView d)
        {
            d.Columns[2].Width = 350;
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Barkod";
            d.Columns[2].HeaderText = "Ürün Adı";
            d.Columns[3].HeaderText = "Kategori Adı";
            d.Columns[4].HeaderText = "Toptancı";
            d.Columns[5].HeaderText = "Kalan Stok";
            d.Columns[6].HeaderText = "Satış Fiyatı";
            d.Columns[7].HeaderText = "Alış Fiyatı";
            d.Columns[8].HeaderText = "Birim";
            d.Columns[9].HeaderText = "Stok";
            d.Columns[10].HeaderText = "Tarihi";
            d.Columns[11].HeaderText = "SKT Tarihi";
        }

        /// <summary>
        /// Kategori İşlemlerinde Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewKategori(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Kategori Adı";
            d.Columns[2].HeaderText = "KDV Bilgisi";
        }

        /// <summary>
        ///Stok İşlemlerinde Ürün Bilgisinde Kullanılan Metot 
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewStokUrunleri(DataGridView d)
        {
            d.Columns[2].Width = 210;
            d.Columns[9].Width = 60;
            d.Columns[0].Visible = false;
            d.Columns[1].Visible = false;
            d.Columns[2].HeaderText = "Ürün Adı";
            d.Columns[3].Visible = false;
            d.Columns[4].Visible = false;
            d.Columns[5].HeaderText = "Stok";
            d.Columns[6].Visible = false;
            d.Columns[7].Visible = false;
            d.Columns[8].Visible = false;
            d.Columns[9].Visible = false;
            d.Columns[10].Visible = false;
            d.Columns[11].Visible = false;
        }

        /// <summary>
        /// Satış Raporlarını Getiren Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewSatisDetaylari(DataGridView d)
        {
            d.Columns[2].Width = 300;
            d.Columns[0].Visible = false;
            d.Columns[7].Visible = false;
            d.Columns[1].HeaderText = "Barkod";
            d.Columns[2].HeaderText = "Ürün Adı";
            d.Columns[3].HeaderText = "Fiyatı";
            d.Columns[4].HeaderText = "Miktarı";
            d.Columns[5].HeaderText = "Toplam Tutarı";
            d.Columns[6].HeaderText = "Satış Türü";
            d.Columns[8].HeaderText = "Tarihi";
        }

        /// <summary>
        /// SatışDetay Düzenlemek İçin Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewSatisDetaylariDuzenle(DataGridView d)
        {
            d.Columns[1].Width = 80;
            d.Columns[2].Width = 300;
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Barkod";
            d.Columns[2].HeaderText = "Ürün Adı";
            d.Columns[3].HeaderText = "Fiyatı";
            d.Columns[4].HeaderText = "Miktarı";
            d.Columns[5].HeaderText = "Toplam Tutarı";
            d.Columns[6].HeaderText = "Satış Türü";
            d.Columns[7].HeaderText = "İndirim";
            d.Columns[8].HeaderText = "Tarihi";

        }

        /// <summary>
        /// Müşteri Bilgilerini Düzenlemk İçin Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewMusteriler(DataGridView d)
        {
            //d.Columns[1].Width = 80;
            //d.Columns[2].Width = 300;
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Müşteri Adi";
            d.Columns[2].HeaderText = "Müşteri Soyadı";
            d.Columns[3].HeaderText = "Adres";
            d.Columns[4].HeaderText = "Telefonu";
            d.Columns[5].HeaderText = "Borcu";
            d.Columns[6].HeaderText = "Ödemesi";
            d.Columns[7].HeaderText = "Limit";
            d.Columns[8].HeaderText = "Tarih";

        }

        /// <summary>
        /// Tedarikcileri Bilgilerini Düzenlemk İçin Kullanılan Static Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewTedarikciler(DataGridView d)
        {
            //d.Columns[1].Width = 80;
            //d.Columns[2].Width = 300;
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "FİRMA";
            d.Columns[2].HeaderText = "YETKİLİ";
            d.Columns[3].HeaderText = "TELEFONU";
            d.Columns[4].HeaderText = "WEB SAYFASI";
            d.Columns[5].HeaderText = "ADRES";
            d.Columns[6].HeaderText = "BORCUN";
            d.Columns[7].HeaderText = "ALDIKLARIM";
            d.Columns[8].HeaderText = "ODEMELERİM";
            d.Columns[9].HeaderText = "TARİH";
        }

        /// <summary>
        /// SatisRapoarlarını Datagridview Bilgilerini Düzenlemek İçin Kullanılan Metot
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewSatisRaporlari(DataGridView d)
        {
            //d.Columns[1].Width = 80;
            d.Columns[1].Width = 270;
            d.Columns[2].Width = 60;
            d.Columns[3].Width = 50;
            d.Columns[4].Width = 60;
            d.Columns[7].Visible = false;
            d.Columns[9].Visible = false;
            d.Columns[0].HeaderText = "BARKOD NO";
            d.Columns[1].HeaderText = "URUN ADI";
            d.Columns[2].HeaderText = "FİYATI";
            d.Columns[3].HeaderText = "MİKTAR";
            d.Columns[4].HeaderText = "TOPLAM";
            d.Columns[5].HeaderText = "SATIŞ TÜRÜ";
            d.Columns[6].HeaderText = "PERSONEL";
            d.Columns[8].HeaderText = "TARİH";

        }

        /// <summary>
        /// İade Bilgilerindeki Datagridview Bilgilerini Düzenlemek İçin 
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewİadeler(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].Width = 35;
            d.Columns[2].Width = 90;
            d.Columns[3].Width = 20;
            d.Columns[4].Width = 17;
            d.Columns[5].Width = 20;
            d.Columns[6].Width = 40;
            d.Columns[7].Width = 40;
            d.Columns[8].Width = 70;
            d.Columns[1].HeaderText = "BARKOD NO";
            d.Columns[2].HeaderText = "ÜRÜN ADI";
            d.Columns[3].HeaderText = "FİYATI";
            d.Columns[4].HeaderText = "MİKTAR";
            d.Columns[5].HeaderText = "TOPLAM";
            d.Columns[6].HeaderText = "İADE SEBEBİ";
            d.Columns[7].HeaderText = "PERSONEL";
            d.Columns[8].HeaderText = "TARİH";
        }

        /// <summary>
        /// Excel Aktarılacak Ürünlerin DatagridView Aktarır
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewExcel(DataGridView d)
        {
            d.Columns[0].HeaderText = "BARKOD";
            d.Columns[1].HeaderText = "ÜRÜN ADI";
            d.Columns[2].HeaderText = "A FİYATI";
            d.Columns[3].HeaderText = "S FİYATI";
            d.Columns[4].HeaderText = "STOK";
        }

        /// <summary>
        /// Excel Aktarılacak Müşterileri DatagridView Aktarır
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewExcelMusteri(DataGridView d)
        {
            d.Columns[0].HeaderText = "ADI SOYADI";
            d.Columns[1].HeaderText = "TELEFONU";
            d.Columns[2].HeaderText = "BORCU";
            d.Columns[3].HeaderText = "ÖDEMELERİ";
            d.Columns[4].HeaderText = "LİMİT";
            d.Columns[5].HeaderText = "TARİH";
        }

        /// <summary>
        /// Excel Aktarılacak Tedarikci DatagridView Aktarır
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewExcelTedarikci(DataGridView d)
        {
            d.Columns[0].HeaderText = "ŞİRKETADI";
            d.Columns[1].HeaderText = "YETKİLİ";
            d.Columns[2].HeaderText = "TELEFON";
            d.Columns[3].HeaderText = "BORÇ";
            d.Columns[4].HeaderText = "ALINAN";
            d.Columns[5].HeaderText = "ÖDEMELER";
            d.Columns[6].HeaderText = "TARİH";
        }

        /// <summary>
        /// Personeller Tablosunu Düzenlemek İçin Kullanılır
        /// </summary>
        /// <param name="d"></param>
        public static void DataGridViewPersoneller(DataGridView d)
        {
            d.Columns[5].Width = 130;
            d.Columns[0].Visible = false;
            d.Columns[1].Visible = false;
            d.Columns[2].HeaderText = "ADI";
            d.Columns[3].HeaderText = "SOYADI";
            d.Columns[4].HeaderText = "GÖREVİ";
            d.Columns[5].HeaderText = "KULLANICI ADI";
            d.Columns[6].HeaderText = "ŞİFRE";

        }
    }
}
