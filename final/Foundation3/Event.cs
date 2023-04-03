using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    protected string _standardMessage;
    protected string _FullMessage;
    protected string _ShortMessage;

    // Constructor
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void Summary()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
    }
}