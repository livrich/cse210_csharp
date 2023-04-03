using System;

public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail): 
    base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _fullDetails = SetFull();
        _shortDetails = SetShort();
    }

    // Methods to override from Event class
    public override string SetFull()
    {
        return $"{_standardDetails}\nRSVP @ {_rsvpEmail}";
    }

    public override string SetShort()
    {
        return $"{_date}\nReception: {_title}";
    }
    
}