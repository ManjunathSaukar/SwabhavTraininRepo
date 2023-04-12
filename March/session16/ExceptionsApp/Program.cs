namespace ExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(args[0]);
            int second = int.Parse(args[1]);    
            int result= first /second;
            Console.WriteLine($"{first} / {second} = {result}");
            Console.WriteLine("End of Main");
            //Main(args); //gives StackOverFlowException


        }
        /*
         System.IndexOutOfRangeException, line no :\program.cs :line 7
         System.DivideByZeroException, line no :\program.cs line 9
         System.FormatException, line no :\program.cs line 7
        System.OverflowException, line no :\program.cs line 7
         */
    }
}