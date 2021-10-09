using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Ticket
    {
        public IPromoteStrategy PromoteStrategy { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Ticket()
        {

        }
        public Ticket(IPromoteStrategy promoteStrategy)
        {
            PromoteStrategy = promoteStrategy;
        }
        public double GetPromotedPrice()
        {
            return PromoteStrategy.DoDiscount(Price);
        }
    }
}