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

    public override string DisplayItem()
    {
        string displayString = "";
        
        if (_version == null)
        {
            displayString = $"Video Game: {_name} on {_system}";
        }
        else
        {
            displayString = $"Video Game: {_name}, {_version} version on {_system}";
        }
        
        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"VideoGame|{_name}|{_system}|{_version}|";
    }
}