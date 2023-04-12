using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExceptionApp.Model
{
    internal class Calculator
    {

        public int Add(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new NegativeValuesNotSupportedException(a,b);
            }
            return a + b;
        }
    }
}
