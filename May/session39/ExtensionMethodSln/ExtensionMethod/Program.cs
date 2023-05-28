using ExtensionMethod.Extensions;
using ExtensionMethod.Model;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ".Foo());
            Console.WriteLine("Manjunath ".Foo());

            Console.WriteLine("abc".IsPalindrome());
            Console.WriteLine("madam".IsPalindrome());

            var acc1 = new Account(101, "Manjunath", 1000);
            acc1.PrintDetails();

        }
    }
}