using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeletubbyGoF_Observer
{
    internal interface ISubject
    {
        public void AttachObserver(IObserver o);
        public void DetachObserver(IObserver o);
        public void NotifyObservers(ttEvents.ttEventType type);
    }
}
