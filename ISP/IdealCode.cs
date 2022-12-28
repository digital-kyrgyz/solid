using System;

namespace ISP_IdealCode
{
    internal interface IPrinter
    {
        void Print();
    }

    internal interface IScan
    {
        void Scan();
    }

    internal interface IFax
    {
        void Fax();
    }

    internal interface IPrintDublex
    {
        void PrintDublex();
    }

    internal class HPPrinter : IPrinter, IScan, IFax, IPrintDublex
    {
        public void Fax()
        {
            Console.WriteLine("HP Print operation");
        }

        public void Print()
        {
            Console.WriteLine("HP print operation");
        }

        public void PrintDublex()
        {
            Console.WriteLine("HP Print Dublex operation");
        }

        public void Scan()
        {
            Console.WriteLine("HP Scan operation");
        }
    }

    internal class SamsungPrinter : IPrinter, IFax
    {
        public void Fax()
        {
            Console.WriteLine("Samsung Fax operation");
        }

        public void Print()
        {
            Console.WriteLine("Samsung Print operation");
        }
    }

    internal class LexmarkPrinter : IFax, IPrinter, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Lexmark Fax operation");
        }

        public void Print()
        {
            Console.WriteLine("Lexmark Print operation");
        }

        public void Scan()
        {
            Console.WriteLine("Lexmark Scan operation");
        }
    }
}