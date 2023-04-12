using AccountApp.Model;
using ExceptionPolymorphismApp.Model;

namespace RefactoredExceptionPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Manjunath", 500);
            try
            {
                acc1.Withdraw(100);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of Main"); ;
        }
    }
}