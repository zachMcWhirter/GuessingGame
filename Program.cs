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
            string userGuess = Console.ReadLine();
            // Print the value of the variable (userGuess), which will display the input value
            // Console.WriteLine($"You guessed: {userGuess}");

            int parsedNum = Int32.Parse(userGuess);
            if (secretNum == parsedNum)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }
    }
}