using System;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _standardDetails;
    protected string _fullDetails;
    protected string _shortDetails;

    // Constructor
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _standardDetails = $"{_title}\n{_description}\n{_date}, {_time}\n{_address}";
    }

    // Methods to override
    public abstract string SetFull();
    public abstract string SetShort();

    // Series of get methods
    public string GetStandard()
    {
        return _standardDetails;
    }

    public string GetFull()
    {
        return _fullDetails;
    }

    public string GetShort()
    {
        return _shortDetails;
    }
}