using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeletubbyGoF_Observer
{
    internal interface IObserver
    {
        public void Notify(ttEvents.ttEventType type);
    }
}
