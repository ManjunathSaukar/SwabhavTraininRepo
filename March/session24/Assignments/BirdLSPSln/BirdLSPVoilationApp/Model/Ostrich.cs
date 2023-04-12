using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPVoilationApp.Model
{
    internal class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("But Ostrich cannot Fly");
        }
    }
}
