using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyClass
    {
        public string DisplayHelloWorld()
        {
            return "Hello World!";
        }

        public int Sum(int a, int b) 
        {
            return a + b;
        }
        public void MultiplicationTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
