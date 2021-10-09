using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater.Decorators
{
    class BlackSugar : MilkteaDecorator
    {
        public BlackSugar(IMilktea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}