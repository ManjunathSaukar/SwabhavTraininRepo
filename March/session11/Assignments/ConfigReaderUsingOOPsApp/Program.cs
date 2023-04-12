using ConfigReaderUsingOOPsApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigReaderUsingOOPsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionConfig = new ConnectionConfig();

            PrintDetails(connectionConfig.Connection1, "Details of Connection1 :");
            PrintDetails(connectionConfig.Connection2, "Details of Connection2 :");
        }

        private static void PrintDetails(string connection, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Key : {ConfigurationManager.AppSettings.GetKey(0)}");
            Console.WriteLine($"Value : {connection}");
            Console.WriteLine();
        }
    }
}
