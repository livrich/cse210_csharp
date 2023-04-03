using System;

public class Outdoor : Event
{
    private string _weather;

    // Constructor
    public Outdoor(string title, string description, string date, string time, string weather): 
    base (title, description, date, time)
    {
        _weather = weather;
        _fullDetails = SetFull();
        _shortDetails = SetShort();
    }

    // Methods to override from Event class
    public override string SetFull()
    {
        return $"Predicted Weather: {_weather}\n{_standardDetails}";
    }

    public override string SetShort()
    {
        return $"{_date}\nOutdoor: {_title}";
    }

    
}