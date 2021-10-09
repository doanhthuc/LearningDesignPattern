using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void Tranfer(IAccount to, decimal amount);
        int GetAccountNumber();
    }
}