using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater.Decorators
{
    class WhiteBubble : MilkteaDecorator
    {
        public WhiteBubble(IMilktea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}