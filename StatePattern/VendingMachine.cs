using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class VendingMachine
    {
        public State IdleState { get; set; }
        public State HasOneDollarState { get; set; }
        public State OutOfStockState { get; set; }
        public State CurrentState { get; set; }
        public int Count { get; set; }
        public VendingMachine(int count)
        {
            Console.WriteLine("Initialize vending machine with {0} products", count);
            IdleState = new IdleState();
            HasOneDollarState = new HasOneDollarState();
            OutOfStockState = new OutOfStockState();
            if (count > 0) {
                CurrentState = IdleState;
                Count = count;
            } else {
                CurrentState = OutOfStockState;
                Count = 0;
            }
        }

        public void InsertDollar() {
            CurrentState.InsertDollar(this);
        }

        public void EjectMoney() {
            CurrentState.EjectMoney(this);
        }

        public void Dispense() {
            CurrentState.Dispense(this);
        }
        public void DoReleaseProduct() {
            Console.WriteLine("Release selected product in machine And decrease product count ....");
            Count -= 1;
        }
        public void DoReturnMoney() {
            Console.WriteLine("Machine return money....");
        }
    }
}