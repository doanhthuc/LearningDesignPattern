using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class OutOfStockState : State
    {
        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("Out of stock .... ");
        }

        public void EjectMoney(VendingMachine machine)
        {
            Console.WriteLine("Out of stock and Return money...");
            machine.DoReturnMoney();
        }

        public void InsertDollar(VendingMachine machine)
        {
            EjectMoney(machine);
        }
    }
}