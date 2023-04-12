using RectangleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

        }

        private static void CaseStudy1()
        {
            Rectangle rectangleA = new Rectangle(10, 20, ColorOption.GREEN);
            PrintDetails(rectangleA);
            rectangleA.Color= ColorOption.BLUE;
            PrintDetails(rectangleA);
        }
        private static void CaseStudy2()
        {
            Rectangle rectangleB = new Rectangle(10, 20, ColorOption.GREEN, BorderOptions.Dotted);
            PrintDetails(rectangleB);
        }

        private static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine($"Width is : {rectangle.Width}");
            Console.WriteLine($"Height is : {rectangle.Height}");
            Console.WriteLine($"Color is : {rectangle.Color}");
            Console.WriteLine($"Border id :{rectangle.Border}");
            Console.WriteLine();
        }
    }
}
