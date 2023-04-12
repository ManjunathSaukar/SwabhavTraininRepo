using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName("Manjunath", 10);
            bool result1 = CheckIsEven1(3);
            Console.WriteLine("CheckEven1 : " + result1);
            Console.WriteLine("CheckEven2 : " + CheckIsEven2(6));
            Console.WriteLine("CheckEven3 : " + CheckIsEven3(7));
            Console.WriteLine("CheckEven4 : " + CheckIsEven4(7));
            PrintTodaysDate();

            Console.WriteLine(GetDeveloperNames());
            string[] developerNames = GetDeveloperNames();  
            foreach (string name in developerNames) {
                Console.WriteLine(name.ToUpper());
            }

            /*Console.Write("enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome : "+userName.ToUpper() );*/

            RollDice(6);
            RollDice(0);
        }

        static void RollDice(int rolls)
        {
            if (rolls < 1)
            {
                Console.WriteLine("Invalid input: number of rolls must be at least 1.");
                return;
            }
            Random rand = new Random();
            Console.WriteLine($"Rolling dice....");
            for (int i = 0; i < rolls; i++)
            {
                int rollResult = rand.Next(1, 7);
                Console.WriteLine($"{i} time  " + rollResult);
            }
        }
        private static string[] GetDeveloperNames()
        {
            String[] names = { "abc", "def", "ghi", "jkl", "mno"};
            return names;
        }

        static void PrintTodaysDate()
        {
            Console.WriteLine(DateTime.Now.ToString("D"));
        }

        static bool CheckIsEven1(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIsEven2(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool CheckIsEven3(int input)
        {
            return (input % 2 == 0);
        }

        static string CheckIsEven4(int input)
        {
            return (input % 2 == 0) ? "Input is Even" : "Input is Odd";
        }

        static void PrintName(string userName, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(userName.ToUpper());
            }
        }
    }
}
