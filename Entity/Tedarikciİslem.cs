using System;

namespace Entity
{
    public class Tedarikciİslem
    {
        public int IslemID { get; set; }
        public string FirmaAdi { get; set; }
        public string İslem { get; set; }
        public decimal Borcun { get; set; }
        public decimal Aldiklarim { get; set; }
        public decimal Odemelerim { get; set; }
        public DateTime Tarih { get; set; }
    }
}
