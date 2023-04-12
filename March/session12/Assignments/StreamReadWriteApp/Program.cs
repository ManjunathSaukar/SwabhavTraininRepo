using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

        }
        static void CaseStudy1()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist");
                return;
            }

            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine("Contents of the file:");
            Console.WriteLine(content);
        }
        static void CaseStudy2()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();
            Console.Write("Enter the text to write: ");
            string text = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine(text);
                writer.WriteLine();
            }

            Console.WriteLine("Data written successfully!");
        }
    }
}
