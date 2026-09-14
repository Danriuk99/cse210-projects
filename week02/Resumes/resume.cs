using System;

public class Resume
{
    public string _name;
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        foreach(Job j in _Jobs)
        {
            j.Display();
        }

    }

} 