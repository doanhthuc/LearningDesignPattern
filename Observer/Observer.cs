using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Observer
    {
        protected Subject Subject;
        public abstract void Notify(object args);
    }
}