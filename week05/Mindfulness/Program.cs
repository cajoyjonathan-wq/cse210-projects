using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string userInput = "";

        while (userInput != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            } else if (userInput == "2") {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            } else if (userInput == "3") {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            } else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}