using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CarParts
{
    class Engine
    {
        public string Name { get; set; }

        public Engine(string name)
        {
            Name = name;
        }
    }
}