using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenOddArrayApp.Model;

namespace EvenOddArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddEven oddEven = new OddEven();

            CaseStudy1(oddEven);
            CaseStudy2(oddEven);
            CaseStudy3(oddEven);
            CaseStudy4(oddEven);
        }

        private static void CaseStudy1(OddEven oddEven)
        {
            int[] evenNumbers = oddEven.GetEven(100);
            Console.WriteLine("Even numbers from 1 to 100:");
            PrintArray(evenNumbers);
        }


        private static void CaseStudy2(OddEven oddEven)
        {
            int[] oddNumbers = oddEven.GetOdd(100);
            Console.WriteLine("Odd numbers from 1 to 100:");
            PrintArray(oddNumbers);
        }
        private static void CaseStudy3(OddEven oddEven)
        {
            int[] evenNumbers2 = oddEven.GetEven(100, 200);
            Console.WriteLine("Even numbers from 100 to 200:");
            PrintArray(evenNumbers2);
        }

        private static void CaseStudy4(OddEven oddEven)
        {
            int[] oddNumbers2 = oddEven.GetOdd(200, 300);
            Console.WriteLine("Odd numbers from 100 to 200:");
            PrintArray(oddNumbers2);
        }
        private static void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
