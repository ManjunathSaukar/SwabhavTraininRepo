using SimpleCircleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle(5.5f, "red", "double border");
            PrintDetails(circleA, "circle A");
            circleA.Color = "yellow";
            PrintDetails(circleA, "circle A after color update");

        }

        static void PrintDetails(Circle circle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Radius is {circle.Radius}");
            Console.WriteLine($"Color is {circle.Color}");
            Console.WriteLine($"Border is {circle.Border}");
            Console.WriteLine();
        }
    }
}
