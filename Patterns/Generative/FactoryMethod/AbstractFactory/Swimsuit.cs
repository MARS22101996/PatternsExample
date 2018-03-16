using System;

namespace AbstractFactory
{
    public class Swimsuit : SportWear
    {
        public override void Wear()
        {
            Console.WriteLine("Swimsuit is weared");
        }
    }
}
