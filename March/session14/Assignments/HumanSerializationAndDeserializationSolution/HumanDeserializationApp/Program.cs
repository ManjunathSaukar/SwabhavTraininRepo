using HumanClassLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HumanDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Monocept\\session14\\Assignments\\HumanSerializationAndDeserializationSolution\\HumanSerializationApp\\bin\\Debug\\human1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Human[] humans = (Human[])bf.Deserialize(fs);
            fs.Close();

            foreach (Human human in humans)
            {
                PrintDetails(human, fs);
            }

            Console.WriteLine("Data deserialized successfully!");
        }

        private static void PrintDetails(Human human, FileStream fs)
        {
            Console.WriteLine($"Name: {human.Name}");
            Console.WriteLine($"Age: {human.Age}");
            Console.WriteLine($"Starting Height: {human.StartingHeight} feet");
            Console.WriteLine($"Starting Weight: {human.StartingWeight} kgs");
            Console.WriteLine($"Height: {human.Height} feet");
            Console.WriteLine($"Weight: {human.Weight} kgs");
            Console.WriteLine();
        }
    }
}
