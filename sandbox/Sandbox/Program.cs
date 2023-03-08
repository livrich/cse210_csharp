using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "Thing:one,two,three";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(':', ',');
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine(word);
        }
            
    }
}