using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothesManufacturer womenManufacturer = new WomenClothesManufacturer("Women");
            Clothes womanClothes = womenManufacturer.Create();

            ClothesManufacturer menManufacturer = new MenClothesManufacturer("Men");
            Clothes menClothes = menManufacturer.Create();
        }
    }
}
