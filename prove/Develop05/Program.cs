using System;

class Program
{
    static void Main(string[] args)
    {
        // List of goals as Goal object
        List<Goal> goals = new List<Goal>();
        // List of goals as strings
        List<string> stringGoals = new List<string>();

        // Testing simple goal
        // SimpleGoal sg = new SimpleGoal("SimpleGoal", "Paint", "Finish painting of bridge", 200);
        // Console.WriteLine(sg.GetDisplaySummary());
        // Console.WriteLine(sg.GetFileSummary());
        // goals.Add(sg);
        // sg.SetComplete();
        // sg.MarkCheckBox();
        // Console.WriteLine(sg.GetDisplaySummary());
        // Console.WriteLine(sg.GetFileSummary());
        // goals.Add(sg);


        // Load file when program opens
        LoadFile();

        // Variable to keep track of total points
        int totalPoints = 0;
        
        // Variables that will be used to create goals
        string name;
        string description;
        int points;
        int repetitions;
        int bonusPoints;

        while (true)
        {
            totalPoints = 0;
            CalcTotalPoints();
            DisplayTotalPoints();
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
                        SimpleGoal g1 = new SimpleGoal("SimpleGoal", name, description, points);
                        // Add goal to list of Goal objects
                        goals.Add(g1);
                        break;
                    } 
                //     // Create eternal goal
                //     else if (goalType == "2") 
                //     {
                //         // Ask questions about goal
                //         AskQuestions(false);
                //         // Make goal
                //         EternalGaol g2 = new EternalGaol(name, description, points);
                //         // Add goal to list. Need string representation.
                //         // string stringLine = $"EternalGoal:{name},{description},{points}";
                //         goals.Add(g2);
                //         break;
                //     } 
                //     // Create checklist goal
                //     else if (goalType == "3") 
                //     {
                //         // Ask questions about goal
                //         AskQuestions(true);
                //         // Make goal
                //         ChecklistGoal g3 = new ChecklistGoal(name, description, points, bonusPoints, repetitions);
                //         // Add goal to list. Need string representation.
                //         // string stringLine = $"ChecklistGoal:{name},{description},{points},{bonusPoints},{g3.GetRepsCompleted()},{g3.GetTotalReps()}";
                //         goals.Add(g3);
                //         break;
                //     } 
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
                int lineNum = 1;
                foreach (Goal g in goals)
                {
                    Console.WriteLine($"{lineNum}. {g.GetDisplaySummary()}");
                    lineNum ++;
                }
            } 
            // Record progress/completion of goal
            else if (choice == "3")
            {
                Console.WriteLine("Record");
                Console.WriteLine("The goals are:");
                int lineNum = 1;
                foreach (Goal g in goals)
                {
                    Console.WriteLine($"{lineNum}. {g.GetName()}");
                    lineNum ++;
                }
                Console.Write("Which goal did you accomplish? ");
                int finished = Int32.Parse(Console.ReadLine());

                // Will need to augment for other classes than just simple
                goals[finished - 1].SetComplete();
                goals[finished - 1].MarkCheckBox();

                // Message to inform user task was completed
                Console.WriteLine("Progress has been recorded");
            } 
            // Save file
            else if (choice == "4")
            {
                foreach (Goal g in goals)
                {
                    string str = g.GetFileSummary();
                    stringGoals.Add(str);
                    SaveFile("goals.txt", stringGoals);
                }
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

        int CalcTotalPoints()
        {
            foreach (Goal g in goals)
            {
                if (g.GetCompleted() == true)
                {
                    totalPoints += g.GetPoints();
                }
            }
            return totalPoints;
        }

        void DisplayTotalPoints()
        {
            Console.WriteLine($"\nYou have {totalPoints} points.");
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

        // Function to load each line of file to list.
        // Each string line will be converted back to Goal object.
        void LoadFile()
        {
            string[] fromFile = File.ReadAllLines("goals.txt");

            foreach (string line in fromFile)
            {
                // Split type of goal from goal data
                string[] parts = line.Split(':');
                string type = parts[0];
                string data = parts[1];

                // Split goal data into individual parts
                // Will most likely need if statement for splitting farther
                // Will need more for other goals than just simple goal
                string[] pieces = data.Split(',');
                string name = pieces[0];
                string description = pieces[1];
                int points = Int32.Parse(pieces[2]);
                bool isComplete = bool.Parse(pieces[3]);
                string checkBox = pieces[4];

                if (type == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, isComplete, checkBox);
                    goals.Add(simpleGoal);
                }
            }
        }

        // Function to save list to text file.
        void SaveFile(string file, List<string> list)
        {
            File.WriteAllLines(file, list);
        }
    }
}