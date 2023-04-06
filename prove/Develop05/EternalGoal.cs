using System;

public class EternalGoal : Goal
{
    // Attribute
    int _repetitions;

    // Constructor
    public EternalGoal(string type, string name, string description, int points, 
    bool isComplete = false, string checkBox = "[ ]", int repetitions = 0) 
    : base(type, name, description, points)
    {
        _repetitions = repetitions;
    }

    // Override method to leave complete as false
    // Eternal goals are never finished
    public override bool SetComplete()
    {
        return _isComplete;
    }

    // Override method to return summary for file saving
    public override string GetFileSummary()
    {
        return $"{_type}:{_name},{_description},{_points},{_isComplete},{_checkBox},{_repetitions}";
    }

    // Override method to return summary to display to screen
    public override string GetDisplaySummary()
    {
        return $"{_checkBox} {_name} ({_description})";
    } 

    // Method to count how many times goal has been completed
    public override int IncreaseRepetitions()
    {
        return _repetitions += 1;
    }

    // Method to get number of times goal has been completed
    public override int GetRepetitions()
    {
        return _repetitions;
    }
}