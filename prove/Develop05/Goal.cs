using System;

public abstract class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;
    private bool _completed;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    // Methods
    public abstract bool RecordGoal();

    public string CheckBox(List<bool> list, int index)
    {
        string checkBox = "[ ]";
        if (list[index] is true)
        {
            checkBox = "[X]";
        }
        return checkBox;
    }
}