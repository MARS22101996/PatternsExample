using System;

namespace AbstractFactory
{
    public class SwimAction : Action
    {
        public override void Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
