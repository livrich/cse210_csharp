using System;

public class Outdoor : Event
{
    private string _weather;

    // Constructor
    public Outdoor(string title, string description, string date, string time, string address, string weather): 
    base (title, description, date, time, address)
    {
        _weather = weather;
    }

    // Methods to override from Event class
    public override void SetFull()
    {
        _FullDetails = $"{_standardDetails}\nPredicted Weather: {_weather}";
    }

    public override void SetShort()
    {
        _ShortDetails = $"{_date}\nOutdoor: {_title}";
    }

    
}