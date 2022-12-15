using Loose_Coupling_InDependency;

namespace Loose_Coupling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MailSender sender = new();
            sender.Send(new Gmail());
            sender.Send(new Yandex());
        }
    }
}