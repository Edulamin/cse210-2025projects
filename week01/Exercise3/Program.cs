using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int userGuess;
            int guessCount = 0;

            Console.WriteLine("Try to guess the Magic Number");
            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You've guessed it!");
                    Console.WriteLine($"You've Taken {guessCount} guesses!");
                }

            } while (userGuess != magicNumber);

            Console.Write("Would you like to play it again? ");
            playAgain = Console.ReadLine();

            if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing!");
            }

        } while (playAgain == "yes");
        
    }    
}