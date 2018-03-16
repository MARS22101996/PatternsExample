using System;

namespace BehaviorPatterns
{
    public class TrainMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Travel by train");
        }
    }
}
