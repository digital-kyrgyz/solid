using System;

namespace DIP
{
    internal class MailService
    {
        public void Send(Gmail gmail)
        {
            gmail.Send("melis@gmail.com");
        }
    }

    internal class Gmail
    {
        public void Send(string mail)
        {
            Console.WriteLine("Gmail sending mail");
        }
    }

    internal class Yandex
    {
        public void SendMail(string mail, string to)
        {
            Console.WriteLine("Yandex sending mail");
        }
    }

    internal class HotMail
    {
        public void SendMail(string mail, string to, string message)
        {
            Console.WriteLine("HotMail sending mail");
        }
    }
}