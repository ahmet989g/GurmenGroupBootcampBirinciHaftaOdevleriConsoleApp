using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class CevreyiEkranaYazdir
    {
        private double _cevreUzunlugu;
        private string _sekilAdi;

        public CevreyiEkranaYazdir(double cevreUzunlugu, string sekilAdi)
        {
            _cevreUzunlugu = cevreUzunlugu;
            _sekilAdi = sekilAdi;
        }

        public void EkranaYaz()
        {
            Console.WriteLine(_sekilAdi + " Şeklinin Çevre Uzunluğu: " + _cevreUzunlugu);
        }
    }
}
