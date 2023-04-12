using FixedDepositCoreLib.Model;
using HDFCBankFDApp.Policy;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Manjunath", 100000, 10, (Quarter1Policy.CalculateRate));
            Console.WriteLine(fd1.SimpleInterest);
            FixedDeposit fd2 = new FixedDeposit(1001, "Manjunath", 200000, 10, (Quarter2Policy.CalculateRate));
            Console.WriteLine(fd2.SimpleInterest);
        }
    }
}