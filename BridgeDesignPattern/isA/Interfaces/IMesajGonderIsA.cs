using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.isA.Interfaces
{
    internal interface IMesajGonderIsA
    {
        void EPostaIleGonder(string mesajGonderilecekKullanici, string mesaj);
        void WhatsAppIleGonder(string mesajGonderilecekKullanici, string mesaj);
        void SlackIleGonder(string mesajGonderilecekKullanici, string mesaj);
    }
}
