using System;

namespace Entity
{
    public class Tedarikciler
    {
        private string _SirketAdi;
        private string _Yetkili;
        private string _Telefon;
        private string _Adres;
        public int TedarikciId { get; set; }
        public string SirketAdi
        {
            get { return _SirketAdi; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Şirket Adı Boş Geçilmez");    
                else                 
                _SirketAdi = value;
            }
        }
        public string Yetkili
        {
            get { return _Yetkili; }
            set {
                if (value == string.Empty)
                    throw new Exception("Yetkil Adı Boş Geçilmez");
                else
                _Yetkili = value;
                }
        }
        public string Telefon
        {
            get { return _Telefon; }
            set {
                  if(value == string.Empty)
                    throw new Exception("Telefon Numarası Boş Geçilmez");
                  else
                    _Telefon = value;
                }
        }
        public string WebSayfasi { get; set; }
        public string Adres
        {
            get { return _Adres; }
            set {
                if(value == string.Empty)
                    throw new Exception("Adres Bilgisi Boş Geçilmez");
                else _Adres = value;
                }
        }
        public string Email { get; set; }
        public decimal Borcun { get; set; }
        public decimal Aldiklarim { get; set; }
        public decimal Odemelerim { get; set; }
        public DateTime Tarih { get; set; }
    }
}

