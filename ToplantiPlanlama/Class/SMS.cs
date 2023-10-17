using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplantiPlanlama.Class
{
    internal class SMS:Giris
    {
        
        private string KisiAdi;
        private string Mesaj;



        public void  setKISIADI(string _KisiAdi)
        {
            KisiAdi = _KisiAdi;
        }


        public string GetKISIADI() 
        {
            return KisiAdi;
        }
    


        public void setMESAJ(string _Mesaj)
        {
            Mesaj= _Mesaj;
        }
    
       public string GetMESAJ()
        {  return Mesaj;}
    
    
    
    
    
    
    
    
    }
}
