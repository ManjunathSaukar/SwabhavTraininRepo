using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayAppUsingOops.Model
{
    internal class MonoceptDynamicArray
    {
        private int[] numbers;
        private int count;

        public MonoceptDynamicArray()
        {
            numbers = new int[5];
            count = 0;
        }

        public void Add()
        {
            while (true)
            {
                Console.Write($"Enter number {count + 1}: ");
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int number))
                {
                    if (count == numbers.Length - 1)
                    {
                        Console.WriteLine($"Array full. Resizing to {numbers.Length * 2} elements.");
                        Array.Resize(ref numbers, numbers.Length * 2);
                    }

                    numbers[count] = number;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting program.");
                    return;
                }
            }
        }

        public int[] GetArray()
        {
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = numbers[i];
            }

            return result;
        }
    }
}
