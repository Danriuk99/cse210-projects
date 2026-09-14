using System;

public class Entry
{
    public string _dateTime;
    public string _prompText;
    public string _entryText;
    
    public void Display()
    {
        Console.WriteLine($"date: {_dateTime} - Prompt: {_prompText}");
        Console.WriteLine($"{_entryText}");
        
    }
}    
