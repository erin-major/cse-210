using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goals = new GoalManager();

        goals.Start();
    }    
}

// I exceeded expectations by adding a try catch block when loading the file.
// I added a catch if the user input something other than 1-6 for the menu.