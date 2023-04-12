using GenericDynamicArrayApp.Model;

namespace GenericDynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonoceptDynamicArray<int> intArray = new MonoceptDynamicArray<int>();

            int i = 1;
            while (true)
            {
                Console.Write("Enter number " + i + ": ");
                string input = Console.ReadLine();
                int number;
                bool parsed = int.TryParse(input, out number);

                if (!parsed)
                {
                    Console.WriteLine("Invalid input. Printing entered numbers and exiting program.");
                    int[] numbers = intArray.GetArray();

                    Console.Write("Entered numbers: ");
                    foreach (int val in numbers)
                    {
                        Console.Write(val + " ");
                    }
                    Console.WriteLine();
                    return;
                }

                intArray.Add(number);
                i++;

            }
            Console.WriteLine("Entered numbers: ");
            int[] finalNumbers = intArray.GetArray();

            foreach (int val in finalNumbers)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}