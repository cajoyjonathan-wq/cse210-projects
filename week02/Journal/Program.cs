using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

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
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string response = Console.ReadLine();

                Entry entry = new Entry()
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }

    }
}