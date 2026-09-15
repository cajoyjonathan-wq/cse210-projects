using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "If I had to do one thing today, what would it be?",
        "What significant thing happened today?",
        "What felt boring in your day?",
        "Was there somebody you think was blessed because of you today?",
        "Have you seen the Hand of the Lord in your life today?"
    };

    private Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}