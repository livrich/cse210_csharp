using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, string speaker, int capacity): 
    base (title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
        _fullDetails = SetFull();
        _shortDetails = SetShort();
    }

    // Override methods from Event class
    public override string SetFull()
    {
        return $"Lecture with: {_speaker}\nRoom seats {_capacity}\n{_standardDetails}";
    }

    public override string SetShort()
    {
        return $"{_date}\nLecture: {_title}";
    }
}