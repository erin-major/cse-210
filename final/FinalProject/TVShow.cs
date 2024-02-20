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

    public override string DisplayItem()
    {
        string displayString = "";
        
        if (_version == null)
        {
            displayString = $"TV Show: {_name} seasons {_seasons} - {_format}";
        }
        else
        {
            displayString = $"TV Show: {_name} seasons {_seasons}, {_version} version - {_format}";
        }
        
        return displayString;
    }

    public override string GetStringRepresentation()
    {
        return $"TVShow|{_name}|{_seasons}|{_format}|{_version}|";
    }
}