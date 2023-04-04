using System;

public class Bike : Activity
{
    // No private member variables for this class

    // Constructor
    public Bike(int duration):
    base (duration)
    {
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
        _type = "Bike";
    }

    // Override distance method
    public override double CalcDistance()
    {
        /* Other than tire rotations, I don't know how
        to calculate distance for biking. */

        // Get distance gone from user
        Console.Write("How far did you bike? ");
        double distance = Double.Parse(Console.ReadLine());
        return distance;
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