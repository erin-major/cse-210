using System;

public class MiscItem : Item
{
    private string _description;

    public MiscItem(string name, string description) : base(name)
    {
        _name = name;
        _description = description;
    }

    public override string DisplayItem()
    {
        string displayString = $"Miscellaneous Item: {_name}, {_description}";

        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"TVShow|{_name}|{_description}|";
    }
}