using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine("What is the magic number?");
        Console.WriteLine("What is your guess?");

        int guessNumber = int.Parse(Console.ReadLine());



        while (guessNumber != number)
        {
            if (guessNumber > number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Lower");
            }

            Console.WriteLine("What is your guess?");

            guessNumber = int.Parse(Console.ReadLine());

        }
        Console.Write("You guessed it!");

    }
}