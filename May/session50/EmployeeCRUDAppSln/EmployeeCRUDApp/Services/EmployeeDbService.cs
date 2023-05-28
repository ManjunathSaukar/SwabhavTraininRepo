using EmployeeCRUDApp.EF.Repository;
using EmployeeCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeDbService : IEmployeeService
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeDbService()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
        }

        public List<Employee> Get()
        {
           return _employeeRepository.Get();
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public int HeadCount()
        {
            return _employeeRepository.HeadCount();
        }

        public void Remove(int id)
        {
            _employeeRepository.Remove(id);
        }

        public void Update(int id, Employee newEmp)
        {
            _employeeRepository.Update(id, newEmp);
        }
    }
}