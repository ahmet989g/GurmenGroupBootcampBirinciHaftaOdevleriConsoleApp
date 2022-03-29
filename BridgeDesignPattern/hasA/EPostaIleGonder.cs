using BridgeDesignPattern.hasA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.hasA
{
    internal class EPostaIleGonder : IMesajGonder
    {
        public void Gonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına E-Posta gönderildi. Mesajınız: {mesaj}");
        }
    }
}
