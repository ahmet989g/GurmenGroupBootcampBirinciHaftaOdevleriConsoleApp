using Open_Closed_Prenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Prenciple
{
    internal class Dikdortgen : Sekil
    {
        public double KenarA { get; set; }
        public double KenarB { get; set; }

        public override double AlanHesapla()
        {
            return KenarA * KenarB;
        }
    }
}
