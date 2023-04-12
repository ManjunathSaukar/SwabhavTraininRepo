using PocOnStructVsClassApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStructVsClassApp
{
    internal class Program
    {
        //struct MultiplicationTableStruct
        //{
        //    public int Number;

        //    public void DisplayMultiplicationTableUsingStruct()
        //    {
        //        Console.WriteLine($"Multiplication table of {Number}:");
        //        for (int i = 1; i <= 10; i++)
        //        {
        //            Console.WriteLine($"{Number} x {i} = {Number * i}");
        //        }
        //    }
        //}
        struct PointStruct
        {
            public int X;
            public int Y;
        }
        class PointClass
        {
            public int X;
            public int Y;
        }
        static void Main(string[] args)
        {
            PointStruct pointStruct = new PointStruct();
            pointStruct.X = 10;
            pointStruct.Y = 20;

            PointClass pointClass = new PointClass();
            pointClass.X = 30;
            pointClass.Y = 40;

            Console.WriteLine($"Struct: X = {pointStruct.X}, Y = {pointStruct.Y}");
            Console.WriteLine($"Class: X = {pointClass.X}, Y = {pointClass.Y}");
            //CaseStudy1();
            //CaseStudy2();

        }
        //public static void CaseStudy1()
        //{
        //    Console.Write("CaseStudy 1\n");
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Using a struct:");
        //    MultiplicationTableStruct structTable = new MultiplicationTableStruct();
        //    structTable.Number = number;
        //    structTable.DisplayMultiplicationTableUsingStruct();

        //}
        //public static void CaseStudy2()
        //{
        //    Console.Write("CaseStudy 2\n");
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    Console.WriteLine("\nUsing a class:");
        //    MultiplicationTableClass classTable = new MultiplicationTableClass();
        //    classTable.Number = number;
        //    classTable.DisplayMultiplicationTableUsingClass();

        //}
    }
}
