using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Abstract
{
    internal class DaireCizdir : ISekilCizdir
    {
        public void SekilCiz()
        {
            Console.WriteLine("Daire Şekli Çiz.");
        }
    }
}
