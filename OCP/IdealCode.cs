using System;

namespace OCP_IdealCode
{
    internal class MoneySender
    {
        internal void Send(IBank bank, int amount, string accountNumber)
        {
            bank.MoneyTransfer(amount, accountNumber);
        }
    }

    internal interface IBank
    {
        bool MoneyTransfer(int amount, string accountNumber);
    }

    internal class OptimaBank : IBank
    {
        internal string AccountNumber { get; set; }

        internal void MoneySend(int amount)
        {
        }

        public bool MoneyTransfer(int amount, string accountNumber)
        {
            try
            {
                AccountNumber = accountNumber;
                MoneySend(amount);
                Console.WriteLine("OptimaBank transfer money");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    internal class NationalBank : IBank
    {
        private string _accountNumber;

        internal void GetAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
            Console.WriteLine("Getting accountNumber");
        }

        internal void MoneySend(int amount)
        {
            Console.WriteLine("NationalBank sending money");
        }

        public bool MoneyTransfer(int amount, string accountNumber)
        {
            try
            {
                MoneySend(amount);
                Console.WriteLine("NationalBank transfer money");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    internal class MelisBank : IBank
    {
        public bool MoneyTransfer(int amount, string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}