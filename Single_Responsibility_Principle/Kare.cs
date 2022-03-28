using Single_Responsibility_Principle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class Kare : Sekil
    {
        private double _kenarUzunlugu;

        public Kare(double kenarUzunlugu)
        {
            _kenarUzunlugu = kenarUzunlugu;
        }

        public override double Cevre()
        {
            return _kenarUzunlugu * 4;
        }
    }
}
