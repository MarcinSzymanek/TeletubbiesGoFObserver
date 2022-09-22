using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeletubbyGoF_Observer
{
    internal class Teletubby : IObserver
    {
        private string _name;
        public Teletubby(string n)
        {
            _name = n;
        }
        public void Notify(ttEvents.ttEventType type)
        {
            if(type == ttEvents.ttEventType.WAKE_UP)
            {
                WakeUp();
            }
            else if(type == ttEvents.ttEventType.HAVE_DINNER)
            {
                EatDinner();
            }
            else if(type == ttEvents.ttEventType.WATCH_TV)
            {
                WatchTv();
            }
            else if(type == ttEvents.ttEventType.SAY_BYE)
            {
                SayBye();
            }
        }

        private void SayBye()
        {
            Console.WriteLine(_name + " says 'buh-bye' before heading to masturbate with the others.");
        }
        private void EatDinner()
        {
            Console.WriteLine(_name + " gets to the table to stuff its fucking face with delicious food!");
        }
        private void WatchTv()
        {
            Console.WriteLine(_name + " sits down to watch some telly!!");
        }
        private void WakeUp()
        {
            Console.WriteLine(_name + " is getting ready for a beautiful fucking day!");
        }
    }
}
