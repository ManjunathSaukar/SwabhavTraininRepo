using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 10, height: 20, color: "yellow"),"Anonymus object");

            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.SetColor("Red");
            PrintDetails(rectangleA, "Rectangle A after modification");
        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
            Console.WriteLine($"color is {rectangle.GetColor()}");
            Console.WriteLine();


        }
    }
}
