using System;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _standardDetails;
    protected string _fullDetails;
    protected string _shortDetails;

    // Constructor
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = CreateAddress();
        _standardDetails = $"{_title}\n{_description}\n{_date}, {_time}\n{_address.SingleString()}";
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

    // Method to create Address
    public Address CreateAddress()
    {
        // Get information about address from user
        Console.WriteLine("Enter the following address information");
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string stateProvince = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();

        // Call Address class to create address
        Address a = new Address(street, city, stateProvince, country);
        return a;
    }
}