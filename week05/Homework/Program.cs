using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine($"{summary}");


        MathAssignments math = new MathAssignments("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string displayMath = math.GetHomeWorkList();
        Console.WriteLine($"{displayMath}");

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingDisplay = writing.GetWritingInformation();
        Console.WriteLine($"{writingDisplay}");
    }
}