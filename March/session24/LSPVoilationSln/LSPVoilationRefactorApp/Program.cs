using LSPVoilationRefactorApp.Model;

namespace LSPVoilationRefactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(100, 20);
            ShouldNotChangeHeight_IfWidthIsModified(rect);

            //ShouldNotChangeHeight_IfWidthIsModified(new Square(50)); //gives Compilation error
        }
        static void ShouldNotChangeHeight_IfWidthIsModified(Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth() + 10);
            int afterChange = rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange);
        }
    }
}