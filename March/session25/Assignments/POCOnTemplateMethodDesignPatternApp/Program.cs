using POCOnTemplateMethodDesignPatternApp.Model;

namespace POCOnTemplateMethodDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maggi classicMaggi = new ClassicMaggi();
            Console.WriteLine("Steps for making Classic Maggi:\n");
            classicMaggi.MakeMaggi();
        }
    }
}