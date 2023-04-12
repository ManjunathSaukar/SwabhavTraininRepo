using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryPrincipleExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //without using the DRY principle
            Console.WriteLine("Please enter a number 1: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Please enter number 2: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            int difference = number1 - number2;
            Console.WriteLine("The difference of the {0} and {1} is: {2} ",input1,input2, difference);

            Console.WriteLine("Please enter a number 3: ");
            string input3 = Console.ReadLine();
            int number3 = int.Parse(input3);

            Console.WriteLine("Please enter number 4: ");
            string input4 = Console.ReadLine();
            int number4 = int.Parse(input4);

            double division = number3 / number4;
            Console.WriteLine("The division of the {0} and {1} is: {2} ", input3, input4, division);
            */

            //Using DRY Principle
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            int number1 = GetNumberFromUser("Please enter number 1: ");
            int number2 = GetNumberFromUser("Please enter number 2: ");
            double division = number1 / number2;
            Console.WriteLine("The division of the {0} and {1} is: {2} ", number1, number2, division);
        }

        private static void CaseStudy1()
        {
            int number1 = GetNumberFromUser("Please enter number 1: ");
            int number2 = GetNumberFromUser("Please enter number 2: ");
            int difference = number1 - number2;
            Console.WriteLine("The difference of the {0} and {1} is: {2} ", number1, number2, difference);
        }

        static int GetNumberFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}

