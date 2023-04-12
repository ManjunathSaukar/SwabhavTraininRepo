using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeToStringEqualsApp.Model;

namespace EmployeeToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var employeeA = new Employee(1, "Manjunath", 1000);
            var employeeB = new Employee(1, "Manjunath", 1000);
            //Referncebased Equality
            Console.WriteLine($"Refernce Equality of A and B : {employeeA == employeeB}");

            var employeeC = employeeB;
            Console.WriteLine($"Refernce Equality of B and C : {employeeB == employeeC}");

            //Value based Equality
            Console.WriteLine($"Value Equality A and B : {employeeA.Equals(employeeC)}");
            Console.WriteLine($"Value Equality B and C : {employeeB.Equals(employeeC)}");
        }

        private static void CaseStudy1()
        {
            var employeeA = new Employee(1, "Manjunath", 1000);
            Console.WriteLine(employeeA);
            Console.WriteLine(employeeA.ToString());
            Console.WriteLine(employeeA.GetType());
        }
    }
}
