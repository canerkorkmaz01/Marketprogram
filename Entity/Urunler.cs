using System;

namespace Entity
{
    public class Urunler
    {

        private string _BarkodNo;
        private string _UrunAdi;
        private int _KalanStok;
        private int _Stok;
        private decimal _SatisFiyati;
        private decimal _AlisFiyati;
        public int UrunId { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BarkodNo
        {
            get { return _BarkodNo; }
            set {
                if (value == string.Empty)
                    throw new Exception("Barkod Boş Geçilemez");
                else
                    _BarkodNo = value;
                }
        }
        public string UrunAdi
        {
            get { return _UrunAdi; }
            set {
                if (value == string.Empty)
                    throw new Exception("Ürün Adı Boş Geçilmez");
                else
                _UrunAdi = value;
                }
        }
        public int KalanStok
        {
            get { return _KalanStok; }
            set {_KalanStok = value; }
        }
        public int Stok
        {
            get { return _Stok; }
            set { _Stok = value; }
        }
        public decimal SatisFiyati
        {
            get { return _SatisFiyati; }
            set { _SatisFiyati = value; }
        }
        public decimal AlisFiyati
        {
            get { return _AlisFiyati; }
            set { _AlisFiyati = value; }    
        }
        public string Birim { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime SKTarih { get; set; }
        public decimal Toplam { get; set; }
    }
}
