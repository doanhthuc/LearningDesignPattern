using System;

namespace Facade
{
    class Customer
    {
        static void Main(string[] args)
        {
            BankService myBankService = new BankService();

            int mySaving = myBankService.createNewBankAccount("saving", 500.0m);

            int myInvesting = myBankService.createNewBankAccount("investment", 1000.0m);

            myBankService.TranferMoney(mySaving, myInvesting, 200.0m);
        }
    }
}
