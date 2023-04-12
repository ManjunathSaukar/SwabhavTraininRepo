using POCOnStrategyDesignPatternApp.Model;

namespace POCOnStrategyDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var groundShipping = new GroundShipping();
            var airShipping = new AirShipping();
            var expressShipping = new ExpressShipping();

            var calculator = new ShippingCostCalculator(groundShipping);
            var cost = calculator.CalculateShippingCost(10.0);
            Console.WriteLine($"The cost of shipping via Ground for the given weight is : {cost}");

            calculator = new ShippingCostCalculator(airShipping);
            cost = calculator.CalculateShippingCost(10.0);
            Console.WriteLine($"The cost of shipping via Air for the given weight is : {cost}");

            calculator = new ShippingCostCalculator(expressShipping);
            cost = calculator.CalculateShippingCost(10.0);
            Console.WriteLine($"The cost of shipping via Express Shipping for the given weight is : {cost}");
        }
    }
}