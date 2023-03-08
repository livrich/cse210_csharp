using System;

public abstract class Goal
{
    // Attributes
    private string _name;
    private string _description;
    private int _points;
    protected bool _isCompleted;
    private string _checkBox;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
        _checkBox = "[ ]";
    }

    // Methods
    public bool GetCompleted()
    {
        return _isCompleted;
    }    
    
    public void SetCompleted(bool state)
    {
        _isCompleted = state;
    }
    
    public string GetCheckBox()
    {
        return _checkBox;
    }

    public abstract bool RecordGoal();

    public string CheckBox()
    {
        return _checkBox = "[X]";
    }
}