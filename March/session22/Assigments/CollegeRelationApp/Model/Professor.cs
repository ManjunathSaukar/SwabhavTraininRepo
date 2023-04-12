using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Professor
    {
        public Professor(string name, int age, string designation, Department department)
        {
            Name = name;
            Age = age;
            Designation = designation;
            Department = department;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public Department Department { get; set; }

        
    }
}
