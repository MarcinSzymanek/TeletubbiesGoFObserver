using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeletubbyGoF_Observer
{
    internal class BigTelephone : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void AttachObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void DetachObserver(IObserver o)
        {
            _observers.Remove(o);
        }
        public void NotifyObservers(ttEvents.ttEventType type)
        {
            foreach (var o in _observers)
            {
                o.Notify(type);
            }
        }
    }
}
