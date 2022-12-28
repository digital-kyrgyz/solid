using System;

namespace ISP_NotIdealCode
{
    internal interface IPrinter
    {
        void Print();

        void Scan();

        void Fax();

        void PrintDuplex();
    }

    internal class HPPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("HP Printer Fax operation");
        }

        public void Print()
        {
            Console.WriteLine("HP Print operation");
        }

        public void PrintDuplex()
        {
            Console.WriteLine("HP Print Duplex operation");
        }

        public void Scan()
        {
            Console.WriteLine("HP Scan operation");
        }
    }

    internal class SamsungPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Samsung Fax operation");
        }

        public void Print()
        {
            Console.WriteLine("Samsung Print operation");
        }

        public void PrintDuplex()
        {
            throw new NotSupportedException();
        }

        public void Scan()
        {
            throw new NotSupportedException();
        }
    }

    internal class LaxmarkPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Lexmark Fax operation");
        }

        public void Print()
        {
            Console.WriteLine("Lexmark Print operation");
        }

        public void PrintDuplex()
        {
            throw new NotSupportedException();
        }

        public void Scan()
        {
            throw new NotSupportedException();
        }
    }
}