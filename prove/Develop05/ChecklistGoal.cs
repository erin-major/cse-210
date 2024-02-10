using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted=0) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;        
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        int totalEarned = int.Parse(_points);

         if (_amountCompleted == _target)
        {
            totalEarned = int.Parse(_points) + _bonus;
        }

        Console.WriteLine($"\nCongratulations! You have earned {totalEarned} points!");     

        return totalEarned;  
    }

    public override bool IsComplete()
    {
        bool complete = false;

        if (_amountCompleted >= _target)
        {
            complete = true;
        }  

        return complete;
    }

    public override string GetDetailsString()
    {
        string details = "";
        
        if (IsComplete())
        {
            details = $"[x] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        
        else
        {
            details = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        
        return details;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}