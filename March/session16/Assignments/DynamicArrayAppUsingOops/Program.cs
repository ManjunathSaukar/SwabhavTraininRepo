using DynamicArrayAppUsingOops.Model;

namespace DynamicArrayAppUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonoceptDynamicArray array = new MonoceptDynamicArray();
            array.Add();

            Console.WriteLine("Entered numbers: ");
            int[] numbers = array.GetArray();

            foreach (int val in numbers)
            {
                Console.Write(val +" ");
            }
            Console.WriteLine();
        }
    }
 }