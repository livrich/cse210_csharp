using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity): 
    base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}