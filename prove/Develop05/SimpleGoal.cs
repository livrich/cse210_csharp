using System;

public class SimpleGoal : Goal
{
    // Attributes

    // Constructor
    public SimpleGoal(string type, string name, string description, int points) 
    : base(type, name, description, points)
    {

    }

    // Methods
    public override bool SetComplete()
    {
        return _isComplete = true;
    }

    public override string GetFileSummary()
    {
        return $"{_type}:{_name},{_description},{_points},{_isComplete},{_checkBox}";
    }

    public override string GetDisplaySummary()
    {
        return $"{_checkBox} {_name} ({_description})";
    }
}