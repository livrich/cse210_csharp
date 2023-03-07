using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        List<string> goalsList = new List<string>();
        LoadFile();

        while (true)
        {
            DisplayMenu();
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1"){
                Console.WriteLine("Create New Goal");
            } else if (choice == "2"){
                Console.WriteLine("List Goals");
            } else if (choice == "3"){
                SaveFile("goals.txt", goalsList);
                Console.WriteLine("File saved successfully.");
            } else if (choice == "4"){
                Console.WriteLine("Record");
            } else if (choice == "5"){
                System.Environment.Exit(0);
            } else {
                Console.WriteLine("That was not a valid option.");
            }
        }
        

        void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            // Console.WriteLine("4. Load Goals");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Quit");
        }

        // Function to add items to a list.
        void AddToList(List<string> list, string item)
        {
            list.Add(item);
        }

        // Function to load each line of file to list.
        void LoadFile()
        {
            string[] fromFile = File.ReadAllLines("goals.txt");

            foreach (string line in fromFile)
            {
                // goalsList.Add(line);
                AddToList(goalsList, line);
            }
        }

        // Function to save list to text file.
        void SaveFile(string file, List<string> list)
        {
            File.WriteAllLines(file, list);
        }
    }
}