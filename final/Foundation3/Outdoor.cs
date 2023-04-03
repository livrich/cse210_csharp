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

    
}