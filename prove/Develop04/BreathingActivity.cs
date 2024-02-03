using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        int loopDuration = _duration;
        Random randomInterval = new Random();
        int interval = 0;

        while (loopDuration > 0)
        {
            // I felt anything less than 3 seconds was too short and 
            // anything over 8 was too long. 
            interval = randomInterval.Next(3, 9);
            Console.Write($"\n\nBreathe in...");
            ShowCountDown(interval);
            loopDuration = loopDuration - interval;
            interval = randomInterval.Next(3, 9);
            Console.Write($"\nNow breathe out...");
            ShowCountDown(interval);
            loopDuration = loopDuration - interval;
        }
        Console.WriteLine();
        DisplayEndingMessage();            
    }
}