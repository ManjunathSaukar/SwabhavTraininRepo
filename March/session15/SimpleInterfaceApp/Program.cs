using SimpleInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerRepository());
            DoDbOperations(new DepartmentRepository());
            DoDbOperations(new ProductRepository());    
        }
        static void DoDbOperations(ICrudable crudable)
        {
            Console.WriteLine("Doing DB Operations");
            crudable.Create();
            crudable.Read();
            crudable.Update();
            crudable.Delete();
            Console.WriteLine("DB Operations Completed");
            Console.WriteLine();
        }
    }
}
