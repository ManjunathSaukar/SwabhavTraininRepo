using EmployeeCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.ViewModels
{
    public class EmployeeIndexVM
    {
        public int Count { get; set; }
        public string  Title { get; set; }
        public List<Employee> Employees { get; set; }
    }
}