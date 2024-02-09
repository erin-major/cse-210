using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter 1-6.");
                Thread.Sleep(2000);
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points!");
    }

    public void ListGoalNames()
    {
        int goalNum = 1;
        Console.WriteLine("The goals are: ");

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{goalNum}. {g.GetName()}");
            goalNum += 1;
        }

    }

    public void ListGoalDetails()
    {   
        int goalNum = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{goalNum}. {g.GetDetailsString()}");
            goalNum += 1;
        }
    }

    public void CreateGoal()
    {
        while (true)
        {
            Console.WriteLine("\nThe types of Goals are: ");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string userGoalChoice = Console.ReadLine();
            


            if (userGoalChoice == "1" || userGoalChoice == "2" || userGoalChoice == "3")
            {
                Console.Write("\nWhat is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                if (userGoalChoice == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                }

                else if (userGoalChoice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }

                else if (userGoalChoice == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                }
                break;
            }
            
            else
            {
                Console.WriteLine("\nInvalid input. Please enter 1-3.\n");
                Thread.Sleep(2000);
            }

        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userGoal = int.Parse(Console.ReadLine());
        _goals[userGoal].RecordEvent();

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine(); 
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), amountCompleted:int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }

        }

    }
    }