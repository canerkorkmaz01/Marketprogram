using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Yardım : Form
    {
        public Yardım()
        {
            InitializeComponent();
        }

        private void lstBilgi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstBilgi.SelectedIndex)
            {
                case 0:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN EKLE Menüsünden Kategorileri Ekleyebilirsiniz Kategori Eklemeden Ürün Eklemeyin Kategori Silme İşlemi Yoktur Sadece Güncelleme Yapılabilirsiniz";
                    break;
                case 1:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN EKLE Menüsünden Kategori Ekle Menüsünden Seçilen Kategori Güncelle Butonuna Tıklayarak Kategoriyi Güncelleyebilirsiniz";
                    break;
                case 2:
                    btnYazi.Text = string.Empty; btnYazi.Text = "TOPTANCI HESAPLARINDAN Toptancı Ekle Tıklayarak Toptancı Bilgilerini Ekleyebilirsiniz Kategorilerde Olduğu Gibi Toptancı Ekleden Ürün Eklemeyiniz Toptancı Silme İşlemi Yoktur Sadece Güncelleme Yapılabilirsiniz";
                    break;
                case 3:
                    btnYazi.Text = string.Empty; btnYazi.Text = "TOPTANCI HESAPLARINDAN Seçilen Toptancıları Güncelle Tıklayarak Toptancıları Güncelleyebilirsiniz";
                    break;
                case 4:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN EKLEDEN Ürünlerinizi Ekleyebilirisiniz Kaydet Tıklayarak Ürünlerinizi Kaydedebilirsiniz";
                    break;
                case 5:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN LİSTESİNDEN Seçilen Ürünlerinizi Güncelleyebilirsiniz";
                    break;
                case 6:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN LİSTESİNDEN Seçilen Ürünlerinizi Silebilirsiniz";
                    break;
                case 7:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN LİSTESİNDEN Menüde BARKOD GÖRE ARAMA Tıklayarak Okutulan Barkoda Göre Ürünleri Listeleyebilirsiniz";
                    break;
                case 8:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN İŞLEMLERİNDEN ÜRÜN LİSTESİNDEN Menüde ÜRÜN ADINA GÖRE ARAMA Tıklayarak Girilen Ürün Adına Göre Ürünleri Listeleyebilirsiniz";
                    break;
                case 9:
                    btnYazi.Text = string.Empty; btnYazi.Text = "RAPORLAR Menüsünden SATIŞ RAPORLAR'ını Seçerek Günlük Aylık ve Yıllık Cironuzu ve Karınızı Görebilirisiniz Aynı Menüden STOK RAPORU'nu Seçerekte Stoğunuzda Malın Değerini Alış ve Satış Fiyatını Görebilirsiniz";
                    break;
                case 10:
                    btnYazi.Text = string.Empty; btnYazi.Text = "MÜŞTERİLER Menüsünden MÜŞTERİ EKLE Seçerek Müşteriniz Kaydını Yapın Müşteriye Satış Yapmak İçin Satış Ekranında VERESİYE MÜŞTERİ Tıklayarak Müşteri Seçip Satış Yapabilirisiniz Müşteri Hesaplarını MENÜ den MÜŞTERİLER MÜŞTERİ HESAPLARI'nı Seçerek Müşteriniz Hesaplarını Görebilir Düzenleyebilir ve Tahsilat Alabilirsiniz";
                    break;
                case 11:
                    btnYazi.Text = string.Empty; btnYazi.Text = "TOPTANCILAR Menüsünden TOPTANCI EKLE Seçerek Toptancı Kaydını Yapın Toptancı Hesaplarını TOPTANCI ve TOPTANCI HESAPLARI'nı Seçerek Toptancı Hesaplarını Görebilir Düzenleyebilir Aldıgınız Ürünleri Ekleyebilir ve Ödeme Yapabilirsiniz";
                    break;
                case 12:
                    btnYazi.Text = string.Empty; btnYazi.Text = "SERVİSLER Bölümünde Müşteriler Ürünler Toptancılar Gibi Bilgilieri EXCEL Aktarabilirsiniz Bilgisayarında Microsoft EXCEL Kurulu Olmalıdır";
                    break;
                case 13:
                    btnYazi.Text = string.Empty; btnYazi.Text = "PROGRAMIN KOPYALANMASI KESİNLİKLE YASAK OLUP TELİF HAKLARI KANUNA GÖRE CEZA GEREKTİREN BİR SUÇTUR. AYRICA GİRDİĞİNİZ BİNLERCE ÜRÜN LİSTESİNİN BOŞUNA GİTMEMESİ İÇİN PROGRAMI LİSANSLI KULLANMANIZ DAHA MANTIKLIDIR";
                    break;
                case 14:
                    btnYazi.Text = string.Empty; btnYazi.Text = "PROGRAM İÇİNDE YER ALAN YEDEKLE KAPAT MENÜSÜ SON YAPILAN İŞLEMLERİ FLASH BELLEGE YADA HARDDİSK GÜNLÜK HAFTALIK YEDEKLEMENİZ BİLGİLERİNİZİN KAYBOLMAMASI İÇİN ÇOK ÖENMLİDİR";
                    break;
                case 15:
                    btnYazi.Text = string.Empty; btnYazi.Text = "ÜRÜN EKLE Menüsünden Kategorileri Ekleyebilirsiniz Kategori Eklemeden Ürün Eklemeyin";
                    break;
                case 16:
                    btnYazi.Text = string.Empty; btnYazi.Text = "";
                    break;
                case 17:
                    btnYazi.Text = string.Empty; btnYazi.Text = "";
                    break;

                default:
                    break;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUzakYardim_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.teamviewer.com/tr/download/windows/?pid=google.tv.teamviewer_download.s.tr&gclid=CjwKCAjwypjVBRANEiwAJAxlIjGBG13fywomcveMSVoPq4hDrUvxpjTthrTOmC8JJ1FnTfXwwIOw_xoCJkAQAvD_BwE");
        }

        private void Yardım_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
        }
    }
}
