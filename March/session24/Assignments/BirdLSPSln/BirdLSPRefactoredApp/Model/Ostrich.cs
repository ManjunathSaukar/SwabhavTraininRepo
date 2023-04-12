using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPRefactoredApp.Model
{
    internal class Ostrich : IBirdsThatCannotFly
    {
        public void CannotFly()
        {
            Console.WriteLine("Ostrich cannot Fly");
        }
    }
}
