using BridgeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Gonder
    {
        private IMesajGonder _mesajGonder;

        public Gonder(IMesajGonder mesajGonder)
        {
            _mesajGonder = mesajGonder;
        }

        public void MesajGonder(string mesajGonderilecekKisi, string email)
        {
            _mesajGonder.Gonder(mesajGonderilecekKisi, email);
        }
    }
}
