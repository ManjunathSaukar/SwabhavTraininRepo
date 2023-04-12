using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(10);
            PrintDetails(20.89);
            PrintDetails(10.89f);
            PrintDetails("Manjunath");
            PrintDetails('c');
            PrintDetails(6 > 5);
        }
        private static void PrintDetails(int input)
        {
            Console.WriteLine("Printing the integer input {0} ",input);
        }
        private static void PrintDetails(double input)
        {
            Console.WriteLine("Printing the double value, value is {0} ", input);
        }
        private static void PrintDetails(float input)
        {
            Console.WriteLine("Printing the float value, value is {0} ", input);
        }
        private static void PrintDetails(string input)
        {
            Console.WriteLine("Printing the string value, value is {0} ", input);
        }
        private static void PrintDetails(char input)
        {
            Console.WriteLine("Printing the character value, value is {0} - ASCII {1}", input,(int)input);
        }
        private static void PrintDetails(bool input)
        {
            Console.WriteLine("Printing the boolean value, value is {0} ", input);
        }
    }
}
