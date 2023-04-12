using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnEventsApp.Model
{
    delegate void CustomerEventHandler(string name);
    internal class Customer
    {
        public event CustomerEventHandler OnAdded;
        public void Add(string name)
        {
            Console.WriteLine($"Customer {name} Added");
            if (OnAdded != null)
            {
                OnAdded(name);
            }
        }
    }
}
