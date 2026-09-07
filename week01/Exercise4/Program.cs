using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int Loop = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (Loop != 0)
        {
            Console.WriteLine("Enter number: ");
            String userValue = Console.ReadLine();
            Loop = int.Parse(userValue);
           if (Loop != 0)
            {
                numbers.Add(Loop);
            }
        }
        if (numbers.Count > 0)
        {
            int largest = numbers[0];
            int totalSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                totalSum += numbers[i];

                
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
                
                
            }
        
        
        double average = (double)totalSum / numbers.Count;
        Console.WriteLine($"The sum is:{totalSum}");
        Console.WriteLine($"Average number is: {average}");
        Console.WriteLine($"Largest number is: {largest}");
        }
        
    }
}