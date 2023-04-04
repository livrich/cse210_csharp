using System;

public class Swim : Activity
{
    private int _laps;

    // Constructor
    public Swim()
    {
        _type = "Swim";
        _duration = AskDuration();
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
    }

    // Override distance method
    public override double CalcDistance()
    {
        // Get distance from user
        Console.Write("How many laps did you swim? ");
        _laps = Int32.Parse(Console.ReadLine());

        // Calculate distance in miles
        return _laps * 50 / 1000 * 0.62;
    }
}