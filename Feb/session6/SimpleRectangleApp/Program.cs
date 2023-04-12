using SimpleRectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA;
            rectangleA = new Rectangle();
            //Console.WriteLine($"Width is {rectangleA.width}, Height is {rectangleA.height}, color is {rectangleA.color}, area is {rectangleA.CalculateArea()}");
            PrintDetails(rectangleA, "details of Rectangle A before initialzing values");

            rectangleA.width = 20;
            rectangleA.height = 10;
            rectangleA.color = "blue";
            //Console.WriteLine($"Rectangle A details are :Width is {rectangleA.width}, Height is {rectangleA.height}, color is {rectangleA.color}, area is {rectangleA.CalculateArea()}");
            PrintDetails(rectangleA, "details of Rectangle A after initialzing values");

            Rectangle rectangleB;
            rectangleB = rectangleA;
            rectangleB.color = "yellow";
            //Console.WriteLine($"Rectangle B details are :Width is {rectangleB.width}, Height is {rectangleB.height}, color is {rectangleB.color}, area is {rectangleB.CalculateArea()}");
            PrintDetails(rectangleB, "details of Rectangle A after initialzing values");

            Console.WriteLine($"Color of rectangle A is: {rectangleB.color}, HashCode of Rectangle A is {rectangleA.GetHashCode()}");
            Console.WriteLine($"Color of rectangle A is: {rectangleA.color}, HashCode of Rectangle B is {rectangleB.GetHashCode()}");


        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Width is {rectangle.width}, Height is {rectangle.height}, color is {rectangle.color}, area is {rectangle.CalculateArea()}");

        }
    }
}
