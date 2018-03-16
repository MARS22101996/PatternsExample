using System.Collections.Generic;

namespace Observer
{
    public class CentralPostOffice : IObservable
    {
        List<IObserver> observers;
        private string package;
        public CentralPostOffice()
        {
            observers = new List<IObserver>();
            package = "package";
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(package);
            }
        }
    }
}
