using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp2.Model
{
    internal class Account1
    {
        public string name;
        public double balance;

        public Account1(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public static Account1 FindTheRichestAccountHolder(Account1[] accounts)
        {
            Account1 richest = accounts[0];

            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i].balance > richest.balance)
                {
                    richest = accounts[i];
                }
            }
            return richest;
        }

        public static string[] FindAccountHolderWithLongNames(Account1[] accounts)
        {
            string[] longNamedAccountHolders = new string[accounts.Length];
            int count = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].name.Length >= 8)
                {
                    longNamedAccountHolders[count] = accounts[i].name;
                    count++;
                }
            }

            Array.Resize(ref longNamedAccountHolders, count);

            return longNamedAccountHolders;
        }
    }
}
