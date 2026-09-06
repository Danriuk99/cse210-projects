using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        String Grade = Console.ReadLine();
        int GradeValue = int.Parse(Grade);

        if (GradeValue >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (GradeValue >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if ( GradeValue >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (GradeValue >= 60)
        {
            Console.WriteLine("You did not pass the course. You get a D");
        }
        else
        {
            Console.WriteLine("You did not pass the course. You get an F");
        }
    
        
    }
}