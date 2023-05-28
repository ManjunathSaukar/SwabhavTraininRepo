using EmployeeCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.EF.Repository
{
    public class EmployeeRepository
    {
        private EmployeeDbContext dbContext;
        public EmployeeRepository()
        {
            dbContext = new EmployeeDbContext();
        }
        public void Add(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
        }
        public List<Employee> Get()
        {
            return dbContext.Employees.ToList();
        }
        public Employee GetById(int id)
        {
            return dbContext.Employees.SingleOrDefault(e => e.Id == id);
        }
        public int HeadCount()
        {
            return dbContext.Employees.Count();
        }
        public void Remove(int id)
        {
            dbContext.Employees.Remove(GetById(id));
            dbContext.SaveChanges();
        }
        public void Update(int id, Employee newEmp)
        {
            var emp = GetById(id);
            emp.Name = newEmp.Name;
            emp.Salary = newEmp.Salary;
            dbContext.SaveChanges();
        }
    }
}