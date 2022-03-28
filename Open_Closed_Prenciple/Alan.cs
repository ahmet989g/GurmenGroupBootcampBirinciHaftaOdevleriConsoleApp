using Open_Closed_Prenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Prenciple
{
    internal class Alan
    {
        private Sekil _sekil;
        public Alan(Sekil sekil)
        {
            _sekil = sekil;
        }

        public double Hesapla()
        {
            return _sekil.AlanHesapla();
        }
    }
}
