using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankSubscriber.Notifiers
{
    internal class WhatsAppNotifiers : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sending WhatsApp Notification");
            Console.WriteLine($"Account Holder Name : {account.Name}");
            Console.WriteLine($"Account Holder Balance : {account.Balance}\n");
        }
    }
}
