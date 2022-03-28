using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Abstract
{
    internal class Sekil
    {
        private ISekilCizdir _sekilCizdir;

        public Sekil(ISekilCizdir sekilCizdir)
        {
            _sekilCizdir = sekilCizdir;
        }

        public void SekilCiz()
        {
            _sekilCizdir.SekilCiz();
        }
    }
}
