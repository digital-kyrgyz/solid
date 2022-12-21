using DIP_IdealCode;

//using DIP_NotIdealCode;
namespace DIP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Not Ideal Code

            //MailService mailService = new();
            //mailService.Send(new Gmail());

            #endregion Not Ideal Code

            #region Ideal Code

            MailService mailService = new();
            mailService.SendMail(new Gmail(), "melis@gmail.com", "Hello from Australia");
            mailService.SendMail(new Hotmail(), "melis@hotmail.com", "Hello from me");

            #endregion Ideal Code
        }
    }
}