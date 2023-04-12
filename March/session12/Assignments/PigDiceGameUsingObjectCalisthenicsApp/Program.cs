using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGameUsingObjectCalisthenicsApp
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
            int turnCount = 1;

            while (totalScore < 20)
            {
                Console.WriteLine("TURN " + turnCount + ":");
                int turnScore = PlayTurn();

                totalScore += turnScore;
                Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore);

                if (totalScore >= 20)
                {
                    Console.WriteLine("You Win! You finished in " + turnCount + " turns!");
                    return;
                }

                turnCount++;
            }

            Console.WriteLine("Game over!");
        }

        static int PlayTurn()
        {
            int turnScore = 0;

            while (true)
            {
                Console.Write("Enter 'r' to roll again, 'h' to hold: ");
                string input = Console.ReadLine();

                if (input == "r")
                {
                    int roll = RollDie();
                    Console.WriteLine("You rolled: " + roll);
                    turnScore = HandleRoll(roll, turnScore);
                }
                else if (input == "h")
                {
                    return turnScore;
                }
                else
                {
                    HandleInvalidInput();
                }
            }
        }

        static int HandleRoll(int roll, int turnScore)
        {
            if (roll == 1)
            {
                Console.WriteLine("Turn over. No Score");
                return turnScore;
            }
            else
            {
                turnScore += roll;
                Console.WriteLine("Your turn score is " + turnScore);
                return turnScore;
            }
        }

        static void HandleInvalidInput()
        {
            Console.WriteLine("Invalid input. Try again.");
        }


        static int RollDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
