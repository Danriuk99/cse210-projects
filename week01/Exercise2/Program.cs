using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeValue = int.Parse(grade);

        string letter = "";

        if (gradeValue >= 90)
        {
            letter = "A";
        }
        else if (gradeValue >= 80)
        {
            letter = "B";
        }
        else if (gradeValue >= 70)
        {
            letter = "C";
        }
        else if (gradeValue >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeValue >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Keep trying for next time!");
        }
    }
}