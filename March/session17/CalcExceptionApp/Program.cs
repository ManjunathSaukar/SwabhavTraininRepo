using CalcExceptionApp.Model;

namespace CalcExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator();

            try
            {
                Console.WriteLine(calc1.Add(10, -20));
            }
            catch (NegativeValuesNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of Main");
        }
    }
}