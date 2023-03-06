using System;

public class Circle : Shape
{
    // Attribute
    private double _radius;

    // Constructor to initialize radius and 
    // inherit _color from Shape class.
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // Override method from Shape class to
    // return area of a circle.
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}