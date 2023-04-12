using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableVechileApp.Model
{
    internal class Truck:IMoveable
    {
        private string _name;

        public Truck(string name)
        {
            _name = name;
        }
        public void Move()
        {
            Console.WriteLine($"{_name} moves");
        }
    }
}
