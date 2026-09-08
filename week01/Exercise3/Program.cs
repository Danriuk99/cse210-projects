using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        Console.WriteLine($"The randomn number is {number}");
        int Guess = -1;

        while (Guess != number)        
        {
            Console.WriteLine("What is your guess? ");
            String guess = Console.ReadLine();
            Guess = int.Parse(guess);

            if (Guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (Guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}