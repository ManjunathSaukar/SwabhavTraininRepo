using SimpleEFApp.EF;
using SimpleEFApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
            Console.ReadLine();
        }

        private static void CaseStudy4()
        {
            var department = new Department
            {
                Name = "IT Department",
                Location = "New York"
            };

            var employee1 = new Employee
            {
                Name = "John Doe",
                Position = "Software Engineer",
                Department = department
            };

            var employee2 = new Employee
            {
                Name = "Jane Smith",
                Position = "Database Administrator",
                Department = department
            };

            department.Employees.Add(employee1);
            department.Employees.Add(employee2);

            var db = new CustomerDbContext();
            db.Departments.Add(department);
            db.SaveChanges();

            Console.WriteLine("End of Case Study 4");

        }

        private static void CaseStudy3()
        {
            var db = new CustomerDbContext();
            foreach(var c in db.Customers.Include(c=>c.Orders))
            {
                Console.WriteLine(c.Name);
                c.Orders.ForEach(o=>Console.WriteLine(o.Description));
            }
        }

        private static async void CaseStudy2()
        {
            var db = new CustomerDbContext();
            await db.Orders.ForEachAsync(o => Console.WriteLine(o.Description));
        }

        private static void CaseStudy1()
        {
            var c1 = new Customer();
            c1.Name = "Abhi";
            c1.Address = "Hyderabad";

            var order1 = new Order();
            order1.Date = DateTime.Now;
            order1.Description = "Books";
            order1.Customer = c1;

            var order2 = new Order();
            order2.Date = DateTime.Now;
            order2.Description = "Electronics";
            order2.Customer = c1;

            c1.Orders.Add(order1);
            c1.Orders.Add(order2);

            var db = new CustomerDbContext();
            db.Customers.Add(c1);
            db.SaveChanges();
            Console.WriteLine("End of Case Study 1");
        }
    }
}
