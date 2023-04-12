using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Student
    {
        public Student(string name, int age, string rollNumber, Department department)
        {
            Name = name;
            Age = age;
            RollNumber = rollNumber;
            Department = department;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string RollNumber { get; set; }
        public Department Department { get; set; }

        
    }
}
