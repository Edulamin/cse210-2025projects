using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Put here your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }

        else if(gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your percentage corresponds to the letter {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you've been approved!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass this time. Try doing it again!");
        }
    }
}