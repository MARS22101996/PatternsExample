using System;

namespace BehaviorPatterns
{
    public class BusMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Travel by bus");
        }
    }
}
