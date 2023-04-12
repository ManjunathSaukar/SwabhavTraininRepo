using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying anonymus object details");
            Console.WriteLine(new Rectangle().CalculateArea());
            PrintDetails(new Rectangle(),"Anonymus object 2");
            //PrintDetails(null, null);

            Rectangle rect=null;
            //rect = new Rectangle();
            rect.SetWidth(20);
            rect.SetHeight(30);
            PrintDetails(rect, "Rect Object");
        }
 

        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"Height is {rectangle.GetHeight()}");
            Console.WriteLine($"Color is {rectangle.GetColor()}");
            Console.WriteLine($"Area is {rectangle.CalculateArea()}");
            Console.WriteLine();
        }
    }
}
