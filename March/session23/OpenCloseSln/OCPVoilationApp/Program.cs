using OCPVoilationApp.Model;

namespace OCPVoilationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Manjunath", 1000000, 1, FestivalTypes.NORMAL);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}