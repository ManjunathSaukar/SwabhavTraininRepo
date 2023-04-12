using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class CustomerRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Record inserted");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Record deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer Record read");

        }

        public void Update()
        {
            Console.WriteLine("Customer Record updated");
        }
    }
}
