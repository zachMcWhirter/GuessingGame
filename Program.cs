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

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userNum = Console.ReadLine();

            //Parse the user input string to get an integer
            int parsedUserNum = Int32.Parse(userNum);

            //Initiate the guess counter at 1
            int numOfGuesses = 1;

            //Limit number of guesses to 4
            while (numOfGuesses < 4)

            {
                if (secretNum == parsedUserNum)
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                }
                else if (secretNum != parsedUserNum)
                {
                    Console.WriteLine("Nope");
                    numOfGuesses++;
                    Console.WriteLine("guess again!");
                    parsedUserNum = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}