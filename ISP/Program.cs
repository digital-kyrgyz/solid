using ISP_IdealCode;

//using ISP_NotIdealCode;

namespace ISP
{
    internal class Program
    {
        #region Not Ideal Code

        //Not Ideal Code
        //static void Main(string[] args)
        //{
        //    SamsungPrinter printer = new();
        //    printer.PrintDuplex();
        //}

        #endregion Not Ideal Code

        #region Ideal Code

        private static void Main()
        { //Ideal Code
            SamsungPrinter printer = new SamsungPrinter();
            printer.Print();
            printer.Fax();
            //Такого метода нет, это правильно
            //printer.Scan();
        }

        #endregion Ideal Code
    }
}