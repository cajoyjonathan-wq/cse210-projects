using System;
class Program

{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine onw understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // string response = "";

        // while (response != "quit" && !scripture.IsCompletelyHidden())
        while (true)
        {

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish");

            string response = Console.ReadLine();

            if (response != null && response.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }

}