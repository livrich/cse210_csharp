using System;

public class Outdoor : Event
{
    private string _weather;

    // Constructor
    public Outdoor(string weather): base (title, description, date, time, address)
    {
        _weather = weather;
    }

    
}