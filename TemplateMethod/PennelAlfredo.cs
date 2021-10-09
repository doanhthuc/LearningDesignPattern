using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class PennelAlfredo : PastaDish
    {
        protected override void AddGranish()
        {
            Console.WriteLine("Add Garnish PennelAlfredo....");
        }

        protected override void AddPasta()
        {
            Console.WriteLine("Add Pasta PennelAlfredo....");
        }

        protected override void AddProtein()
        {
            Console.WriteLine("Add Protein PennelAlfredo....");
        }

        protected override void AddSauce()
        {
            Console.WriteLine("Add Sauce PennelAlfredo....");
        }
    }
}