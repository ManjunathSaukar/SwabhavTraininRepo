using AxisBankFDApp.Policy;
using FixedDepositCoreLib.Model;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Manjunath", 100000, 10, (DiwaliRatePolicy.CalculateRate));
            Console.WriteLine(fd1.SimpleInterest);
            FixedDeposit fd2 = new FixedDeposit(1001, "Manjunath", 200000, 10, (NewYearRatePolicy.CalculateRate));
            Console.WriteLine(fd2.SimpleInterest);
        }
    }
}