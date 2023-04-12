using CustomerHashSetApp.Model;

namespace CustomerHashSetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();

        }

        private static void CaseStudy3()
        {
            Customer c1 = new Customer(1, "Manjunath");
            Customer c2 = new Customer(1, "Manjunath");
            Customer c3 = new Customer(2, "Abhi");

            HashSet<Customer> customers = new HashSet<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());

            Console.WriteLine(customers.Count);
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name : {customer.Name} Id : {customer.Id}");
            }

        }

        private static void CaseStudy2()
        {
            HashSet<int> scores = new HashSet<int>();
            scores.Add(1001);
            scores.Add(10);
            scores.Add(5);

            scores.Add(1001);
            scores.Add(10);
            scores.Add(5);

            scores.Add(30);
            scores.Add(100001);
            Console.WriteLine(scores.Count);
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        private static void CaseStudy1()
        {
            HashSet<string> userNames = new HashSet<string>();
            userNames.Add("Manjunath");
            userNames.Add("Shub");
            userNames.Add("Srinivas");
            userNames.Add("Manjunath");
            userNames.Add("srinivas");
            Console.WriteLine(userNames.Count);

            foreach(string username in userNames)
            {
                Console.WriteLine(username);
            }
        }
    }
}