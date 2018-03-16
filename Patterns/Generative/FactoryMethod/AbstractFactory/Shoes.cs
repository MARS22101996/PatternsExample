using System;

namespace AbstractFactory
{
    public class Shoes : SportWear
    {
        public override void Wear()
        {
            Console.WriteLine("Shoes are weared");
        }
    }
}
