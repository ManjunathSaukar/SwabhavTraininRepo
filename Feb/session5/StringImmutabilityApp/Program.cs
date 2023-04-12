using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutabilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            StringBuilder userName = new StringBuilder();
            userName.Append("Manjunath");
            userName.Append(" Developer");

            Console.WriteLine(userName);
            Console.WriteLine(userName.GetHashCode());

            userName.Append(" @Monocept");
            userName.Append(" Hyderabad");
            Console.WriteLine(userName);
            Console.WriteLine(userName.GetHashCode());
        }

        private static void CaseStudy2()
        {
            String userName = "Manjunath";
            Console.WriteLine(userName.GetHashCode());
            userName += " Developer";
            Console.WriteLine(userName.GetHashCode());
            userName += " @monocept";
            Console.WriteLine(userName.GetHashCode());
            userName += " Hyderabad";
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }

        private static void CaseStudy1()
        {
            String userName = "Manjunath";
            userName.ToUpper();
            Console.WriteLine(userName);

        }
    }
}
