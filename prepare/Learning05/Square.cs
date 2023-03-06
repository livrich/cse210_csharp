using System;

public class Square : Shape
{
    // Attribute
    private double _side;

    // Constructor to initialize _side and inherit _color
    // from Shape base class.
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // Override GetArea method from base class to implement
    // area of square math result.
    public override double GetArea()
    {
        return _side * _side;
    }
}