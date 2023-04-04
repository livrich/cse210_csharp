using System;

public abstract class Activity
{
    protected DateTime _date;
    // Format _date.ToString("dd MMM yyyy")

    protected int _duration;
    // User enters how far they went
    protected double _distance;
    protected double _speed;
    protected double _pace;
    // Child classes set type of activity
    protected string _type;

    // Constructor
    public Activity(int duration)
    {
        _date = DateTime.Today;
        _duration = duration;
    }

    // Abstract methods to calculate distance,
    // speed, and pace.
    public abstract double CalcDistance();
    
    public abstract double CalcSpeed();
    
    public abstract double CalcPace();

    // Method to return summary of activity
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_duration} min):" +
        $"\n\tDistance - {_distance} miles " +
        $"\n\tSpeed - {_speed} miles per hour " +
        $"\n\tPace - {Math.Round(_pace,2)} min per mile";
    }
}