// See https://aka.ms/new-console-template for more information
using TeletubbyGoF_Observer;

Console.WriteLine("TeletubbieS!!!!");

Teletubby TinkyWinky = new Teletubby("Tinky-Winky");
Teletubby Lala = new Teletubby("Lala");
Teletubby Dipshit = new Teletubby("Dipshit");
Teletubby Poo = new Teletubby("Poo");

BigTelephone bigPhone = new BigTelephone();

bigPhone.AttachObserver(TinkyWinky);
bigPhone.AttachObserver(Lala);
bigPhone.AttachObserver(Dipshit);
bigPhone.AttachObserver(Poo);

System.Threading.Thread.Sleep(2000);

Console.WriteLine("\nDA PHON RINGS WAKY WAKY!!!\n");

bigPhone.NotifyObservers(ttEvents.ttEventType.WAKE_UP);

System.Threading.Thread.Sleep(2000);

Console.WriteLine("\nNOW YOU EAT SHIT, PIGGIES!!!\n");

bigPhone.NotifyObservers(ttEvents.ttEventType.HAVE_DINNER);

System.Threading.Thread.Sleep(2000);

Console.WriteLine("\n SITDOWN AN 'AVE SUM TELLY!!\n");

bigPhone.NotifyObservers(ttEvents.ttEventType.WATCH_TV);

System.Threading.Thread.Sleep(2000);

Console.WriteLine("\n GET TO BED MY LIL PIGGIEEES!!!\n");

bigPhone.NotifyObservers(ttEvents.ttEventType.SAY_BYE);

System.Threading.Thread.Sleep(2000);