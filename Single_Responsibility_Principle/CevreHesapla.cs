using Single_Responsibility_Principle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class CevreHesapla
    {
        private IEnumerable<Sekil> _sekiller;
        public CevreHesapla(IEnumerable<Sekil> sekiller)
        {
            _sekiller = sekiller;
        }

        public double ToplamCevreUzunlugunuHesapla()
        {
            double _toplamCevre = 0;
            foreach (var sekil in _sekiller)
            {
                _toplamCevre += sekil.Cevre();
            }

            return _toplamCevre;
        }
    }
}
