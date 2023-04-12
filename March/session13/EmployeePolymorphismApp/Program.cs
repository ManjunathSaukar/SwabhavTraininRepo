using EmployeePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            QualityAnalyst qa = new QualityAnalyst(1003, "Sisiender Reddy", 40000);
            PrintDetails(qa, "Details of Quality Analyst are : ");
        }

        private static void CaseStudy2()
        {
            Developer dev = new Developer(1002, "Abhishek Boyanpalli", 50000);
            PrintDetails(dev, "Details of Developer are : ");
        }

        private static void CaseStudy1()
        {
            Manager mgr = new Manager(1001, "Manjunath Saukar", 80000);
            PrintDetails(mgr, "Details of Manager are : ");
        }

        private static void PrintDetails(Employee employee,string descriprtion)
        {
            Console.WriteLine(descriprtion.ToUpper());
            Console.WriteLine($"Name : {employee.Name}");
            Console.WriteLine($"Id : {employee.Id}");
            Console.WriteLine($"Annual salary : {employee.CalculateAnnualSalary()}");
            Console.WriteLine();
        }
    }
}
