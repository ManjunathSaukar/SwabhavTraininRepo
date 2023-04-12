using PocOnCustomAttributeApp.Model;
using System.Reflection;

namespace PocOnCustomAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);
            CustomAttribute myCustomAttribute = (CustomAttribute)myClassType.GetCustomAttribute(typeof(CustomAttribute));
            Console.WriteLine(myCustomAttribute.CustomValue);
        }
    }
}