using System;

public abstract class Activity
{
    protected DateTime _date;
    // Format _date.ToString("dd MMM yyyy") [04 Apr 2023]

    protected int _duration;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    // Child classes set type of activity
    protected string _type;

    // Constructor
    public Activity()
    {
        _date = DateTime.Today;
    }

    public int AskDuration()
    {
        Console.Write($"How many minutes did you {_type}: ");
        return Int32.Parse(Console.ReadLine());
    }

    // Abstract method to calculate distance
    public abstract double CalcDistance();

    /* Speed and Pace can be calculated the same way
    for each type of Activity. Abstraction not needed. */

    // Method to calculate speed
    public double CalcSpeed()
    {
        return (_distance / _duration) * 60;
    }

    // Method to calculate pace
    public double CalcPace()
    {
        return _duration / _distance;
    }

    // Method to return summary of activity
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_duration} min):" +
        $"\n\tDistance - {_distance} miles " +
        $"\n\tSpeed - {Math.Round(_speed,2)} miles per hour " +
        $"\n\tPace - {Math.Round(_pace,2)} min per mile";
    }
}