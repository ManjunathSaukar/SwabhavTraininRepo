using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApp2.Model;


namespace AccountApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();       
        }

        private static void CaseStudy2()
        {
            Account1[] manyAccount = new Account1[5];
            manyAccount[0] = new Account1("Manjunath Saukar", 1000);
            manyAccount[1] = new Account1("Mayur", 2000);
            manyAccount[2] = new Account1("Sarah Ali Khan", 3000);
            manyAccount[3] = new Account1("Elizabeth Olsen", 40000);
            manyAccount[4] = new Account1("Paul Haymen", 5000);

            string[] longNamedAccountHolders = Account1.FindAccountHolderWithLongNames(manyAccount);
            Console.WriteLine($"Account holders with long names:");
            PrintName(longNamedAccountHolders);
        }

        private static void CaseStudy1()
        {
            Account1[] manyAccount = new Account1[5];
            manyAccount[0] = new Account1("Manjunath Saukar", 1000);
            manyAccount[1] = new Account1("Mike", 2000);
            manyAccount[2] = new Account1("Sarah Ali Khan", 3000);
            manyAccount[3] = new Account1("Elizabeth Olsen", 40000);
            manyAccount[4] = new Account1("Paul Haymen", 5000);

            Account1 richestAccountHolder = Account1.FindTheRichestAccountHolder(manyAccount);
            Console.WriteLine($"Richest account holder:");
            PrintDetails(richestAccountHolder);
        }

        public static void PrintDetails(Account1 account)
        {
            Console.WriteLine($"Name: {account.name}");
            Console.WriteLine($"Balance is : {account.balance}");
            Console.WriteLine();
        }

        public static void PrintName(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
