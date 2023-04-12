using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMoveableApp.Model
{
    internal class Car : Vehicle
    {
        public Car(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Car : {Name} is moving");
        }
    }
}
