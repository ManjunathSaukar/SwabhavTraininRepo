using ConstructorInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();//defaultly parent class constructor is called and then the child class's constructor
            CaseStudy2();//if there is no default constructor then hardcoded value is printed
            CaseStudy3();//if there is no default constructor then overloaed construcor is printed
        }

        private static void CaseStudy3()
        {
            ChildV2 childA= new ChildV2(30);
            Console.WriteLine(childA.Age);
        }

        private static void CaseStudy2()
        {
            ChildV2 childA = new ChildV2();
            Console.WriteLine(childA.Age);
            ChildV2 childB = new ChildV2();
            Console.WriteLine(childB.Age);
        }

        private static void CaseStudy1()
        {
            new ChildV1();
        }
    }
}
