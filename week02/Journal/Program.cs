using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        List<string> prompts = new List<string>
        {
            "If I had to do one thing today, what would it be?",
            "What significant thing happened today?",
            "What felt boring in your day?",
            "Was there somebody you think was blessed because of you today?",
            "Have you seen the Hand of the Lord in your life today?"
        };

        List<string> entries = new List<string>();

        Random randList = new Random();


        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                int index = randList.Next(prompts.Count);
                string randomPrompt = prompts[index];
                Console.WriteLine($"{randomPrompt}");
                string entry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string display = ($"{dateText}, {randomPrompt} Response: {entry}");

                entries.Add(display);

            }
            else if (choice == "2")
            {
                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (choice == "3")
            {
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();

                    if (File.Exists(filename))
                    {
                        string[] lines = File.ReadAllLines(filename);
                        entries = new List<string>(lines);
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }

                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string entry in entries)
                    {
                        outputFile.WriteLine(entry);
                    }
                }
            }
        }

    }
}