using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;   
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details = "";
        
        if (IsComplete())
        {
            details = $"[x] {_shortName} ({_description})";
        }
        
        else
        {
            details = $"[ ] {_shortName} ({_description})";
        }
        
        return details;
    }
}