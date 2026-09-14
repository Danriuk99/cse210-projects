using System;

class Program
{
    static void Main(string[] args)
    {
        string _menuInterfaz = "0";
        Journal _theJournal = new Journal();

        while (_menuInterfaz != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            _menuInterfaz = Console.ReadLine();
            
            if (_menuInterfaz == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                string currentDate = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._dateTime = currentDate;
                newEntry._prompText = prompt;
                newEntry._entryText = entryText;
                _theJournal.AddEntry(newEntry);
            }
            else if (_menuInterfaz == "2")
            {
                _theJournal.DisplayAll();
            }
            else if (_menuInterfaz == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                _theJournal.LoadFromFile(filename);
            }
            else if (_menuInterfaz == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                _theJournal.SaveToFile(filename);
            }
        }
    }
}