using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater.Decorators
{
    class FruitPudding : MilkteaDecorator
    {
        public FruitPudding(IMilktea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}