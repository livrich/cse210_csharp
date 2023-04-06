using System;

public class SimpleGoal : Goal
{
    // All attributes are inherited

    // Constructor
    public SimpleGoal(string type, string name, string description, int points, 
    bool isComplete = false, string checkBox = "[ ]") 
    : base(type, name, description, points, isComplete, checkBox)
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

    // Override method that is not needed for this class.
    // (Simple goal can only be completed once.)
    // Other two child classes need.
    public override int IncreaseRepetitions()
    {
        return 0;
    }

    // Override method that is not needed for this class.
    // (Simple goal can only be completed once.)
    // Other two child classes need.
    public override int GetRepetitions()
    {
        return 0;
    }
}