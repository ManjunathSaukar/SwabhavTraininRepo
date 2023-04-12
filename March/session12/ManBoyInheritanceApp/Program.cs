using ManBoyInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
        }

        private static void CaseStudy5()
        {
            Object box;
            box = 10;
            Console.WriteLine(box.GetType());
            box = "Hello";
            Console.WriteLine(box.GetType());
            box = new Man();
            Console.WriteLine(box.GetType());
            Man man = (Man)box;
            Console.WriteLine(box.GetType());
            man.Play();
            man.Read();
        }

        private static void CaseStudy4()//Polymorphic method
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }

        private static  void AtThePark(Man man)
        {
            Console.WriteLine("At The Park");
            man.Play();
        }

        private static void CaseStudy3()
        {
            Man x;//x expects object of man or sub classes of man
            x = new Boy();
            x.Play();
            x.Read();
        }

        private static void CaseStudy2()
        {
            Boy boy= new Boy();
            boy.Play();
            boy.Eat();
            boy.Read();
        }

        private static void CaseStudy1()
        {
            Man man;//man expects an object of man type
            man = new Man();
            man.Play();
            man.Read();

        }
    }
}
