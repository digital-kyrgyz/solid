using System;

namespace OCP_NotIdealCode
{
    internal class MoneySender
    {
        internal void Send(int amount)
        {
            //Это код показывает то что изменение кода, а не расширение кода
            //Сначала удаляем старые коды или его изменяем, потом пропишем новый код.

            //OptimaBank optimaBank = new();
            //optimaBank.AccountNumber = "123123123123123";
            //optimaBank.MoneySend(amount);

            NationalBank nationalBank = new();
            nationalBank.SendAccountNumber("10982370921830129");
            nationalBank.SendMoney(amount);
        }
    }

    internal class OptimaBank
    {
        internal string AccountNumber { get; set; }

        internal void MoneySend(int amount)
        {
            Console.WriteLine("Send money in Guarantee");
        }
    }

    internal class NationalBank
    {
        private string _accountNumber;

        internal void SendAccountNumber(string accountNumber)
        {
            Console.WriteLine("Get accountNumber in NationalBank");
        }

        internal void SendMoney(int amount)
        {
            Console.WriteLine("Send money in NationalBank");
        }
    }
}