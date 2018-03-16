using System;

namespace Observer
{
    public class KharkivPostOffice : IObserver
    {
        IObservable centralOffice;

        public KharkivPostOffice(IObservable obs)
        {
            centralOffice = obs;
            centralOffice.RegisterObserver(this);
        }

        public void Update(string package)
        {
            Console.WriteLine($"{package} is delivered to Kharkiv Office");
        }
    }
}
