namespace BehaviorPatterns
{
    public class Transport
    {
        public TransportType _transport;

        public Transport(TransportType transport, IMovable move)
        {
            _transport = transport;
            Movable = move;
        }

        public IMovable Movable { private get; set; }

        public void Move()
        {
            Movable.Move();
        }
    }
}
