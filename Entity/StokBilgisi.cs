using System;

namespace Entity
{
     public class StokBilgisi
    {
        public int StokId { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int GelenAdet { get; set; }
        public int StokMiktari { get; set; }
        public int ToplamStok { get; set; }
        public DateTime Tarih { get; set; }

    }
}
