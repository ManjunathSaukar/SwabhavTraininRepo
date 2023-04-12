using MoveableVechileApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableVechileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable[] moveable = new IMoveable[5];

            moveable[0] = new Car("Audi");
            moveable[1] = new Bike("Honda");
            moveable[2] = new Truck("Ashok Leyland");
            moveable[3] = new Car("Benz");
            moveable[4] = new Bike("Pulsar");

            StartRace(moveable);

        }
        public static void StartRace(IMoveable[] moveable)
        {
            Console.WriteLine("Start the race");
            foreach (var move in moveable)
            {
                move.Move();
            }
            Console.WriteLine("Race Ends");
            Console.WriteLine();
        }
    }
}
