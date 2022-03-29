using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.hasA.Interfaces
{
    internal interface IMesajGonder
    {
        void Gonder(string mesajGonderilecekKullanici, string mesaj);
    }
}
