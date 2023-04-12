using HumanClassLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HumanSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[3]
            {
                new Human("Manjunath", 22, 6.0f, 100.0f),
                new Human("Abhishek", 30, 5.8f, 95.0f),
                new Human("Srinivas", 28, 5.9f, 80.0f)
            };

            // Invoking Workout method on humans with weight > 90 and Eat method on humans with weight <= 90
            foreach (Human human in humans)
            {
                if (human.Weight > 90)
                {
                    human.Workout();
                }
                else
                {
                    human.Eat();
                }
            }

            FileStream fs = new FileStream("human1.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, humans);
            fs.Close();

            Console.WriteLine("Data serialized successfully!");
        }
    }
}
