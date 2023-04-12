using PersonInhertanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInhertanceApp
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
            Professor professor = new Professor(1002, "Rama Rao", "4-4-89/9, Patel Colony, Jublee Hills, Hyderabad", 
                new DateTime(1980, 1, 1), "PhD", 50000);
            PrintDetails(professor);
            Console.WriteLine($"Education Level: {professor.EducationLevel}");
            Console.WriteLine($"Basic Salary: {professor.BasicSalary}");
            Console.WriteLine($"Calculated Salary: {professor.CalculateAnnualSalary()}");
            Console.WriteLine();
        }

        private static void CaseStudy1()
        {
            Student student = new Student(101, "Manjunath", "3-3-67/6, St.NO : 5, New Ghokale Nagar, Ramanthapur, Hyderabad",
                            new DateTime(2001, 4, 8), BranchOptions.ECE);
            PrintDetails(student);
            Console.WriteLine($"Branch: {student.BranchOptions}");
            Console.WriteLine();
        }
        private static void PrintDetails(Person person)
        {
            Console.WriteLine($"Profession : {person.Profession}");
            Console.WriteLine($"Name : {person.Name}");
            Console.WriteLine($"Id : {person.Id}");
            Console.WriteLine($"Address : {person.Address}");
            Console.WriteLine($"Date of Birth : {person.DateOfBirth.ToShortDateString()}");
            
        }
    }
}
