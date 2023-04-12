using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small; //expects an object Rectangle small = new Rectangle();
            Rectangle big; 
            small= new Rectangle();
            big  = new Rectangle();
            big.width = 100;
            big.height = 50;
            Console.WriteLine("The width and height of big rectangle is :{0} {1}", big.width, big.height);
            Console.WriteLine("The area of big rectangle is :{0} \n",big.CalculateArea());
            
            small.width=20;
            small.height= 10;
            Console.WriteLine("The width and height of small rectangle is :{0} {1}", small.width, small.height);
            Console.WriteLine("The area of small rectangle is :{0}",small.CalculateArea());

        }
    }
}
