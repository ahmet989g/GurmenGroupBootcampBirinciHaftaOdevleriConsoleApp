using Single_Responsibility_Principle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class Daire : Sekil
    {
        private double _cevre;

        public Daire(double cevre)
        {
            _cevre = cevre;
        }

        public override double Cevre()
        {
            return 2* _cevre*3.14;
        }
    }
}
