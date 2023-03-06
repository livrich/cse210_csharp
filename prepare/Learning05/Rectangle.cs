using System;

public class Rectangle : Shape
{
    // Attributes
    private double _length;
    private double _width;

    // Constructor to initialize length and width.
    // Inherits _color from Shape class.
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override method from Shape class to return
    // correct area for rectangle.
    public override double GetArea()
    {
        return _length * _width;
    }
}