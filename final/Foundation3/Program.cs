using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Lecture l = new Lecture("How to Code", "Learn how to code", "June 6", "4:45 PM", "My House", "Me", 20);
        l.Summary();
    }
}