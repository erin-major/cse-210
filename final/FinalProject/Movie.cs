using System;

public class Movie : Item
{
    private string _year;
    private string _format;

    public Movie(string name, string year, string format) : base(name)
    {
        _name = name;
        _year = year;
        _format = format;
    }

    public override void DisplayItem()
    {
        
    }
}