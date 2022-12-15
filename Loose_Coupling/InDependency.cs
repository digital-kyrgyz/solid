using System;

namespace Loose_Coupling_InDependency
{
    internal class MailSender
    {
        internal void Send(IMailServer mailSender)
        {
            mailSender.Send("youraccount@gmail.com", "Hello");
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
            throw new NotImplementedException();
        }
    }

    internal class Yandex : IMailServer
    {
        public void Send(string to, string body)
        {
            throw new NotImplementedException();
        }
    }
}