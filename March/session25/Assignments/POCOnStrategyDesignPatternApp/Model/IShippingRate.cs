using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnStrategyDesignPatternApp.Model
{
    internal interface IShippingRate
    {
        double CalculateShippingCost(double weight);
    }
}
