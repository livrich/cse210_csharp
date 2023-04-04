using System;

class Program
{
    static void Main(string[] args)
    {
        // List to store activities
        List<Activity> activities = new List<Activity>();
        
        // Create instance of Swim class and add to list
        Swim swim = new Swim();
        activities.Add(swim);

        // Create instance of Bike class and add to list
        Bike bike = new Bike();
        activities.Add(bike);

        // Create instance of Run class and add to list
        Run run = new Run();
        activities.Add(run);

        // Display each Activity in activities list
        foreach (Activity a in activities)
        {
            // Call summary method to display Activity
            Console.WriteLine(a.GetSummary());
            // Print blank line between Activities
            Console.WriteLine();
        }
    }
}