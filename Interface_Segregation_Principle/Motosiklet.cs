using Interface_Segregation_Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    internal class Motosiklet : IArac, IYakit
    {
        public void İleri()
        {
            Console.WriteLine("İleri");
        }

        public void Geri()
        {
            Console.WriteLine("Geri");
        }

        public void Saga()
        {
            Console.WriteLine("Sağa");
        }

        public void Sola()
        {
            Console.WriteLine("Sola");
        }

        public void OrtalamaYakitTuketimiHesapla()
        {
            Console.WriteLine("Ortalama Yakıt Tüketimini Hesapla");
        }
    }
}
