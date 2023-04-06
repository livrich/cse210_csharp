using System;

public abstract class Goal
{
    // Attributes
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected string _checkBox;

    // Constructor
    public Goal(string type, string name, string description, int points, 
    bool isComplete = false, string checkBox = "[ ]")
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _checkBox = checkBox;
    }

    // Abstract method to report goal as finished
    public abstract bool SetComplete();

    // Abstract method to return string summary for file
    public abstract string GetFileSummary();

    // Abstract method to return string to display to screen
    public abstract string GetDisplaySummary();

    // Method to mark box of completed goals
    public string MarkCheckBox()
    {
        return _checkBox = "[X]";
    }

    // Method to get name of goal
    public string GetName()
    {
        return _name;
    }

    // Method to get status of complete
    public bool GetCompleted()
    {
        return _isComplete;
    }

    // Method to get points
    public int GetPoints()
    {
        return _points;
    }
}