using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Monocept\\session14\\SerializationDeserializationSolution\\CustomerSerializationApp\\bin\\Debug\\" +
                "customer1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            Customer c = obj as Customer;
            Console.WriteLine($"Name : {c.Name}");
            Console.WriteLine($"Id : {c.Id}");
            Console.WriteLine($"Phone No : {c.Phone}");
            Console.WriteLine($"Email Id : {c.Email}");
            Console.WriteLine($"City : {c.City}");
            Console.WriteLine($"State : {c.State}");
            fs.Close();
        }
    }
}
