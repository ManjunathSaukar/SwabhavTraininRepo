using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public double Salary { get { return _salary;} }

        public override string ToString()
        {
            string template = "";
            template += "Id : " + _id;
            template += "Name : " + _name;
            template += "Salary : " + _salary;
            template += "Parent : " + base.ToString();
            return template;
        }

        public override bool Equals(object obj)
        {
            Employee second = (Employee)obj;
            if(this._id== second._id )
                return true;
            return false;
        }
    }
}
