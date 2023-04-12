using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnTemplateMethodDesignPatternApp.Model
{
    internal abstract class Maggi
    {
        public void MakeMaggi()
        {
            BoilWater();
            AddMaggiToBoilingWater();
            CookMaggi();
            ServeMaggi();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling 2 cups of water");
        }
        public void AddMaggiToBoilingWater()
        {
            Console.WriteLine("Adding Maggi to boiling water");
        }
        public void ServeMaggi()
        {
            Console.WriteLine("Maggi is ready to serve");
        }
        public abstract void CookMaggi();
    }
}
