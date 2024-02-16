using System;

public class BoardGame : Item
{
    private string _version;

    public BoardGame(string name, string version=null) : base(name)
    {
        _name = name;
        _version = version;
    }

    public override void DisplayItem()
    {
        
    }
}