using System;

namespace Entity
{
    public class Personeller
    {
        private string _Adi;

        private string _Soyadi;

        private string _Unvani;

        private string _KAdi;

        private string _Sifre;
        public int PersonelId { get; set; }
        public int TipID { get; set; }
        public string Adi
        {
            get { return _Adi; }
            set
            {
                if (_Adi == string.Empty)
                    throw new Exception("Personel Adı Boş Geçilemez");
                else
                _Adi = value;
            }
        }
        public string Soyadi
        {
            get { return _Soyadi;}
            set
            {
                if (_Soyadi == string.Empty)
                    throw new Exception("Personel Soyadı Boş Geçilemez");
                else
                    _Soyadi = value;
            }
        }
        public string Unvani
        {
            get { return _Unvani; }
            set
            {
                if (_Unvani == string.Empty)
                    throw new Exception("Personel Görevi Boş Geçilemez");
                else
                    _Unvani = value;
            }
        }
        public string KAdi
        {
            get { return _KAdi; }
            set
            {
                if (_KAdi == string.Empty)
                    throw new Exception("Personel Kullanıcı Adı Boş Geçilemez");
                else
                    _KAdi = value;
            }
        }
        public string Sifre
        {
            get { return _Sifre; }
            set
            {
                if (_Sifre == string.Empty)
                    throw new Exception("Personel Şifre Boş Geçilemez");
                else
                    _Sifre = value;
            }
        }
    }
}
