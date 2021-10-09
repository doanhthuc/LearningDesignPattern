using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater.Decorators
{
    class EggPudding : MilkteaDecorator
    {
        public EggPudding(IMilktea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}