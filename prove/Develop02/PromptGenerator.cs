using System;

class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    
    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was a mistake I made today and what did I learn from it?");
        _prompts.Add("What was I most excited to do today?");
        _prompts.Add("Was today ordinary or extrordinary and why?");
        _prompts.Add("Who made an impact on my day today?");
        _prompts.Add("What did I do for others today?");
   
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count() - 1);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }
}