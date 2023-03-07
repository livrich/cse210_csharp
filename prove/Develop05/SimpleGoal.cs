using System;

public class SimpleGoal : Goal
{
    // Attributes

    // Constructor
    public SimpleGoal(string name, string description, int points) 
    : base(name, description, points)
    {

    }

    // Methods
    public override bool RecordGoal()
    {
        return true;
    }
}