using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        String name = Console.ReadLine();
        Console.WriteLine("What is your last name");
        String lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
    }
}