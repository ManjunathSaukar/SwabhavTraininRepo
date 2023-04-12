using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player playerA, playerB;
            //CaseStudy1(out playerA, out playerB); 
            //CaseStudy2();

            Player playerA = new Player(1, "Sachin", 50);
            Player[] manyPlayer = new Player[5];
            manyPlayer[0] = new Player(1, "Player 1", 20);
            manyPlayer[1] = playerA;
            manyPlayer[2] = playerA;
            manyPlayer[3] = playerA;
            manyPlayer[4] = playerA;

            foreach (Player player in manyPlayer)
            {
                PrintDetails(player);
            }
        }

        private static void CaseStudy2()
        {
            Player playerA = new Player(1, "Sachin", 50);
            Player playerB = new Player(2, "Virat");
            Player elder = playerA.WhoIsElder(playerB);

            Console.WriteLine(elder.Name);
            Console.WriteLine(playerA.GetHashCode());
            Console.WriteLine(playerB.GetHashCode());
            Console.WriteLine(elder.GetHashCode());
        }

        private static void CaseStudy1(out Player playerA, out Player playerB)
        {
            playerA = new Player(1, "Sachin", 50);
            playerB = new Player(2, "Virat");
            PrintDetails(playerA, "Details of palyer 1: ");
            PrintDetails(playerB, "Details of palyer 2: ");
        }

        static void PrintDetails(Player player, string description="")
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"ID is:  {player.Id}");
            Console.WriteLine($"Name is : {player.Name}");
            Console.WriteLine($"Age is : {player.Age}");
            Console.WriteLine();
        }
    }
}
