using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string choice;
        do
        {
            choice = DisplayMenu();
            if (choice == "1")
            {
                Console.WriteLine("Write stuff");
                Prompt myPrompt = new Prompt();
                myPrompt.GeneratePrompt();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Display stuff");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Load stuff");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Save stuff");
            }
            else
            {
                continue;
            }
        } while (choice != "5");
    }

    static string DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        return Console.ReadLine();
    }
}