using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goalsList = new List<string>();
        LoadFile();

        while (true)
        {
            DisplayMainMenu();
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            // Create new goal
            if (choice == "1")
            {
                while (true)
                {
                    DisplayGoalMenu();
                    Console.Write("Select goal type (by number): ");
                    string goalType = Console.ReadLine();

                    // Create simple goal
                    if (goalType == "1") 
                    {
                        Console.WriteLine("Simple");
                        // Ask questions about goal
                        // Make goal
                        // Add goal to list
                        break;
                    } 
                    // Create eternal goal
                    else if (goalType == "2") 
                    {
                        Console.WriteLine("Eternal");
                        break;
                    } 
                    // Create checklist goal
                    else if (goalType == "3") 
                    {
                        Console.WriteLine("Checklist");
                        break;
                    } 
                    // Invalid input error message
                    else 
                    {
                        Console.WriteLine("That was not a valid option.");
                    }
                }
            } 
            // Display list of goals
            else if (choice == "2")
            {
                Console.WriteLine("List Goals");
            } 
            // Record progress/completion of goal
            else if (choice == "3")
            {
                Console.WriteLine("Record");
            } 
            // Save file
            else if (choice == "4")
            {
                SaveFile("goals.txt", goalsList);
                Console.WriteLine("File saved successfully.");
            } 
            // Exit program
            else if (choice == "5")
            {
                System.Environment.Exit(0);
            } 
            // Invalid input error message
            else 
            {
                Console.WriteLine("That was not a valid option.");
            }
        }
        

        void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Quit");
        }

        void DisplayGoalMenu()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
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