using System;

namespace Loose_Coupling_Dependency
{
    internal class MailSender
    {
        public void Send()
        {
            //Gmail gmail = new();
            //gmail.Send("melis99mrx@gmail.com");

            Yandex yandex = new();
            yandex.Send("melis99mrx@gmail.com");
        }
    }

    internal class Gmail
    {
        public void Send(string to)
        {
            Console.WriteLine($"Sending mail to: {to} in Gmail");
        }
    }

    internal class Yandex
    {
        public void Send(string to)
        {
            Console.WriteLine($"Sending mail to : {to} in Yandex");
        }
    }
}