using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances(objects) of the Fractions class and adding the arguments for the parameters
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(5);
        Fractions fraction3 = new Fractions(3, 4);
        Fractions fraction4 = new Fractions(1, 3);

        //fraction1 display
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        //fraction2 display
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        //fraction3 display
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        //fraction4 display
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}