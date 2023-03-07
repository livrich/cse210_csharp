using System;

public class EternalGaol : Goal
{
    // Attributes

    // Constructor
    public EternalGaol(string name, string description, int points) 
    : base(name, description, points)
    {

    }

    // Methods
    public override bool RecordGoal()
    {
        return true;
    }   
}