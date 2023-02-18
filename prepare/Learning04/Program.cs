using System;

class Program
{
    static void Main(string[] args)
    {
        // Create and display base class
        Assignment assignment1 = new Assignment("Olivia", "Math");
        Console.WriteLine(assignment1.GetSummary());

        // Create and display derived math class
        MathAssignment math1 = new MathAssignment("Jenny", "Calc", "4.2", "12-20");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        // Create and display derived writing class
        WritingAssignment write1 = new WritingAssignment("Lex", "English 101", "Thoughts on Book");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}