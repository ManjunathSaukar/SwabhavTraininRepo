using LinqToObjectsApp.Model;

namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account> 
            { 
                new Account{AccountNo=1, Name="Manjunath", Balance=10000, Location="Hyderabad"},
                new Account{AccountNo=2, Name="Vikrant", Balance=5000, Location="Lucknow"},
                new Account{AccountNo=3, Name="Ravi", Balance=8000, Location="Mumbai"},
                new Account{AccountNo=4, Name="Abhi", Balance=7000, Location="Delhi"},
                new Account{AccountNo=5, Name="Srinivas", Balance=6000, Location="Kolkatta"}
            };

            //CaseStudy1(accounts);

            //CaseStudy2(accounts);

            CaseStudy3(accounts);

        }

        private static void CaseStudy3(List<Account> accounts)
        {
            var richestAccountsQuery = accounts
            .OrderByDescending(account => account.Balance)
            .Take(3)
            .Select(account => new
            {
                FullName = account.Name,
                Balance = account.Balance,
            });
            Console.WriteLine("The richest account holders:");
            richestAccountsQuery.ToList().ForEach(a =>
            {
                Console.WriteLine($"Name: {a.FullName}, Balance: {a.Balance}");
            });
        }

        private static void CaseStudy2(List<Account> accounts)
        {
            var allNameAndBalanceQuery = accounts
                .OrderBy(account =>account.Name)
                .Where(account=> account.Balance >=7000)
                .Select(account => new
                {
                    FullName = account.Name,
                    Balance = account.Balance,
                });
            allNameAndBalanceQuery.ToList().ForEach(a =>
            {
                Console.WriteLine(a.FullName);
                Console.WriteLine(a.Balance);
            });
        }

        private static void CaseStudy1(List<Account> accounts)
        {
            //Query Syntax
            var allNameAndBalanceQuery = from acc in accounts
                                         where acc.Balance>=7000
                                         orderby acc.Name
                                         select new 
                                         { 
                                             FullName = acc.Name,
                                             Balance = acc.Balance
                                         };
            foreach (var nameBalance in allNameAndBalanceQuery)
            {
                Console.WriteLine(nameBalance.FullName);
                Console.WriteLine(nameBalance.Balance);
            }
        }
        
    }
}