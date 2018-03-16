using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Salad salad = new GreekSalad();
            salad = new OilSalad(salad);
            salad = new SouceSalad(salad);
            Console.WriteLine("Название: {0}", salad.Name);
            Console.WriteLine("Цена: {0}", salad.GetCost());
        }
    }
}
