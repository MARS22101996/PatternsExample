namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralPostOffice central = new CentralPostOffice();
            KharkivPostOffice kharkiv = new KharkivPostOffice(central);
            LvivPostOffice lviv = new LvivPostOffice(central);
            central.NotifyObservers();
        }
    }
}
