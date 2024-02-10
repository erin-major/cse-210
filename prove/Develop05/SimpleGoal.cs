using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool complete=false) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;       
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"\nCongratulations! You have earned {_points} points!");
        
        return int.Parse(_points);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}