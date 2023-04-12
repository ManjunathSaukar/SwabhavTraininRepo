using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Boy : Man
    {
        public void Eat()
        {
            Console.WriteLine("Boy eats burger");
        }
        public override void Play()
        {
            Console.WriteLine("Boy plays cricket");
        }
    }
}
