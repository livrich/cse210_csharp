using System;

class Program
{
    static void Main(string[] args)
    {
        // Call stand alone functions
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        double numberSqr = SquareNumber(favNumber);
        DisplayResult(name, numberSqr);
    }

    // Display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Ask user for their name
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Ask user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Square user's favorite number
    static double SquareNumber(int number)
    {
        double square = Math.Pow(number, 2);
        return square;

        /* Could have written as:
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        */
    }

    // Display message with user's name and number squared
    static void DisplayResult(string name, double number)
    {
        Console.WriteLine($"{name}, your favorite number squared is {number}");
    }
}