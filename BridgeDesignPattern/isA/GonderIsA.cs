using BridgeDesignPattern.isA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.isA
{

    internal class GonderIsA : IMesajGonderIsA
    {
        private IMesajGonderIsA _mesajGonder;
        public void EPostaIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına E-Posta gönderildi. Mesajınız: {mesaj}");
        }

        public void SlackIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına Slack mesajınız gönderildi. Mesajınız: {mesaj}");
        }

        public void WhatsAppIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına WhatsApp mesajınız gönderildi. Mesajınız: {mesaj}");
        }

        public void FacebookIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına Facebook mesajınız gönderildi. Mesajınız: {mesaj}");
        }
    }

    internal class SadeceEpostaIleGonder : IMesajGonderIsA
    {
        public void EPostaIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            Console.WriteLine($"{mesajGonderilecekKullanici} kullanıcısına E-Posta gönderildi. Mesajınız: {mesaj}");
        }

        public void SlackIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            throw new NotImplementedException();
        }

        public void WhatsAppIleGonder(string mesajGonderilecekKullanici, string mesaj)
        {
            throw new NotImplementedException();
        }
    }
}
