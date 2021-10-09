using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class HasOneDollarState : State
    {
        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("Releasing Product....");
            if (machine.Count > 1) {
                machine.DoReleaseProduct();
                machine.CurrentState = machine.IdleState;
            } else {
                machine.DoReleaseProduct();
                machine.CurrentState = machine.OutOfStockState;
            }
        }

        public void EjectMoney(VendingMachine machine)
        {
            Console.WriteLine("Return money....");
            machine.CurrentState = machine.IdleState;
        }

        public void InsertDollar(VendingMachine machine)
        {
            Console.WriteLine("Returning money...");
            machine.DoReturnMoney();
            machine.CurrentState = machine.IdleState;
        }
    }
}