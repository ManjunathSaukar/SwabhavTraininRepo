using FixedDepositCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Policy
{
    internal class DiwaliRatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return 0.09;
        }
    }
}
