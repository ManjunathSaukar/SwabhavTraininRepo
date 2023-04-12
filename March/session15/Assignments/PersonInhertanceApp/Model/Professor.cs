using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInhertanceApp.Model
{
    internal class Professor :Person
    {
        private string _educationLevel;
        private decimal _basicSalary;

        public Professor(int id, string name, string address, DateTime dob, string educationLevel, decimal basicSalary) : base(id, name, address, dob)
        {
            _educationLevel = educationLevel;
            _basicSalary = basicSalary;
        }

        public string EducationLevel
        {
            get { return _educationLevel; }
            set { _educationLevel = value; }
        }

        public decimal BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }

        public decimal CalculateAnnualSalary()
        {
            decimal salary = _basicSalary;
            decimal bonus = _basicSalary * 0.05m;

            switch (_educationLevel.ToLower())
            {
                case "phd":
                    salary += 10000m;
                    break;
                case "masters":
                    salary += 5000m;
                    break;
                case "graduate":
                    salary += 1000m;
                    break;
                default:
                    break;
            }

            salary += bonus;
            return (salary*12);
        }
        public override string Profession
        {
            get
            {
                return "Professor";
            }
        }
    }
}
