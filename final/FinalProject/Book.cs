using System;

public class Book : Item
{
    private string _author;
    private string _format;

    public Book(string name, string author, string format) : base(name)
    {
        _name = name;
        _author = author;
        _format = format;
    }

    public override string DisplayItem()
    {
        string displayString = $"Book: {_name} by {_author} - {_format}";

        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"Book|{_name}|{_author}|{_format}|";;
    }
}