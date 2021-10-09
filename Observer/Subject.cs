using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver(Object arg)
        {
            _observers.ForEach(observer => observer.Notify(arg));
        }
    }
}