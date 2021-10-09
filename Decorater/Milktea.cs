using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Milktea : IMilktea
    {
        public double Cost()
        {
            return 5d;
        }
    }
}