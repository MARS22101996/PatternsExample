using System;

namespace Observer
{
    public class LvivPostOffice : IObserver
    {
        IObservable centralOffice;

        public LvivPostOffice(IObservable obs)
        {
            centralOffice = obs;
            centralOffice.RegisterObserver(this);
        }

        public void Update(string package)
        {
           Console.WriteLine($"{package} is delivered to Lviv Office");
        }
    }
}