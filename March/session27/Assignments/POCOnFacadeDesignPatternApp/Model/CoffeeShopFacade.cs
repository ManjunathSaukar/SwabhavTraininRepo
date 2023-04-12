using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnFacadeDesignPatternApp.Model
{
    internal class CoffeeShopFacade
    {
        private ICoffee _coffeeProvider;

        public CoffeeShopFacade()
        {
            _coffeeProvider = new CoffeeProvider();
        }
        public void GetColdCoffeee()
        {
            _coffeeProvider.GetColdCoffee();
        }
        public void GetHotCoffee()
        {
            _coffeeProvider.GetHotCoffee();
        }
    }
}
