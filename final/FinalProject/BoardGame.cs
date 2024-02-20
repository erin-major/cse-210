using System;

public class BoardGame : Item
{
    private string _version;

    public BoardGame(string name, string version=null) : base(name)
    {
        _name = name;
        _version = version;
    }

    public override string DisplayItem()
    {
        string displayString = "";
        
        if (_version == null)
        {
            displayString = $"Board Game: {_name}";
        }
        else
        {
            displayString = $"Board Game: {_name}, {_version} version";
        }
        
        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"BoardGame|{_name}|{_version}|";
    }
}