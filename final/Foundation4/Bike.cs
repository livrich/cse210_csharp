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

        // Get distance from user (Makes more sense)
        Console.Write("How far did you bike? Miles: ");
        double distance = Double.Parse(Console.ReadLine());
        return distance;
    }
}