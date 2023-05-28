using EmployeeCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees=new List<Employee>();
        private static EmployeeService _bucket;
        private EmployeeService()
        {
            _employees.Add(new Employee { Id=1,Name="Manjunath",Salary=5000 });
            _employees.Add(new Employee { Id = 2, Name = "Vikrant", Salary=4000 });

        }
        public static EmployeeService GetInstance()
        {
            if(_bucket == null)
            {
                _bucket= new EmployeeService();
            }
            return _bucket;
        }
        public int HeadCount()
        {
            return _employees.Count();
        }
        public List<Employee> Get()
        {
            return _employees;
        }
        public Employee GetById(int id)
        {
            return _employees.First(e => e.Id == id);
        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Update(int id,Employee newEmp)
        {
            var emp = GetById(id);
            if(emp != null)
            {
                emp.Salary = newEmp.Salary;
                emp.Name = newEmp.Name;
            }
        }
    }
}