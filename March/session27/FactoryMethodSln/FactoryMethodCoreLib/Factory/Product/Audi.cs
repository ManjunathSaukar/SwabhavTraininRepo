using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory.Product
{
    internal class Audi : IAutoMobile
    {
        public void start()
        {
            Console.WriteLine("Audi starts");
        }

        public void stop()
        {
            Console.WriteLine("Audi stops");

        }
    }
}
