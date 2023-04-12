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
            CaseStudy3();
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
