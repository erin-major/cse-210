using System;

public abstract class Item
{
    protected string _name;

    public Item(string name)
    {
        _name = name;
    }

    public abstract void DisplayItem();

}

