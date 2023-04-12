using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnStrategyDesignPatternApp.Model
{
    internal class ShippingCostCalculator
    {
        private readonly IShippingRate _shippingStrategy;

        public ShippingCostCalculator(IShippingRate shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(double weight)
        {
            return _shippingStrategy.CalculateShippingCost(weight);
        }
    }
}
