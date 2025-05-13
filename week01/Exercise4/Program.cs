using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        
        do
        {
            Console.Write("Add a number to the list: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        // math part
        int sum = 0;
        int largestNumber = numbers[0]; // largestNumber starts by the first item of the list
        int smallestPositive = numbers[0];

        foreach (int number in numbers)
        {
            sum += number; // Equivalent to sum = sum + number. sum being initially 0, and after summing every number from the list.

            if (number > largestNumber) // to find the largest number
            {
                largestNumber = number; // if number is greater than largestNumber, then largestNumber is no longer the first item from the list. If the loop runs throughout the list and don't find any greater, then sure it is the first one.
            }

            if (number > 0 && number < smallestPositive) // to find the smallest positive number
            {
                smallestPositive = number;
            } 
        }

        int itemsCount = numbers.Count;        
        double average = (double)sum / itemsCount;

        // display part
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average is {average:F2}");
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"The smallest positive number is {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        
        // sort part
        numbers.Sort();

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}