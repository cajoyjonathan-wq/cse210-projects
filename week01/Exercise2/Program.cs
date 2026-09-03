using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "This is not in the required Grades Range.";
        }

        Console.WriteLine(letter);

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you've passed!");
        }
        else
        {
            Console.WriteLine("I'm Sorry. You can do better next time.");
        }
    }
}