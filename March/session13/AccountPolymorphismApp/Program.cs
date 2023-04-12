using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();//Print Details of Account Holders
            //CaseStudy2();//Deposit amount case study
            //CaseStudy3();//Withdraw amount from savings account
            CaseStudy4();//Withdraw amount from Current Account within over draft limit
            //CaseStudy5();//Withdraw amount from Current Account above over draft limit
        }

        private static void CaseStudy4()
        {
            CurrentAccount acc2 = new CurrentAccount(1002, "Abhi", 2000);
            acc2.Withdraw(4000);
            PrintDetails(acc2, "Acc2 after withdrawl");
        }

        private static void CaseStudy5()
        {
            CurrentAccount acc2 = new CurrentAccount(1002, "Abhi", 2000);
            acc2.Withdraw(10000);
        }

        private static void CaseStudy2()
        {
            SavingsAccount acc1 = new SavingsAccount(1001, "Manjunath", 1000);
            acc1.Deposit(2000);
            PrintDetails(acc1, "Acc1 Savings Account After deposit");

            CurrentAccount acc2 = new CurrentAccount(1002, "Abhi", 2000);
            acc2.Deposit(3000);
            PrintDetails(acc2, "Acc2 Current Account After deposit");
        }

        private static void CaseStudy3()
        {
            SavingsAccount acc1 = new SavingsAccount(1001, "Manjunath", 1000);
            acc1.Withdraw(2000);
        }

        private static void CaseStudy1()
        {
            SavingsAccount acc1 = new SavingsAccount(1001, "Manjunath", 1000);
            PrintDetails(acc1, "Acc1 savings Account");
            CurrentAccount acc2 = new CurrentAccount(1002, "Abhi", 2000);
            PrintDetails(acc2, "Acc2 Current Account");
        }

        static void PrintDetails(Account account, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Account is : {account.Accouno}");
            Console.WriteLine($"Name is : {account.Name}");
            Console.WriteLine($"Balance is : {account.Balance}");
            Console.WriteLine();
        }
    }
}
