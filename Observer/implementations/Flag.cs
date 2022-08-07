using CSharpGoFPatterns.Observer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Observer.implementations
{
    internal class Flag : interfaces.ISubject
    {
        public string Team { get; set; }
        public string TeamOwner { get; set; }
        private List<interfaces.IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(interfaces.IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
