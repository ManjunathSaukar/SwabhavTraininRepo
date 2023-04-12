using AxisBankSubscriber.Notifiers;
using HDFCBankSubscriber.Notifiers;
using PublisherCoreLib.Model;

namespace HDFCBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Manjunath");
            acc1.AddSubscriber(new FaxNotifiers());
            acc1.AddSubscriber(new TelegramNotifiers());
            acc1.AddSubscriber(new WhatsAppNotifiers());
            acc1.Deposit(1000);
            acc1.Withdraw(100);
        }
    }
}