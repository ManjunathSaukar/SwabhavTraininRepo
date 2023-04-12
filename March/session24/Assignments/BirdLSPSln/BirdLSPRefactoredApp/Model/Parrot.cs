using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPRefactoredApp.Model
{
    internal class Parrot :IBirdsThatCanFly
    {
        public void Fly()
        {
            Console.WriteLine("Parrot is Flying");
        }
    }
}
