using System.Threading.Channels;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
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
            DPrintMessage fptr;
            //fptr = PrintHello;
            //fptr = delegate (string name)
            //{

            //};
            fptr = (n) => Console.WriteLine($"Lambda {n}");
            fptr("Manjunath");
        }

        private static void CaseStudy2()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anonymus Delegate Function 1");
                Console.WriteLine(name.ToLower());
            });
            PrintWizard((name) =>
            {
                Console.WriteLine("Inside Lambda Function 1");
                Console.WriteLine(name.ToLower());
            });
        }

        private static void CaseStudy1()
        {
            DPrintMessage obj = PrintHello;
            obj += PrintGoodBye;
            obj += PrintHello;
            obj += PrintHello;
            //obj += Foo;
            obj("Manjunath");
            obj("Abhi");
        }

        static void PrintWizard(DPrintMessage fptr) //fptr expects a function
        {
            Console.WriteLine("Doing Printing Operations...");
            Console.WriteLine("Operation Completed");
            fptr("CHAMP");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine($"Good Bye {name}");
        }
        static void Foo()
        {
            Console.WriteLine("Inside Foo");
        }
    }
}