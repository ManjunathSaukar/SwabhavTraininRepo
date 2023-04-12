using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PocOnClassLibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            CaseStudy1(myClass,"Display Hello World Function");
            CaseStudy2(myClass,"Display sum function");
            CaseStudy3(myClass,"Dsiplay Multiplication table");
        }

        private static void CaseStudy3(MyClass myClass, string description)
        {
            Console.WriteLine(description.ToUpper());
            myClass.MultiplicationTable(5);
            Console.WriteLine();
        }

        private static void CaseStudy2(MyClass myClass, string description)
        {
            Console.WriteLine(description.ToUpper());
            int result = myClass.Sum(5, 4);
            Console.WriteLine($"Sum of {5} and {4} is {result}");
            Console.WriteLine();
        }

        private static void CaseStudy1(MyClass myClass, string description)
        {
            Console.WriteLine(description.ToUpper());
            string message = myClass.DisplayHelloWorld();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
