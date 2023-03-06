using System;

public abstract class Shape 
{
    // Attribute
    private string _color;

    // Constructor that requires color to be initialized.
    public Shape(string color)
    {
        _color = color;
    }

    // Method to access private _color variable.
    public string GetColor()
    {
        return _color;
    }

    // Method to set _color variable.
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method that child classes will override.
    public abstract double GetArea();
}