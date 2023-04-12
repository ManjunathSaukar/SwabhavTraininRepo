using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationApp.Model
{
    internal class Student
    {
        private int _rollNo;
        private string _name;
        private double _cgpa;

        public Student(int rollNo, string name, double cgpa)
        {
            _rollNo = ValidateRollNo(rollNo);
            _name = ValidateName(name);
            _cgpa = ValidateCgpa(cgpa);
        }

        private double ValidateCgpa(double cgpa)
        {
            if (cgpa >= 1 && cgpa <= 10)
            {
                return cgpa;
            }
            else
            {
                return 0;
            }
        }

        private string ValidateName(string name)
        {
            if (name.Length >= 5)
            {
                return name;
            }
            else
            {
                return "";
            }
        }

        private int ValidateRollNo(int roll)
        {
            if (roll >= 0)
            {
                return roll;
            }
            else
            {
                return 0;
            }
        }

        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = ValidateRollNo(value); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = ValidateName(value); }
        }

        public double Cgpa
        {
            get { return _cgpa; }
            set { _cgpa = ValidateCgpa(value); }
        }

        public double GetPercentage()
        {
            return _cgpa * 10;
        }
    }
}
