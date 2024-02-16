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

    public override void DisplayItem()
    {
        
    }
}