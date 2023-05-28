using EmployeeCRUDApp.Models;
using System.Collections.Generic;

namespace EmployeeCRUDApp.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        List<Employee> Get();
        Employee GetById(int id);
        int HeadCount();
        void Remove(int id);
        void Update(int id, Employee newEmp);
    }
}