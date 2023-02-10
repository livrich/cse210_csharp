using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Luke", "1", "37");
        Console.WriteLine($"{r1.FormatReference()}");

        Reference r2 = new Reference("Proverbs", "3", "5", "6");
        Console.WriteLine($"{r2.FormatReference()}");

    }
    
}