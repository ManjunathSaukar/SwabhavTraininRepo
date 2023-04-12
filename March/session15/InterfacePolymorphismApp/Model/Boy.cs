using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Crying");
        }

        public void Depart()
        {
            Console.WriteLine("Bye");
        }

        public void Laugh()
        {
            Console.WriteLine("Laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Hello");
        }
    }
}
