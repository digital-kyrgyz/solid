using OCP_IdealCode;

namespace OCP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MoneySender moneySender = new MoneySender();
            moneySender.Send(new OptimaBank(), 5000, "To Melis Account");
            moneySender.Send(new NationalBank(), 4000, "To Aibek Account");
        }
    }
}