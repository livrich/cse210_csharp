using System;

public class Bike : Activity
{
    // No private member variables for this class

    // Constructor
    public Bike()
    {
        _type = "Bike";
        _duration = AskDuration();
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
    }

    // Override distance method
    public override double CalcDistance()
    {
        /* Other than tire rotations, I don't know how
        to calculate distance for biking. */

        // Get distance from user (Makes more sense)
        Console.Write("How many miles did you bike? ");
        return Double.Parse(Console.ReadLine());
    }
}