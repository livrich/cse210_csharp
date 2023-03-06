using System;

class Program
{
    static void Main(string[] args)
    {
        // List of Shape class objects
        List<Shape> shapes = new List<Shape>();
        
        // Instance of square class
        Square s1 = new Square(5, "red");
        // Add shape to list
        shapes.Add(s1);

        // Instance of rectangle class
        Rectangle s2 = new Rectangle(5, 4, "blue");
        shapes.Add(s2);

        // Instance of circle class
        Circle s3 = new Circle(5, "yellow");
        shapes.Add(s3);

        // Get color and area for each shape in list.
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            // Display information to screen.
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}