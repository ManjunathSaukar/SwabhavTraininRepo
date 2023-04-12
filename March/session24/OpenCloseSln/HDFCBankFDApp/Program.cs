using FixedDepositCoreLib.Model;
using HDFCBankFDApp.Policy;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Manjunath", 100000, 10, new Quarter1Policy());
            Console.WriteLine(fd1.SimpleInterest);
            FixedDeposit fd2 = new FixedDeposit(1002, "Srinivas", 200000, 10, new Quarter2Policy());
            Console.WriteLine(fd2.SimpleInterest);
        }
    }
}