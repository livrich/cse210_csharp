using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _bonusPoints;

    // Constructor
    public ChecklistGoal(string name, string description, int points, 
    int bonusPoints) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
    }

    // Methods
    public override bool RecordGoal()
    {
        return true;
    }   
}