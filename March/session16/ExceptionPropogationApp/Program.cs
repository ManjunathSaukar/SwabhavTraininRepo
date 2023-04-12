namespace ExceptionPropogationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inside main");
            try
            {
                F1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToUpper());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            Console.WriteLine("end of main");

        }

        private static void F1()
        {
            Console.WriteLine("inside F1");
            F2();
            Console.WriteLine("end of F1");
        }

        private static void F2()
        {
            Console.WriteLine("inside F2");
            F3();
            Console.WriteLine("end of F3");
        }

        private static void F3()
        {
            Console.WriteLine("inside F3");
            throw new Exception("Something Went Wrong in F3");
        }
    }
}