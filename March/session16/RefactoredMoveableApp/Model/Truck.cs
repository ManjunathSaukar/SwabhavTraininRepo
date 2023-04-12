using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMoveableApp.Model
{
    internal class Truck : Vehicle
    {
        public Truck(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Truck : {Name}");
        }
    }
}
