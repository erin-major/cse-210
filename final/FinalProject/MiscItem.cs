using System;

public class MiscItem : Item
{
    private string _description;

    public MiscItem(string name, string description) : base(name)
    {
        _name = name;
        _description = description;
    }

    public override void DisplayItem()
    {
        
    }
}