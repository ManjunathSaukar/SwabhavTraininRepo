using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory.Product
{
    internal class Tesla : IAutoMobile
    {
        public void start()
        {
            Console.WriteLine("Tesla starts");
        }

        public void stop()
        {
            Console.WriteLine("Tesla stops");

        }
    }
}
