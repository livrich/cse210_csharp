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

    
}