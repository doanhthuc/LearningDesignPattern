using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater.Decorators
{
    class Bubble : MilkteaDecorator
    {
        public Bubble(IMilktea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }

    }
}