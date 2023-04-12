using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfoCaseStudy();
            FileInfoCaseStudy();
        }
        static void DirectoryInfoCaseStudy()
        {
            Console.Write("Enter a directory path: ");
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                int fileCount = Directory.GetFiles(directoryPath).Length;
                Console.WriteLine("Total files in directory: " + fileCount);
            }
            else
            {
                Console.WriteLine("Invalid directory path.");
            }
        }

        static void FileInfoCaseStudy()
        {
            Console.Write("Enter a file path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine("File name: " + fileInfo.Name);
                Console.WriteLine("File size: " + fileInfo.Length + " bytes");
                Console.WriteLine("Creation time: " + fileInfo.CreationTime);
                Console.WriteLine("Last access time: " + fileInfo.LastAccessTime);
                Console.WriteLine("Last write time: " + fileInfo.LastWriteTime);
            }
            else
            {
                Console.WriteLine("Invalid file path.");
            }
        }
    }
}
