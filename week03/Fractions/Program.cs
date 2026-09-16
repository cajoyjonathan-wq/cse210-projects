using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions fractions1 = new Fractions();
        Console.WriteLine(fractions1.GetFractionString());
        Console.WriteLine(fractions1.GetDecimalValue());

        Fractions fractions2 = new Fractions(5);
        Console.WriteLine(fractions2.GetFractionString());
        Console.WriteLine(fractions2.GetDecimalValue());

        Fractions fractions3 = new Fractions(3, 4);
        Console.WriteLine(fractions3.GetFractionString());
        Console.WriteLine(fractions3.GetDecimalValue());

        Fractions fractions4 = new Fractions(1, 3);
        Console.WriteLine(fractions4.GetFractionString());
        Console.WriteLine(fractions4.GetDecimalValue());


    }
}