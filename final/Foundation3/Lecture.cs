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

    // Override methods from Event class
    public override void SetFull()
    {
        _FullDetails = $"{_standardDetails}\nLecture with {_speaker}\nRoom seats {_capacity}";
    }

    public override void SetShort()
    {
        _ShortDetails = $"{_date}\nLecture: {_title}";
    }
}