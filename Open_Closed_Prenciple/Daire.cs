using Open_Closed_Prenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Prenciple
{
    internal class Daire : Sekil
    {
        public double YariCap { get; set; }

        public override double AlanHesapla()
        {
            return 3.14 * YariCap * YariCap;
        }
    }
}
