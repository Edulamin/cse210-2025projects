using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

        
        // Stretch Challenge Part:

        string signal = "";
        float lastNumber = gradePercentage % 10;
        
        if (gradePercentage < 93 && letter != "F")
        {
            if (lastNumber >= 7)
            {
                signal = "+";
            }
            else if (lastNumber < 3)
            {
                signal = "-";
            }
        }
        else
        {
            signal = "";
        }

        //Print Messages Part:

        Console.WriteLine($"Your percentage corresponds to {letter}{signal}");

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