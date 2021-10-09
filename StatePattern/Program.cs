using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine(2);
            machine.InsertDollar();
            machine.Dispense();
            Console.WriteLine("-------------------------------------");
            
            machine.Dispense();
            machine.InsertDollar();
            machine.EjectMoney();

            Console.WriteLine("-------------------------------------");
            machine.InsertDollar();
            machine.Dispense();

            Console.WriteLine("-------------------------------------");
            machine.InsertDollar();
        }
    }
}
