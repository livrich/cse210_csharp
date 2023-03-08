using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _bonusPoints;
    private int _repsCompleted;
    private int _totalRepetitions;

    // Constructor
    public ChecklistGoal(string name, string description, int points, 
    int bonusPoints, int totalReps): base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _repsCompleted = 0;
        _totalRepetitions = totalReps;
    }

    // Methods
    public override bool RecordGoal()
    {
        return true;
    } 

    public int GetRepsCompleted()
    {
        return _repsCompleted;
    }

    public int GetTotalReps()
    {
        return _totalRepetitions;
    }

    public void CheckCompleted()
    {
        if (_repsCompleted == _totalRepetitions)
        {
            _isCompleted = true;
        }
        else
        {
            _isCompleted = false;
        }
    }
}