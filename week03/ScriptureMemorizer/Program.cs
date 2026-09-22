using System;

public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference.GetDisplayText(), "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        string userInput = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the entire scripture.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}