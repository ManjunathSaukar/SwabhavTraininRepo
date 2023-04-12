using StrategyDesignPatternWithDelegates.Model;

namespace StrategyDesignPatternWithDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DShippingRate groundShipping = weight => weight * 10;
            DShippingRate airShipping = weight => weight * 50;
            DShippingRate expressShipping = weight => weight * 100;

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