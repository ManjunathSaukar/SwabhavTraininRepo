using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnEventsApp.Model
{
    internal class SMS
    {
        public static void Send(string name)
        {
            Console.WriteLine($"SMS sent to {name}");
        }
    }
}
