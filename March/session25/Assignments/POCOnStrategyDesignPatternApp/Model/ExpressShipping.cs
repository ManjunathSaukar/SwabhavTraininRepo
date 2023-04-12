using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnStrategyDesignPatternApp.Model
{
    internal class ExpressShipping : IShippingRate
    {
        public double CalculateShippingCost(double weight)
        {
            return weight* 100;
        }
    }
}
