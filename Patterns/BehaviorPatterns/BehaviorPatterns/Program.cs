namespace BehaviorPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport auto = new Transport(TransportType.Bus, new BusMove());
            auto.Move();
            auto._transport = TransportType.Plane;
            auto.Movable = new PlaneMove();
            auto.Move();

        }
    }
}
