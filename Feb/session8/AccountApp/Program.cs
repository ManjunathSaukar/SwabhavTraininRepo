using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();

        }

        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Manjunath");
            accountA.Deposit(1000);
            PrintDetails(accountA);
        }

        private static void CaseStudy4()
        {
            Account accountA = new Account(1001, "Manjunath");
            accountA.Withdraw(1000);
        }

        private static void CaseStudy1()
        {
            Account accountA = new Account(1001, "Manjunath");
            PrintDetails(accountA);
        }

        private static void CaseStudy2()
        {
            Account accountB = new Account(1002, "Abhi", 1000);
            PrintDetails(accountB);
            
        }

        static void PrintDetails(Account account)
        {
            Console.WriteLine($"name : {account.Name}");
            Console.WriteLine($"balance : {account.Balance}");
            Console.WriteLine($"Account no: {account.Accouno}");
            Console.WriteLine();
        }
    }
}
