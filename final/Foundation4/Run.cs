using System;

public class Run : Activity
{
    // No private member variables for this class

    // Constructor
    public Run(int duration):
    base (duration)
    {
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
        _type = "Run";
    }

    // Override distance method
    public override double CalcDistance()
    {
        /* Other than, stride length and steps per minute, I 
        don't know how to calculate distance for running. */

        // Get distance from user (Makes more sense)
        Console.Write("How far did you run? Miles: ");
        double distance = Double.Parse(Console.ReadLine());
        return distance;
    }
}