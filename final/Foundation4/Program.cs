using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing Swim/Activity Classes
        Swim swim = new Swim(30);
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine();

        // Testing Bike Class
        Bike bike = new Bike(40);
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine();

        // Testing Run Class
        Run run = new Run(60);
        Console.WriteLine(run.GetSummary());
        Console.WriteLine();
    }
}