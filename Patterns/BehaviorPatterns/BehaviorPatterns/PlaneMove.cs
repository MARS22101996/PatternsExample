using System;

namespace BehaviorPatterns
{
    public class PlaneMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Travel by plane");
        }
    }
}
