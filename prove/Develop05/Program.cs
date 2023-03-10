using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goalsList = new List<string>();
        LoadFile();

        string name;
        string description;
        int points;
        int repetitions = 0;
        int bonusPoints = 0;

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
                        // Ask questions about goal
                        AskQuestions(false);
                        // Make goal
                        SimpleGoal g1 = new SimpleGoal(name, description, points);
                        // Add goal to list. Need string representation.
                        string stringLine = $"{g1.CheckBox()},SimpleGoal:{name},{description},{points},{g1.GetCompleted()}";
                        goalsList.Add(stringLine);
                        break;
                    } 
                    // Create eternal goal
                    else if (goalType == "2") 
                    {
                        // Ask questions about goal
                        AskQuestions(false);
                        // Make goal
                        EternalGaol g2 = new EternalGaol(name, description, points);
                        // Add goal to list. Need string representation.
                        string stringLine = $"EternalGoal:{name},{description},{points}";
                        goalsList.Add(stringLine);
                        break;
                    } 
                    // Create checklist goal
                    else if (goalType == "3") 
                    {
                        // Ask questions about goal
                        AskQuestions(true);
                        // Make goal
                        ChecklistGoal g3 = new ChecklistGoal(name, description, points, bonusPoints, repetitions);
                        // Add goal to list. Need string representation.
                        string stringLine = $"ChecklistGoal:{name},{description},{points},{bonusPoints},{g3.GetRepsCompleted()},{g3.GetTotalReps()}";
                        goalsList.Add(stringLine);
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
                foreach (string line in goalsList)
                {
                    string[] parts = line.Split(':', ',');
                    foreach(var part in parts)
                    {
                        Console.WriteLine(part);
                    }
                }
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

        void AskQuestions(bool extra)
        {
            // Name of goal
            Console.Write("Name your goal: ");
            name = Console.ReadLine();
            // Description of goal
            Console.Write("Short description of goal: ");
            description = Console.ReadLine();
            // Points for completing goal
            Console.Write("Associated points: ");
            points = Int32.Parse(Console.ReadLine());

            if (extra)
            {
                // Num repetitions for checklist goal
                Console.Write("Repetitions to be completed for bonus: ");
                repetitions = Int32.Parse(Console.ReadLine());
                // Bonus points for completing checklist goal
                Console.Write("Bonus points for completion: ");
                bonusPoints = Int32.Parse(Console.ReadLine());
            }
        }

        void WriteToFile(string file, string line)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                outputFile.WriteLine(line); 
            }
        }

        // Function to load each line of file to list.
        void LoadFile()
        {
            string[] fromFile = File.ReadAllLines("goals.txt");

            foreach (string line in fromFile)
            {
                goalsList.Add(line);
            }
        }

        // Function to save list to text file.
        void SaveFile(string file, List<string> list)
        {
            File.WriteAllLines(file, list);
        }
    }
}