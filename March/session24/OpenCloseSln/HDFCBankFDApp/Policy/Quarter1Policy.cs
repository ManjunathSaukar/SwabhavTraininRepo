﻿using FixedDepositCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankFDApp.Policy
{
    internal class Quarter1Policy : IRatePolicy
    {
        public double CalculateRate()
        {
            return 0.09;
        }
    }
}
