using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4(); //in out parameters and TryParse method
            CaseStudy5(); //params array
        }

        private static void CaseStudy5()
        {
            DisplayMultiplication(first: 10);
            DisplayMultiplication(first: 10,20);
            DisplayMultiplication(first: 10,20,30,40,50);
        }

        private static void DisplayMultiplication(int first, params int[] numbers)
        {
            int product = first;
            foreach(int number in numbers)
            {
                product *= number;
            }
            Console.WriteLine($"Product is {product}");
        }

        private static void CaseStudy4()
        {
            int sum, avg, product;
            Calculate(10,20,30,out sum, out avg, out product);
            Console.WriteLine($"Sum is {sum}, Average is {avg}, Product is {product}");
            Console.WriteLine("Enter a number only");
            string input = Console.ReadLine();
            int no = 0;
            if(int.TryParse(input,out no))
            {
                Console.WriteLine(no * no);
            }
            else { Console.WriteLine("Only numbers are allowed : " + input); }
        }

        private static void Calculate(int first, int second, int third, out int sum, out int avg, out int product)
        {
            sum = first+ second + third;
            avg = sum/3;
            product = first*second*third;
        }

        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine("CaseStudy 1, mark value is {0}",mark);
        }
        private static void UpdateMarkToZero(int mark)
        {
           mark = 0;
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy 2, salary value is {0}", salary);
        }
        private static void UpdateSalaryToZero(ref int psalary)
        {
            psalary = 0;
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40, 50 };
            UpdateScoresToZero(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("Hashcode is scores {0}", scores.GetHashCode());
        }

        private static void UpdateScoresToZero(int[] pscores)
        {
            for(int i = 0; i < pscores.Length; i++)
            {
                pscores[i]=0;
            }
            Console.WriteLine("Hashcode is pscores {0}", pscores.GetHashCode());
        }
    }
}
