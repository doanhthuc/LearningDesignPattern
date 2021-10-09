using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Chequing : IAccount
    {
        private readonly decimal amount;
        public Chequing(decimal initAmount)
        {
            amount = initAmount;
        }
        public void Deposit(decimal amount)
        {
            Console.WriteLine("Make deposit money...");
        }

        public int GetAccountNumber()
        {
            return 1;
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