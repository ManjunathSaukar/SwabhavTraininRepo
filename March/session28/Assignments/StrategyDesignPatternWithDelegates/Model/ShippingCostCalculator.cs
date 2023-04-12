using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternWithDelegates.Model
{
    delegate double DShippingRate(double weight);
    internal class ShippingCostCalculator
    {
        private readonly DShippingRate _shippingStrategy;
        public ShippingCostCalculator(DShippingRate shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(double weight)
        {
            return _shippingStrategy(weight);
        }
    }
}
