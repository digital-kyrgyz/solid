using System;

namespace DIP_IdealCode
{
    internal class MailService
    {
        public void SendMail(IMailServer mailServer, string to, string body)
        {
            mailServer.Send(to, body);
        }
    }

    internal interface IMailServer
    {
        void Send(string to, string body);
    }

    internal class Gmail : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Gmail sending mail to: {to},the message" + body);
        }
    }

    internal class Yandex : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Yandex sending mail to: {to},the message" + body);
        }
    }

    internal class Hotmail : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Hotmail sending mail to: {to},the message" + body);
        }
    }
}