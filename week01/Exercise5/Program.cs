using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        int squaredNum = Squared(number);

        Statement(name, squaredNum);

    }
    static int Squared(int number)
    {
        int sum = number * number;
        return sum;
    }
    static void Statement(string name, int squared)
    {
        Console.Write($"{name}, the square of your number is {squared}.");
    }
}