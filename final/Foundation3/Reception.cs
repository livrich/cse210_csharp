using System;

public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail): 
    base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Methods to override from Event class
    public override void SetFull()
    {
        _FullDetails = $"{_standardDetails}\nRSVP @ {_rsvpEmail}";
    }

    public override void SetShort()
    {
        _ShortDetails = $"{_date}\nReception: {_title}";
    }
    
}