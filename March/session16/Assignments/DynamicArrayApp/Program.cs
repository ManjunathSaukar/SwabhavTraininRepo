namespace DynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            int count = 0;

            while (true)
            {
                Console.Write($"Enter number {count + 1}: ");
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int number))
                {
                    if (count == myArray.Length - 1)
                    {
                        Console.WriteLine($"Array full. Resizing to {myArray.Length * 2} elements.");
                        Array.Resize(ref myArray, myArray.Length * 2);
                    }

                    myArray[count] = number;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting program.");
                    PrintArray(myArray, count);
                    return;
                }
            }
        }
        static void PrintArray(int[] array, int count)
        {
            Console.Write("Entered numbers: ");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}