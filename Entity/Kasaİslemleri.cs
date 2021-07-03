using System;


namespace Entity
{
    public class Kasaİslemleri
    {
        private string _Aciklama;
        public int KasaId { get; set; }
        public string Aciklama
        {
            get { return _Aciklama; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("KASAYA EKLEME BOŞ GEÇİLEMEZ");
                else
                   _Aciklama = value;
            }
        }
        public string OdemeTipi { get; set; }
        public decimal Gelen { get; set; }
        public decimal Cikan { get; set; }
        public DateTime Tarih { get; set; }
        public int Durum { get; set; }
    }
}
