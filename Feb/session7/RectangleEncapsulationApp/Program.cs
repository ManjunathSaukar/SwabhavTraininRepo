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
            Rectangle rectangleA = new Rectangle();
            rectangleA.SetWidth(101);
            rectangleA.SetHeight(-100);
            rectangleA.SetColor("aaaa");
            PrintDetails(rectangleA, "Details of Rectangle A");

            Rectangle rectangleB = new Rectangle();
            rectangleB.SetWidth(100);
            rectangleB.SetHeight(50);
            rectangleB.SetColor("Blue");
            PrintDetails(rectangleB, "Details of Rectangle B");
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
