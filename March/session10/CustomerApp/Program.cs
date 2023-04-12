using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Manjunath", 10);
            Customer c2 = new Customer("Abhi", 20);
            Customer c3 = new Customer("Ashok", 30);

            Console.WriteLine(c1.Id);
            Console.WriteLine(c2.Id);
            Console.WriteLine(c3.Id);
            Console.WriteLine();

            Customer c4 = new Customer("Anu", 40);

            Console.WriteLine(c1.Id);
            Console.WriteLine(c2.Id);
            Console.WriteLine(c3.Id);
            Console.WriteLine(c4.Id);
        }
    }
}
