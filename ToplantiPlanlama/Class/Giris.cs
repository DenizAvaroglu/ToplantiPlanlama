using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplantiPlanlama.Class
{
    internal class Giris
    {
        private string ad;
        private string soyad;
        private string kullaniciadi;
        private string sifre;

        public void setAd(string _ad)
        {  ad = _ad; }
        public string GetAd()
        { return ad; }

        
        public void setSoyad(string _soyad)
        { ad = _soyad; }
        public string GetSoyad()
        {  return soyad; }


        public void setKullaniciAdi(string _kullaniciadi)
        {  kullaniciadi= _kullaniciadi; }
        public string GetKullaniciAdi()
        { return kullaniciadi; }



        public void setSifre(string _sifre)
        {  sifre= _sifre; }
        public string GetSifre() 
        {  return sifre; }






    }
}
