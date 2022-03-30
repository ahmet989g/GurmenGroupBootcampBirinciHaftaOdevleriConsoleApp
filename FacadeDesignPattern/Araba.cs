using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{

    internal class Debriyaj
    {
        public void Bas()
        {
            Console.WriteLine("Debriyaja Basıldı.");
        }
    }

    internal class Vites
    {
        public void BosaAl()
        {
            Console.WriteLine("Vites Boşa Alındı.");
        }

        public void Vites1()
        {
            Console.WriteLine("1. Vitese Geçildi.");
        }
    }

    internal class Kontak
    {
        public void Cevir()
        {
            Console.WriteLine("Kontak Çevirildi.");
        }
    }

    internal class Fren
    {
        public void Bas()
        {
            Console.WriteLine("Frene Basıldı.");
        }
        public void Kaldir()
        {
            Console.WriteLine("Frenden Çekildi.");
        }
    }

    internal class ElFreni
    {
        public void Indir()
        {
            Console.WriteLine("El Freni İndirildi.");
        }
    }

    internal class DebriyajGazIliskisi
    {
        public void DebriyajdanKaldirGazaBas()
        {
            Console.WriteLine("Araç Hareket Etti.");
        }
    }

}
