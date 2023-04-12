using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _basicSalary;

        public Employee(int id, string name, double basicSalary) 
        { 
            _id= id;
            _name= name;
            _basicSalary= basicSalary;
        }
        public virtual double CalculateAnnualSalary()
        {
            return _basicSalary * 12;
        }
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public double BasicSalary { get { return _basicSalary;} }
    }
}
