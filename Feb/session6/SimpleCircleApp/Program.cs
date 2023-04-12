using SimpleCircleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle();
            circleA.SetRadius(101);
            circleA.SetColor("aaaa");
            circleA.SetBorder("sdfas");
            PrintDetails(circleA, "Details of Circle A");

            Circle circleB = new Circle();
            circleB.SetRadius(5);
            circleB.SetColor("Blue");
            circleB.SetBorder("dotted border");
            PrintDetails(circleB, "Details of Circle B");
        }


        static void PrintDetails(Circle circle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Radius is {circle.GetRadius()}");
            Console.WriteLine($"Color is {circle.GetColor()}");
            Console.WriteLine($"Border is {circle.GetBorder()}");
            Console.WriteLine();
        }
    }
}

