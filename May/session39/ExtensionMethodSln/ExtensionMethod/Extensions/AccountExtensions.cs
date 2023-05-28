using ExtensionMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Extensions
{
    public static class AccountExtensions
    {
        public static void PrintDetails(this Account account)
        {
            Console.WriteLine($"Account number: {account.Accouno}");
            Console.WriteLine($"Account holder name: {account.Name}");
            Console.WriteLine($"Account balance: {account.Balance}");
        }
    }
}
