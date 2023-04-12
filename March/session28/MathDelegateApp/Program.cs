namespace MathDelegateApp
{
    delegate void DMathOperations(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            DMathOperations obj;
            obj = Add;
            obj += Subtract;
            obj += Multiply;
            obj += Divide;
            obj(20, 5);

        }
        static void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
        static void Divide(int num1, int num2)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }
}