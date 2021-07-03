

using System;

namespace Entity
{
   public class Urunİade
    {
        private string _BarkodNo;
        private string _UrunAdi;
        private string _İadeSebeb;
        public int İadeId { get; set; }
        public int PersonelID { get; set; }
        public string BarkodNo
        {
            get { return _BarkodNo; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("BORKOD KODU BOŞ GEÇİLEMEZ");
                else
                _BarkodNo = value;
            }
        }
        public string UrunAdi
        {
            get { return _UrunAdi; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("ÜRÜN ADI BOŞ GEÇİLEMEZ");
                _UrunAdi = value;
            }
        }
        public decimal Fiyat { get; set; }
        public int Miktar { get; set; }
        public decimal Toplam { get; set; }
        public string İadeSebeb
        {
            get { return _İadeSebeb; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("İADE SEBEBİ BOŞ GEÇİELEMEZ");
                _İadeSebeb = value;
            }
        }
        public DateTime Tarih { get; set; }

    }
}
