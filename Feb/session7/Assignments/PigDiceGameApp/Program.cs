using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayPigGame();
        }
        static void PlayPigGame()
        {
            Console.WriteLine("Welcome to the game of Pig!");
            int totalScore = 0;
            int turnScore = 0;
            int turnCount = 1;

            while (totalScore < 20)
            {
                Console.WriteLine("TURN " + turnCount + ":");
                turnScore = 0;
                bool turnOver = false;

                while (!turnOver)
                {
                    Console.Write("Enter 'r' to roll again, 'h' to hold: ");
                    string input = Console.ReadLine();

                    if (input == "r")
                    {
                        int roll = RollDie();
                        Console.WriteLine("You rolled: " + roll);

                        if (roll == 1)
                        {
                            Console.WriteLine("Turn over. No Score");
                            turnOver = true;
                        }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore);
                            if (turnScore + totalScore >= 20)
                            {
                                Console.WriteLine("You Win! You finished in " + turnCount + " turns!");
                                return;
                            }
                        }
                    }
                    else if (input == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore);
                        turnOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                turnCount++;
            }

            Console.WriteLine("Game over!");
        }

        static int RollDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
