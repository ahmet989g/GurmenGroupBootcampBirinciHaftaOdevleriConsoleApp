using Liskov_Substitution_Principle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    internal class Kare : Sekil
    {
        private double _kenar;
        public Kare(double kenar)
        {
            _kenar = kenar;
        }

        public override double AlanHesapla()
        {
            return _kenar * _kenar;
        }
    }
}
