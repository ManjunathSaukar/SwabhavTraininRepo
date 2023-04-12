using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnBoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object obj = i;  // Boxing

            // Unbox the object back to an integer
            int j = (int)obj;  // Unboxing

            Console.WriteLine($"i = {i}");
            Console.WriteLine($"obj = {obj}");
            Console.WriteLine($"j = {j}");
        }
    }
}
