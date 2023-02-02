using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize list to store all parts of journal entry.
        // Could not figure out how to include in Entry class.
        // It would always replace the list with each new entry,
        // instead of adding to it.
        List<string> allEntries = new List<string>();

        // Create instance of Journal class to use in
        // choices 3 and 4.
        Journal journal = new Journal();
        // Name of text file for journal.
        journal._filename = "MyJournal.txt";

        // Display message.
        Console.WriteLine("Welcome to the Journal Program!");

        // Needed to initialize choice outside of loop.
        string choice;
        
        // Do while loop will run code once before checking condition.
        do
        {
            choice = DisplayMenu();
            // If user chose to write new entry.
            if (choice == "1")
            {
                // Blank line to make easier to read.
                Console.WriteLine();
                // Initialize instance of Entry class.
                Entry myEntry = new Entry();
                // Call methods to display text and get user input.
                myEntry.DisplayPrompt();
                myEntry.GetWrittenResponse();
                // Call function to store data in allEntries list.
                AddToList(allEntries, myEntry._date);
                AddToList(allEntries, myEntry._prompt);
                AddToList(allEntries, myEntry._entry);
            }
            // If user chose to display all entries in allEntries list.
            else if (choice == "2")
            {
                // Blank line to make it easier to read.
                Console.WriteLine();
                int count = 0;
                // Display each item in list on new line.
                foreach (string item in allEntries)
                {
                    Console.WriteLine(item);
                    count += 1;
                    // Print blank line after every 3 items 
                    // to separate individual entries.
                    if (count % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            // If user chose to load text file.
            else if (choice == "3")
            {
                // Line of code I could not get to work. (See Journal class.)
                // string[] fromFile = journal.LoadJournal(journal._filename);
                // Replacement line for above line.
                string[] fromFile = File.ReadAllLines(journal._filename);
                // Message to help user know something happened.
                Console.WriteLine("File loaded successfully.");
                
                // Add each line to allEntries so they can be displayed or saved later.
                foreach (string line in fromFile)
                {
                    AddToList(allEntries, line);
                }
            }
            // If user chose to save to text file.
            else if (choice == "4")
            {
                // Call method to save data in allEntries list to text file.
                journal.SaveJournal(allEntries, journal._filename);
                // Message to let user know something happened.
                Console.WriteLine("Successfully saved journal.");
            }
            // If user types anything besides 1-5, display message and
            // continue loop so user can enter valid input.
            else
            {
                Console.WriteLine("Error: Invalid choice. Please enter one of the numbers shown.");
                continue;
            }
        } while (choice != "5");
    }

    // Function to display menu options to screen and get user input.
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

    // Function to add items to a list.
    static void AddToList(List<string> list, string item)
    {
        list.Add(item);
    }
}