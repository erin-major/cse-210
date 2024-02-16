using System;

public class VideoGame : Item
{
    private string _system;
    private string _version;

    public VideoGame(string name, string system, string version=null) : base(name)
    {
        _name = name;
        _system = system;
        _version = version;
    }

    public override void DisplayItem()
    {
        
    }
}