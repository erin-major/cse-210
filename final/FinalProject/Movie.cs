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

    public override string DisplayItem()
    {
        string displayString = $"Movie: {_name}, {_year} - {_format}";

        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"Movie|{_name}|{_year}|{_format}|";
    }
}