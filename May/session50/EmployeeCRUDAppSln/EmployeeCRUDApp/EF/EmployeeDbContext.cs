using EmployeeCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.EF
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}