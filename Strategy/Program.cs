using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting tickets!");

            var random = new Random();

            for (var i = 1; i <= 5; i++)
            {
                var ticket = new Ticket();
                ticket.Name = $"Ticket {i}";
                ticket.Price = 50 * i;
                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);
            }
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            var promotedPrice = ticket.GetPromotedPrice();
            Console.WriteLine(
                $"Promoted price of {ticket.Name}: {promotedPrice} {ticket.PromoteStrategy.GetType().Name}\n");
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 4);
            switch (strategyIndex)
            {
                case 0:
                    ticket.PromoteStrategy = new NoDiscountStrategy();
                    break;
                case 1:
                    ticket.PromoteStrategy = new QuaterDiscountStategy();
                    break;
                case 2:
                    ticket.PromoteStrategy = new HalfDiscountStrategy();
                    break;
                default: 
                    ticket.PromoteStrategy = new EightyDiscountStrategy();
                    break;
            }
        }
    }
}
