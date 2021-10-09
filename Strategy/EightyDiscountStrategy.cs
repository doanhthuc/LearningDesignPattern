using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class EightyDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {

            return price * 0.2;
        }
    }
}