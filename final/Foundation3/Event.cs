using System;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _standardDetails;
    protected string _FullDetails;
    protected string _ShortDetails;

    // Constructor
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _standardDetails = $"{_title}\n{_description}\n{_date} @ {_time}\n{_address}";
    }

    // Methods to override
    public abstract void SetFull();
    public abstract void SetShort();

    public void Summary()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
    }
}