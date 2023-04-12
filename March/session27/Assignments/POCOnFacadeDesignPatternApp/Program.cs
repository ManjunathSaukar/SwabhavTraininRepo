using POCOnFacadeDesignPatternApp.Model;

namespace POCOnFacadeDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new CoffeeShopFacade();
            order.GetHotCoffee();
            order.GetColdCoffeee();
        }
    }
}