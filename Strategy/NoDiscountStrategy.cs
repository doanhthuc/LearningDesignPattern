using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}