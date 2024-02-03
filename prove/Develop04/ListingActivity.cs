using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // I'm storing the list the user gave in case I want to adjust my code and use it later.
        List<string> responeList = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are the people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random randomNum = new Random();
        int i = randomNum.Next(0, _prompts.Count);
        string prompt = _prompts[i];

        Console.WriteLine($" --- {prompt} --- ");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
            _count += 1;
            currentTime = DateTime.Now;
        }

        return userList;
    }
}