using EmployeePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
            PrintDetails(qa);
            PrintSalarySlipAsHTMLFile(qa);
            PrintSalarySlipAsHTMLFileAsOrderedList(qa);
        }

        private static void CaseStudy2()
        {
            Developer dev = new Developer(1002, "Abhishek Boyanpalli", 50000);
            PrintDetails(dev);
            PrintSalarySlipAsHTMLFile(dev);
            PrintSalarySlipAsHTMLFileAsOrderedList(dev);
        }

        private static void CaseStudy1()
        {
            Manager mgr = new Manager(1001, "Manjunath Saukar", 80000);
            PrintDetails(mgr);
            PrintSalarySlipAsHTMLFile(mgr);
            PrintSalarySlipAsHTMLFileAsOrderedList(mgr);
        }

        private static void PrintDetails(Employee employee)
        {
            Console.WriteLine($"Role: {employee.Role}");
            Console.WriteLine($"Name : {employee.Name}");
            Console.WriteLine($"Id : {employee.Id}");
            Console.WriteLine($"Annual salary : {employee.CostToCompany}");
            Console.WriteLine($"Basic Salary : {employee.BasicSalary}");
            Console.WriteLine($"Salary Breakup is : {employee.SalaryBreakUp}");
            Console.WriteLine();
        }

        private static void PrintSalarySlipAsHTMLFile(Employee employee)
        {
            StreamWriter sw = new StreamWriter(employee.Name + ".html");
            sw.WriteLine("<body>");
            sw.WriteLine("<H1>");
            sw.WriteLine($"Role: {employee.Role}");
            sw.WriteLine($"Name : {employee.Name}");
            sw.WriteLine($"Id : {employee.Id}");
            sw.WriteLine($"Annual salary : {employee.CostToCompany}");
            sw.WriteLine($"Basic Salary : {employee.BasicSalary}");
            sw.WriteLine($"Salary Breakup is : {employee.SalaryBreakUp}");
            sw.WriteLine("</H1>");
            sw.WriteLine("</body>");
            sw.Close();
            Console.WriteLine("Written to file");
        }

        private static void PrintSalarySlipAsHTMLFileAsOrderedList(Employee employee)
        {
            StreamWriter sw = new StreamWriter(employee.Name + ".html");
            sw.WriteLine("<body>");
            sw.WriteLine("<H1>");
            sw.WriteLine("<ol>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Role: {employee.Role}");
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Name : {employee.Name}");
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Id : {employee.Id}");
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Annual salary : {employee.CostToCompany}");
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Basic Salary : {employee.BasicSalary}");
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine($"Salary Breakup is : {employee.SalaryBreakUp}");
            sw.WriteLine("</li>");
            sw.WriteLine("</ol>");
            sw.WriteLine("</H1>");
            sw.WriteLine("</body>");
            sw.Close();

            Console.WriteLine("Written to file");
        }

    }
}
