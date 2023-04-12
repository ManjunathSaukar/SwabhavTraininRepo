using PocOnReflectionApp.Model;
using System.Reflection;

namespace PocOnReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            Console.WriteLine($"Type Name: {personType.Name}");


            PropertyInfo[] properties = personType.GetProperties();

            Console.WriteLine("\nProperties:");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            MethodInfo[] methods = personType.GetMethods();


            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            ConstructorInfo constructor = personType.GetConstructor(new Type[] { typeof(string), typeof(int) });


            Person person = (Person)constructor.Invoke(new object[] { "Manjunath", 21 });

            PropertyInfo nameProperty = personType.GetProperty("Name");
            string name = (string)nameProperty.GetValue(person);


            Console.WriteLine($"\nName: {name}");
        }
    }
}