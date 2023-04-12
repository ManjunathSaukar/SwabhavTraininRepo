using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnFacadeDesignPatternApp.Model
{
    internal class CoffeeProvider : ICoffee
    {
        public void GetColdCoffee()
        {
            Console.WriteLine("Getting Cold Coffee");
        }

        public void GetHotCoffee()
        {
            Console.WriteLine("Getting Hot Coffee");

        }
    }
}
