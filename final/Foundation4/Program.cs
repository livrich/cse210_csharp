using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing Swim/Activity Classes
        Swim swim = new Swim(30, 40);
        Console.WriteLine($"{swim.GetSummary()}");
    }
}