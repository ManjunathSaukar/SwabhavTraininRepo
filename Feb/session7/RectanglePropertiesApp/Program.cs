using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.Color="Red";
            PrintDetails(rectangleA, "Rectangle A after modification");
        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangle.Width}");
            Console.WriteLine($"height is {rectangle.Height}");
            Console.WriteLine($"color is {rectangle.Color}");
            Console.WriteLine();

        }
    }
}