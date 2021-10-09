using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Investment : IAccount
    {
        private readonly decimal amount;
        public Investment(decimal initAmount)
        {
            amount = initAmount;
        }
        public void Deposit(decimal amount)
        {
            Console.WriteLine("Make deposit money...");
        }

        public int GetAccountNumber()
        {
            return 3;
        }

        public void Tranfer(IAccount to, decimal amount)
        {
            Console.WriteLine("Make Tranfer money...");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine("Make Withdraw money...");
        }
    }
}