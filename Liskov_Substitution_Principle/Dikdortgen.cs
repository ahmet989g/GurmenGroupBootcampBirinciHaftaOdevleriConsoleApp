using Liskov_Substitution_Principle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    internal class Dikdortgen : Sekil
    {
        private double KenarA;
        private double KenarB;

        public Dikdortgen(double kenarA, double kenarB)
        {
            this.KenarA = kenarA;
            this.KenarB = kenarB;
        }

        public override double AlanHesapla()
        {
            return KenarA * KenarB;
        }
    }
}
