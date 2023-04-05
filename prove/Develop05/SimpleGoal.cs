using System;

public class SimpleGoal : Goal
{
    // All attributes are inherited

    // Constructor
    public SimpleGoal(string type, string name, string description, int points) 
    : base(type, name, description, points)
    {

    }

    // Override method to set state of completed as true
    public override bool SetComplete()
    {
        return _isComplete = true;
    }

    // Override method to return summary for file saving
    public override string GetFileSummary()
    {
        return $"{_type}:{_name},{_description},{_points},{_isComplete},{_checkBox}";
    }

    // Override method to return summary to display to screen
    public override string GetDisplaySummary()
    {
        return $"{_checkBox} {_name} ({_description})";
    }
}