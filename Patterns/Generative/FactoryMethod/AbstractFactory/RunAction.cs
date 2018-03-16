using System;

namespace AbstractFactory
{
    public class RunAction: Action
    {
        public override void Move()
        {
             Console.WriteLine("Run");
        }
    }
}
