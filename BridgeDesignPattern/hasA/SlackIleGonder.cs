using BridgeDesignPattern.hasA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.hasA
{
    internal class SlackIleGonder : IMesajGonder
    {
        public void Gonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına Slack mesajınız gönderildi. Mesajınız: {mesaj}");
        }
    }
}
