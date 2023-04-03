using System;

public class Outdoor : Event
{
    private string _weather;

    // Constructor
    public Outdoor(string title, string description, string date, string time, string address, string weather): 
    base (title, description, date, time, address)
    {
        _weather = weather;
        _fullDetails = SetFull();
        _shortDetails = SetShort();
    }

    // Methods to override from Event class
    public override string SetFull()
    {
        return $"{_standardDetails}\nPredicted Weather: {_weather}";
    }

    public override string SetShort()
    {
        return $"{_date}\nOutdoor: {_title}";
    }

    
}