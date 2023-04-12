using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VishakDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs= new FileStream("C:\\Monocept\\session14\\vishak\\customer1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            Customer c = obj as Customer;
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Id);
            fs.Close();
        }
    }
}
