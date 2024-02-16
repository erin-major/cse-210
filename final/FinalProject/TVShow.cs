using System;

public class TVShow : Item
{
    private string _seasons;
    private string _format;
    private string _version;

    public TVShow(string name, string seasons, string format, string version=null) : base(name)
    {
        _name = name;
        _seasons = seasons;
        _format = format;
        _version = version;
    }

    public override void DisplayItem()
    {
        
    }
}