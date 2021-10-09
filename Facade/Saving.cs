using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Saving : IAccount 
    {
        private readonly decimal amount;
        public Saving(decimal initAmount)
        {
            amount = initAmount;
        }
        public void Deposit(decimal amount)
        {
            Console.WriteLine("Make deposit money...");
        }

        public int GetAccountNumber()
        {
            return 2;
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