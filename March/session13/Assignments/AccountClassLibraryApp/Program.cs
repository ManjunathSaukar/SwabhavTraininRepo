using AccountClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy1()
        {
            Account accountA = new Account(1001, "Manjunath");
            PrintDetails(accountA, "Details of Account are:");
        }
        private static void CaseStudy2()
        {
            Account accountA = new Account(1001, "Manjunath");
            accountA.Deposit(1000);
            PrintDetails(accountA, "Details of Account after Deposit are:");
        }

        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Manjunath");
            accountA.Withdraw(1000);
        }


        static void PrintDetails(Account account, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"name : {account.Name}");
            Console.WriteLine($"balance : {account.Balance}");
            Console.WriteLine($"Account no: {account.Accouno}");
            Console.WriteLine();
        }
    }
}
