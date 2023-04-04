using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing Swim/Activity Classes
        Swim swim = new Swim();
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine();

        // Testing Bike Class
        Bike bike = new Bike();
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine();

        // Testing Run Class
        Run run = new Run();
        Console.WriteLine(run.GetSummary());
        Console.WriteLine();
    }
}