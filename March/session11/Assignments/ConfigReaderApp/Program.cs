using System;
using System.Configuration;

namespace ConfigReaderApp
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
            string connection1 = ConfigurationManager.AppSettings["connection1"];
            PrintDetails(connection1,"Details of Connection1 :");
        }
        private static void CaseStudy2()
        {
            string connection2 = ConfigurationManager.AppSettings["connection2"];
            PrintDetails(connection2, "Details of Connection2 :");
        }

        private static void PrintDetails(string connection, string desceription)
        {
            Console.WriteLine(desceription.ToUpper());
            Console.WriteLine($"Key : {ConfigurationManager.AppSettings.GetKey(0)}");
            Console.WriteLine($"Value : {connection}");
            Console.WriteLine();
        }

    }
}
