using System;

public class Swim : Activity
{
    private int _laps;

    // Constructor
    public Swim(int duration, int laps):
    base (duration)
    {
        _laps = laps;
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
        _type = "Swim";
    }

    // Override distance method
    public override double CalcDistance()
    {
        // Calculate distance in miles
        return _laps * 50 / 1000 * 0.62;
    }

    // Override speed method
    public override double CalcSpeed()
    {
        return (_distance / _duration) * 60;
    }

    // Override pace method
    public override double CalcPace()
    {
        return _duration / _distance;
    }
}