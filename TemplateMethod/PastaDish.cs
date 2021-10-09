using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class PastaDish
    {
        public void MakeRecipe() { 
            BoilWater();
            AddPasta();
            CookPasta();
            DrainAndPlate();
            AddSauce();
            AddProtein();
            AddGranish();
        }

        protected abstract void AddPasta();
        protected abstract void AddSauce();
        protected abstract void AddProtein();
        protected abstract void AddGranish();

        private void BoilWater() {
            Console.WriteLine("BoilWater ....");
        }
        private void DrainAndPlate()
        {
            Console.WriteLine("Drain and Plate ....");
        }

        private void CookPasta()
        {
            Console.WriteLine("Cook Pasta ....");
        }
    }
}