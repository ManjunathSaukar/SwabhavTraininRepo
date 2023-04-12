using System;
using System.Linq;


namespace BasicStatsApp
{
    internal class Program
    {
        static void Main(string[] argsOfNumbers)
        {
            int[] arrayOfNumbers = new int[argsOfNumbers.Length];
            for (int i = 0; i < argsOfNumbers.Length; i++)
            {
                if (int.TryParse(argsOfNumbers[i], out int result))
                {
                    arrayOfNumbers[i] = result;
                }
                else
                {
                    Console.WriteLine($"Invalid input: {argsOfNumbers[i]}");
                    return;
                }
            }

            int count = arrayOfNumbers.Length;
            int sum = 0;
            int max = arrayOfNumbers[0];

            //sum = arrayOfNumbers.Sum(); //using Linq 

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                sum += arrayOfNumbers[i];
            }

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > max)
                {
                    max = arrayOfNumbers[i];
                }
            }
            //max = arrayOfNumbers.Max(); //using Linq

            double average = (double)sum / count;

            Console.WriteLine($"Number of elements: {count}");
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {average}");
            Console.WriteLine($"Maximum element: {max}");
        }
    }
}

