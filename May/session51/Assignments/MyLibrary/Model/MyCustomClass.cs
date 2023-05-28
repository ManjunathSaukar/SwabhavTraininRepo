namespace MyLibrary
{
    public class MyCustomClass
    {
        public void PrintMulTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
