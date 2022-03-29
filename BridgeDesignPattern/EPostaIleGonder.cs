using BridgeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class EPostaIleGonder : IMesajGonder
    {
        public void Gonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına E-Posta gönderildi. Mesajınız: {mesaj}");
        }
    }
}
