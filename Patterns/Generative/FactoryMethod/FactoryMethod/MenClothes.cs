using System;

namespace FactoryMethod
{
    public class MenClothes : Clothes
    {
        public MenClothes()
        {
            Console.WriteLine("Men clothes are produced");
        }
    }
}