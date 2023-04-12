using CompositeDesignPatternApp.Model;

namespace CompositeDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
            compositeRoot.AddChild(new File("Pushpa", 900));
            compositeRoot.AddChild(new File("Bad Boys", 799));

            Folder action = new Folder("Action");
            compositeRoot.AddChild(action);
            action.AddChild(new File("London has fallen", 902));
            action.AddChild(new File("John wick", 1082));

            Folder horror = new Folder("Horror");
            compositeRoot.AddChild(horror);
            horror.AddChild(new File("Evil Dead", 552));
            horror.AddChild(new File("The Conuring", 1262));
            
            compositeRoot.Display();
        }
    }
}