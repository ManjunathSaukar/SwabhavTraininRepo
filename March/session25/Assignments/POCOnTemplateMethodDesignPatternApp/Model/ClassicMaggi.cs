using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnTemplateMethodDesignPatternApp.Model
{
    internal class ClassicMaggi :Maggi
    {
        public override void CookMaggi()
        {
            Console.WriteLine("Cooking Maggi for 2 minutes with Masala packet");
        }
    }
}
