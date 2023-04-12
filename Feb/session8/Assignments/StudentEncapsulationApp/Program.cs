using StudentEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Student student1 = new Student(1, "Manjunath", 9.7);
            PrintDetails(student1, "Details of student 1:");
        }
        private static void CaseStudy2()
        {
            Student student2 = new Student(-1, "Man", 10.5);
            PrintDetails(student2, "Details of student 2:");
        }

        private static void PrintDetails(Student student, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Roll Number of Student is : {student.RollNo}");
            Console.WriteLine($"Name of Student is : {student.Name}");
            Console.WriteLine($"Cgpa of Student is : {student.Cgpa}");
            Console.WriteLine($"Percentage of Student is : {student.GetPercentage()}%");
            Console.WriteLine();
        }
    }
}

