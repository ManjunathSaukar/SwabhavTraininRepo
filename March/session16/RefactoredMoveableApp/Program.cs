using RefactoredMoveableApp.Model;

namespace RefactoredMoveableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable[] moveables =
            {
                new Car ("Honda"),
                new Car("Benz"),
                new Truck("Ashok Leyland"),
            };

            SatrtRace(moveables);
        }

        private static void SatrtRace(IMoveable[] moveables)
        {
            Console.WriteLine("Race Started");
            foreach(IMoveable moveable in moveables)
            {
                moveable.Move();
            }
            Console.WriteLine("Race Ended");
        }
    }
}