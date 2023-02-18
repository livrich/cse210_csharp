using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Olivia", "Math");
        Console.WriteLine(assignment1.GetSummary());
    }
}