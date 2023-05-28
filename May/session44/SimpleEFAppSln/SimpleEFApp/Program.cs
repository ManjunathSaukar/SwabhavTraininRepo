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
            //CaseStudy1(); //write oprn
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            //CaseStudy5();
            //CaseStudy6();
            CaseStudy7();
            Console.ReadLine();
        }
        private static async void CaseStudy7()
        {
            var db = new CustomerDbContext();
            var customer = db.Customers.ToList()
                             .Select(c => new { FirstName = c.Name.Split()[0] });
            customer.ToList().ForEach(c => Console.WriteLine(c.FirstName));
            
        }

        private static async void CaseStudy6()
        {
            //not all sql expressions are converted to sql queries
            var db = new CustomerDbContext();
            var customer = db.Customers.Select(c=> new { FirstName = c.Name.Split()[0] });
            await customer.ForEachAsync(c => Console.WriteLine(c.FirstName));
        }

        private static void CaseStudy5()
        {
            var db = new CustomerDbContext();
            var customer= db.Customers.Where(c => c.Name.Equals("Manjunath"))
                                    .First();
            customer.Address = customer.Address + " Telanagana";
            customer.Name= customer.Name.ToUpper();
            db.SaveChanges();
        }

        private static async void CaseStudy4()
        {
            var db = new CustomerDbContext();
            await db.Customers.
                ForEachAsync(c=>Console.WriteLine(c.Name));
        }

        private static void CaseStudy2()
        {
            //bif performance problem
            var db = new CustomerDbContext();
            var customers = db.Customers.ToList();
            var customer = customers.Where(c => c.Name.Equals("Manjunath")).First();
            Console.WriteLine(customer);
        }

        private static void CaseStudy3()
        {
            var db = new CustomerDbContext();
            var customers = db.Customers.Where(c => c.Name.Equals("Manjunath")).ToList();
            customers.ForEach(c => Console.WriteLine(c.Name));
        }

        private static void CaseStudy1()
        {
            var c1 = new Customer { Name = "Manjunath", Id = 1, Address = "Hyderabad" };
            var c2 = new Customer { Name = "Ravi", Id = 2, Address = "Hyderabad" };

            var db = new CustomerDbContext();
            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.SaveChanges();

        }
    }
}
