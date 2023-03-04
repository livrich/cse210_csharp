using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // while (true)
        // {
        Console.Write("+");

        Thread.Sleep(1000);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        // }
        
    }
}