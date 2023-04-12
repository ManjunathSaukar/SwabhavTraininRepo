using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            do
            {
                int numberToGuess = random.Next(1, 101);
                //Console.WriteLine(numberToGuess);
                int tries = 0;

                Console.WriteLine("------Welcome to the number guessing  game!------");

                while (tries < 5)
                {
                    Console.Write("Please enter a guess between 1 and 100: ");
                    int guess;

                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        if (guess < 1 || guess > 100)
                        {
                            Console.WriteLine("Invalid input, the entered number must be within 1 to 100.");
                            break;
                        }
                        else if (guess < numberToGuess)
                        {
                            Console.WriteLine("Sorry,The guessed number is Too Low. Please guess a higher number");
                            tries++;
                        }
                        else if (guess > numberToGuess)
                        {
                            Console.WriteLine("Sorry,The guessed number is Too High. Please guess a lower number");
                            tries++;
                        }
                        else
                        {
                            Console.WriteLine("Congratulations, you guessed the correct number in {0} tries!", tries + 1);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
                }

                if (tries == 5)
                {
                    Console.WriteLine("Sorry, you're out of tries.");
                    Console.WriteLine("The number was {0}.", numberToGuess);
                }

                Console.WriteLine("Do you want to play again? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("Thanks for playing the game!");
        }
    }
}
