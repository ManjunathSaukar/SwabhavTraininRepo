using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnDelegatesApp.Model
{
    public class Calculator
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"{x}+{y} = {x+y}");
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"{x}-{y} = {x - y}");
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"{x}*{y} = {x * y}");
        }

        public static void Divide(int x, int y)
        {
            Console.WriteLine($"{x}/{y} = {x / y}");
        }
    }
}
