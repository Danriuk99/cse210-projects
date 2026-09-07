using System;
using System.Data;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        string name = PromptUsername();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResults(name,number,squared);
        
    }
    static string PromptUsername()
    {
        Console.WriteLine("What is your name?: ");
        String userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number");
        string response = Console.ReadLine();
        int userNumber = int.Parse(response);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
       
        int Squarenumber = userNumber * userNumber;
        return Squarenumber;
        
    }
    static void DisplayResults(string name, int number, int squared)
    {
        Console.WriteLine($"{name}, the square of your number {number} is {squared}");
    }
       
        
    

    
    
}