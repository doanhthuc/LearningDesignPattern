using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PennelAlfredo pennelAlfredo = new PennelAlfredo();
            SpaghettiMeatballs spaghettiMeatballs = new SpaghettiMeatballs();
            pennelAlfredo.MakeRecipe();
            Console.WriteLine("----------------------------------------------");
            spaghettiMeatballs.MakeRecipe();	
        }
    }
}
