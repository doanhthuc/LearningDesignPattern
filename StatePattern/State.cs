using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    interface State
    {
        void InsertDollar(VendingMachine machine);
        void EjectMoney(VendingMachine machine);
        void Dispense(VendingMachine machine);
    }
}