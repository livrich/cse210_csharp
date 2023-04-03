using System;

public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor
    public Reception(string rsvpEmail): base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    
}