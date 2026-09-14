using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _myJournal = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _myJournal.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry E in _myJournal)
        {
            E.Display();
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        _myJournal.Clear();

        for (int i = 0; i < lines.Length; i += 3)
        {
            if (i + 2 < lines.Length)
            {
                Entry newEntry = new Entry();
                newEntry._dateTime = lines[i];
                newEntry._prompText = lines[i + 1];
                newEntry._entryText = lines[i + 2];
                
                _myJournal.Add(newEntry);
            }

        }
        
    }
    public void SaveToFile(string file)
    {
        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(file))
        {
            foreach (Entry E in _myJournal)
            {
                outputFile.WriteLine(E._dateTime);
                outputFile.WriteLine(E._prompText);
                outputFile.WriteLine(E._entryText);
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

}