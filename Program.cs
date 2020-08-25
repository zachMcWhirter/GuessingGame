using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type 
            Console.WriteLine("Guess a secret number between 1 and 100:");

            //Secret Number to be guessed by user
            int secretNum = 42;

            //Initiate the guess counter at 1
            int numOfGuesses = 0;

            // while (numOfGuesses <= 3)

            //Limit number of guesses to 4
            for (int i = 0; i < 4; i++)

            {
                // Create a string variable and get user input from the keyboard and store it in the variable
                string userNum = Console.ReadLine();

                // parsedUserNum = Int32.Parse(Console.ReadLine());

                //Parse the user input string to get an integer
                int parsedUserNum = Int32.Parse(userNum);

                numOfGuesses++;
                if (secretNum != parsedUserNum)
                {
                    Console.WriteLine($"Your guess: {numOfGuesses}");
                    Console.WriteLine("Nope");
                    if (numOfGuesses != 4)
                    {
                        Console.WriteLine($"Guess again!");
                    }
                }
                else
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                }
            }
        }
    }
}