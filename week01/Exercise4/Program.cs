using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int guessNumber = -1;

        while (guessNumber != 0)
        {
            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber != 0)
            {
                numbers.Add(guessNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}!");

        float average = (float)sum/numbers.Count;

        Console.WriteLine($"The total is {average}!");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Largest number is {max}!");


    }
}