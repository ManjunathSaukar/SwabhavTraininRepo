using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EamplesOnPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            In Parameters:

            1. Used to pass an argument to a method, indicating that the value is input-only and should not be modified.
            2. The value passed as an in parameter cannot be modified by the method it is passed to.
            3. An in parameter can be a value type or reference type.

            Out Parameters:

            1. Used to pass an argument to a method, indicating that the value is output-only and should not be used before it is assigned a value by the method.
            2. The value passed as an out parameter must be assigned a value by the method it is passed to.
            3. An out parameter must be a variable, not a constant or a read-only property.
            4. An out parameter can be a value type or reference type.
            */
            int x = 5;
            int y = 7;
            int sum, product;

            AddAndMultiply(in x, in y, out sum, out product);

            Console.WriteLine("sum = {0}, product = {1}",sum,product);

            /*
             1. int.TryParse() is a built-in C# method that attempts to convert a string representation of a number to an integer.
             2. It takes two parameters: the string to be converted, and an integer variable to hold the converted value.
             3. If the conversion is successful, int.TryParse() returns true, and the converted integer value is stored in the output variable.
             4. If the conversion is unsuccessful, int.TryParse() returns false, and the output variable is set to the default value for the integer type (0).
             */
            string userInput = Console.ReadLine();
            int number;

            if (int.TryParse(userInput, out number))
            {
                Console.WriteLine("The parsed number is: " + number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            /*
             Yes, the 'WriteLine()' method in C# uses the 'params' keyword to allow for a variable 
             number of arguments to be passed to the method. It has an overload that takes a 'params
             object[]' argument, which means you can pass any number of objects as arguments, and 
             they will be formatted into a string based on the format string provided as the first argument.
             */

            PrintNumbers(1, 2, 3, 4, 5);
            
        }

        static void AddAndMultiply(in int a, in int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        static void PrintNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            
        }
    }
}
