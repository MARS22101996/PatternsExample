using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Computer comp = new Computer();
                comp.Launch("My page");
                Console.WriteLine(comp.FaceBookPage.Name);
            }).Start();

            Computer comp1 = new Computer();
            comp1.Launch("Another page");
            Console.WriteLine(comp1.FaceBookPage.Name);
        }
    }
}
