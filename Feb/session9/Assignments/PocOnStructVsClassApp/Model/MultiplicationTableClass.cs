
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStructVsClassApp.Model
{
    internal class MultiplicationTableClass
    {
        public int Number;

        public void DisplayMultiplicationTableUsingClass()
        {
            Console.WriteLine($"Multiplication table of {Number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Number} x {i} = {Number * i}");
            }
        }
    }
}
