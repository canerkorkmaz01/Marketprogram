using System;

namespace Entity
{
    public class Musteriler
    {
        private string _Adi;
        private string _Soyadi;
        public int MusteriId { get; set; }
        public string Adi
        {
            get { return _Adi; }
            set {
                if (value == string.Empty)
                    throw new Exception("Müşteri Adı Boş Geçilemez");
                else
                    _Adi = value;
               }
        }
        public string Soyadi
        {
            get { return _Soyadi; ; }
            set {
                  if(value == string.Empty)
                    throw new Exception("Soyadi Boş Geçilemez");
                else _Soyadi = value;
            }
        }
        public string Adres { get; set; }
        public string  Telefonu { get; set; }
        public decimal Borc { get; set; }
        public decimal BorcOdemeleri { get; set; }
        public decimal Limit { get; set; }
        public DateTime Tarih  { get; set; }
    }
}
