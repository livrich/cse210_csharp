using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // Create and display base class
        Event e = new Event("How to Cook", "Come learn how to cook", "April 24", "6:00 PM", "Salt Palace");
        e.Summary();

        Lecture l = new Lecture("How to Code", "Learn how to code", "June 6", "4:45 PM", "My House", "Me", 20);
    }
}