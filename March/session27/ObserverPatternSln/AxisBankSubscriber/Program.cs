using AxisBankSubscriber.Notifiers;
using PublisherCoreLib.Model;
using System.ComponentModel.DataAnnotations;

namespace AxisBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Manjunath");
            acc1.AddSubscriber(new EmailNotifiers());
            acc1.AddSubscriber(new SmsNotifiers());
            acc1.Deposit(1000);
            acc1.Withdraw(100);
        }
    }
}