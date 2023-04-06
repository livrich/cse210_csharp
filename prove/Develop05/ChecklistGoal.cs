using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _bonusPoints;
    private int _repsCompleted;
    private int _totalRepetitions;

    // Constructor
    public ChecklistGoal(string type, string name, string description, int points, 
    int bonusPoints, int totalReps, int repsCompleted = 0, bool isComplete = false, string checkBox = "[ ]"): 
    base(type, name, description, points, isComplete, checkBox)
    {
        _bonusPoints = bonusPoints;
        _repsCompleted = repsCompleted;
        _totalRepetitions = totalReps;
    }

    // Override method to set state of completed as true
    // if repsCompleted = totalReps. (Else remains false)
    public override bool SetComplete()
    {
        if (_repsCompleted == _totalRepetitions)
        {
            return _isComplete = true;
        }
        else
        {
            return _isComplete;
        }
    }

    // Override method to return summary for file saving
    public override string GetFileSummary()
    {
        return $"{_type}:{_name},{_description},{_points},{_bonusPoints},{_isComplete},{_checkBox},{_repsCompleted},{_totalRepetitions}";
    }

    // Override method to return summary to display to screen
    public override string GetDisplaySummary()
    {
        return $"{_checkBox} {_name} ({_description}) -- Currently completed {_repsCompleted}/{_totalRepetitions}";
    } 

    // Method to count how many times goal has been completed
    public override int IncreaseRepetitions()
    {
        return _repsCompleted += 1;
    }

    // Method to get number of times goal has been completed
    public override int GetRepetitions()
    {
        return _repsCompleted;
    }
}