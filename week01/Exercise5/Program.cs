using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program! :)");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;

            return squaredNumber;
        }

        static void DisplayResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }

}