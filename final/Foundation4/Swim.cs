using System;

public class Swim : Activity
{
    private int _laps;

    // Constructor
    public Swim(int duration):
    base (duration)
    {
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
        _type = "Swim";
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