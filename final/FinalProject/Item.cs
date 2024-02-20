using System;

public abstract class Item : IComparable<Item>
{
    protected string _name;

    public Item(string name)
    {
        _name = name;
    }

    public abstract string DisplayItem();

    public abstract string GetStringRepresentation();

    // This method lets me sort the lists into each item type category.
    public int CompareTo(Item other)
    {
        int typeComparison = string.Compare(this.GetType().Name, other.GetType().Name, StringComparison.Ordinal);
    
        if (typeComparison != 0)
        {
            return typeComparison;
        }
        return string.Compare(_name, other._name, StringComparison.Ordinal);
    }
}

