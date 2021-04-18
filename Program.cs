﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a secret number between 1 and 100:");
            Console.WriteLine("");
            
            // Create a Random object
            Random random = new Random();
            // Then use it to generate a random Secret Number to be guessed by user
            int secretNum = random.Next(1, 101);

            // Initiate the guess counter at 1
            int numOfGuesses = 0;

            // Limit number of guesses to 6
            for (int i = 0; i < 6; i++)

            {
                // Create a string variable and get user input from the keyboard and store it in the variable
                string userNum = Console.ReadLine();

                // Parse the user input string to get an integer
                int parsedUserNum = Int32.Parse(userNum);

                // Increment number of guesses by 1
                numOfGuesses++;

                if (secretNum == parsedUserNum)
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                    
                }
                else if (secretNum < parsedUserNum)
                {
                    Console.WriteLine($"Nope, Its not {parsedUserNum}!");
                    Console.WriteLine($"{6 - numOfGuesses} guesses remaining");
                    if (numOfGuesses != 6)
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
                    Console.WriteLine($"{6 - numOfGuesses} guesses remaining");
                    if (numOfGuesses != 6)
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