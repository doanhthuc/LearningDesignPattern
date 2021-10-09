using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class SpaghettiMeatballs : PastaDish
    {
        protected override void AddGranish()
        {
            Console.WriteLine("Add Garnish MeatBall....");
        }

        protected override void AddPasta()
        {
            Console.WriteLine("Add Pasta MeatBall....");
        }

        protected override void AddProtein()
        {
            Console.WriteLine("Add Protein MeatBall....");
        }

        protected override void AddSauce()
        {
            Console.WriteLine("Add Sauce MeatBall....");
        }
    }
}