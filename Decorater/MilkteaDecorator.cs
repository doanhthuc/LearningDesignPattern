using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    abstract class MilkteaDecorator : IMilktea
    {
        private IMilktea _milktea;
        protected MilkteaDecorator(IMilktea inner)
        {
            _milktea = inner;
        }
        public virtual double Cost()
        {
            return _milktea.Cost();
        }
    }
}