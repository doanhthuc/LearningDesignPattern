using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class IdleState : State
    {
        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("payment required....");
        }

        public void EjectMoney(VendingMachine machine)
        {
            Console.WriteLine("No money return....");
        }

        public void InsertDollar(VendingMachine machine)
        {
            Console.WriteLine("Dollar inserted....");
            machine.CurrentState = machine.HasOneDollarState;
        }
    }
}