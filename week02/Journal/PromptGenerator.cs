using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most useful thing I learned today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}