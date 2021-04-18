using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your difficulty level: ");
            Console.WriteLine("1  for EASY (8 guesses)");
            Console.WriteLine("2  for MEDIUM (6 guesses)");
            Console.WriteLine("3  for HARD (4 guesses)");

            // Initiate the guess counter at 1
            int numOfGuesses = 0;

            string difficulty = Console.ReadLine();

            if (difficulty == "1")
            {
                numOfGuesses = 8;
            }
            else if (difficulty == "2")
            {
                numOfGuesses = 6;
            }
            else if (difficulty == "3")
            {
                numOfGuesses = 4;
            }
            else
            {
                Console.WriteLine("Choose your difficulty level: ");
                Console.WriteLine("1  for EASY (8 guesses)");
                Console.WriteLine("2  for MEDIUM (6 guesses)");
                Console.WriteLine("3  for HARD (4 guesses)");
            }

            Console.WriteLine("Guess a secret number between 1 and 100:");
            Console.WriteLine("");
            
            // Create a Random object
            Random random = new Random();
            // Then use it to generate a random Secret Number to be guessed by user
            int secretNum = random.Next(1, 101);

            ;

            // Limit number of guesses to 6
            while (numOfGuesses > 0)

            {
                // Create a string variable to get user input and store it as userNum
                string userNum = Console.ReadLine();

                // Parse the user input string to get an integer
                int parsedUserNum = Int32.Parse(userNum);

                // Increment number of guesses by 1
                numOfGuesses--;

                if (secretNum == parsedUserNum)
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                    
                }
                else if (secretNum < parsedUserNum)
                {
                    Console.WriteLine($"Nope, Its not {parsedUserNum}!");
                    Console.WriteLine($"{numOfGuesses} guesses remaining");
                    if (numOfGuesses != 0)
                    {
                        Console.WriteLine("Guess Lower!");
                        Console.WriteLine("");
                        Console.WriteLine("------------");
                        Console.WriteLine("");
                    }
                }
                else if (secretNum > parsedUserNum)
                {
                    Console.WriteLine($"Nope, Its not {parsedUserNum}!");
                    Console.WriteLine($"{numOfGuesses} guesses remaining");
                    if (numOfGuesses != 0)
                    {
                        Console.WriteLine("Guess Higher!");
                        Console.WriteLine("");
                        Console.WriteLine("------------");
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}