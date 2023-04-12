using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPVoilationApp.Model
{
    internal class Parrot : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Parrot is Flying");
        }
    }
}
