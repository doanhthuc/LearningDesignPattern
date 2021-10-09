using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class BankService
    {
        private Dictionary<int, IAccount> bankAccounts;
        public BankService()
        {
            this.bankAccounts = new Dictionary<int, IAccount>();
        }

        public int createNewBankAccount(string type, decimal initAmount) {
            IAccount newAccount = null;
            switch (type)
            {
                case "chequing":
                    newAccount = new Chequing(initAmount);
                    break;
                case "saving":
                    newAccount = new Saving(initAmount);
                    break;
                case "investment":
                    newAccount = new Investment(initAmount);
                    break;
                default:
                    Console.WriteLine("Invalid type: " + type);
                    break;
            }
            if (newAccount == null) return -1;
            this.bankAccounts[newAccount.GetAccountNumber()] = newAccount; 
            return newAccount.GetAccountNumber();
        }

        public void TranferMoney(int to, int from, decimal amount) {
            IAccount toAccount = this.bankAccounts[to];
            IAccount fromAccount = this.bankAccounts[from];
            fromAccount.Tranfer(toAccount, amount);
        }
    }
}