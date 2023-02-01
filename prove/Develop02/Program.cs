using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> allEntries = new List<string>();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice;
        do
        {
            choice = DisplayMenu();
            if (choice == "1")
            {
                Console.WriteLine();
                Entry myEntry = new Entry();
                myEntry.DisplayDate();
                myEntry.DisplayPrompt();
                myEntry.GetWrittenResponse();
                AddToList(allEntries, myEntry._date);
                AddToList(allEntries, myEntry._prompt);
                AddToList(allEntries, myEntry._entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                int count = 0;
                foreach (string item in allEntries)
                {
                    Console.WriteLine(item);
                    count += 1;
                    if (count % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
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

    static void AddToList(List<string> list, string item)
    {
        list.Add(item);
    }
}