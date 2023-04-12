using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Object[] boxedItems = new Object[5];
            boxedItems[0] = 10d;
            boxedItems[1] = 20.55d;
            boxedItems[2] = 30.45d;
            boxedItems[3] = 40.45d;
            boxedItems[4] = 50.45d;


            Console.WriteLine(boxedItems[0].GetType());
            Console.WriteLine(boxedItems[1].GetType());
            Console.WriteLine(boxedItems[2].GetType());

            double sum = 0;
            foreach(Object item in boxedItems)
            {
                double unboxedItem = (double)item;
                sum += unboxedItem;
            }
            Console.WriteLine(sum);

        }

        private static void CaseStudy1()
        {
            Object box;
            box = new Object();
            Console.WriteLine(box.GetHashCode()); 
            Console.WriteLine(box.GetType());
            box = 100.55;
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());

            box = (double)box + 10;
            Console.WriteLine(box);
        }
    }
}
