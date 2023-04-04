using System;

public class Run : Activity
{
    // No private member variables for this class

    // Constructor
    public Run()
    {
        _type = "Run";
        _duration = AskDuration();
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
    }

    // Override distance method
    public override double CalcDistance()
    {
        /* Other than, stride length and steps per minute, I 
        don't know how to calculate distance for running. */

        // Get distance from user (Makes more sense)
        Console.Write("How many miles did you run? ");
        return Double.Parse(Console.ReadLine());
    }
}