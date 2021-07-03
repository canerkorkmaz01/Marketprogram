using System;

namespace Entity
{
   public class SatisDetaylari
    {
        public int SatisDetayId { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Miktar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string SatisTürü { get; set; }
        public decimal İndirim { get; set; }
        public decimal Kar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
