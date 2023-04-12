using StudentLinkApp.Model;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student manjunath = new Student { Name = "Manjunath" };
            Student ekta = new Student { Name = "Ekta" };
            Student ravi = new Student { Name = "Ravi" };
            Student shub = new Student { Name = "Shub" };

            manjunath.Buddy = ekta;
            ekta.Buddy = ravi;
            ravi.Buddy = shub;

            PrintDetails(manjunath);
            PrintDetailsRecursive(manjunath);

        }

        private static void PrintDetailsRecursive(Student root)
        {
            if (root == null) return;
            Console.WriteLine(root.Name);
            PrintDetailsRecursive(root.Buddy);
        }

        private static void PrintDetails(Student root)
        {
            while(root!= null)
            {
                Console.WriteLine(root.Name);
                root = root.Buddy;
            }
            Console.WriteLine();
        }
    }
}