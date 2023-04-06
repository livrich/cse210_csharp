using System;

class Program
{
    static void Main(string[] args)
    {
        // List of goals as Goal object
        List<Goal> goals = new List<Goal>();
        // List of goals as strings
        List<string> stringGoals = new List<string>();

        // Load file when program opens
        LoadFile();

        // Variable to keep track of total points
        int totalPoints = 0;
        
        // Variables that will be used to create goals
        string name;
        string description;
        int points;
        int repetitions = 0;
        int bonusPoints = 0;

        while (true)
        {
            // Reset total before calculating again
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
                    // Create eternal goal
                    else if (goalType == "2") 
                    {
                        AskQuestions(false);
                        EternalGoal g2 = new EternalGoal("EternalGoal", name, description, points);
                        goals.Add(g2);
                        break;
                    } 
                    // Create checklist goal
                    else if (goalType == "3") 
                    {
                        AskQuestions(true);
                        ChecklistGoal g3 = new ChecklistGoal("ChecklistGoal", name, description, points, bonusPoints, repetitions);
                        goals.Add(g3);
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
                // Variable to display line numbers
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
                // Intro message, then display name of goals
                Console.WriteLine("The goals are:");
                // Variable to number goals
                int goalNum = 1;
                foreach (Goal g in goals)
                {
                    Console.WriteLine($"{goalNum}. {g.GetName()}");
                    goalNum ++;
                }

                // Pick goal that will be recorded
                Console.Write("Which goal did you accomplish? ");
                int finished = Int32.Parse(Console.ReadLine());
                // Code count starts at 0; thus, need to subtract 1.
                finished -= 1;

                // Check if goal has already been finished
                if (goals[finished].GetCompleted() == true)
                {
                    Console.WriteLine("You have already finished that goal.");
                }
                else
                {
                    // Eternal goals only need repetitions increased. (Never finished)
                    if (goals[finished].GetGoalType() == "EternalGoal")
                    {
                        goals[finished].IncreaseRepetitions();

                        // Message about earning points
                        Console.WriteLine($"Congratulations you have earned {goals[finished].GetPoints()} points!");

                    }
                    else if (goals[finished].GetGoalType() == "ChecklistGoal")
                    {
                        goals[finished].IncreaseRepetitions();
                        // SetComplete for checklist will determine if goal has
                        // been completed enough times to have finished entire goal.
                        goals[finished].SetComplete();
                        // MarkCheckBox checks if goal is finished and returns
                        // appropriate type of box.
                        goals[finished].MarkCheckBox();

                        // Determining points earned
                        int earnedPoints = 0;
                        int repPoints = goals[finished].GetPoints();
                        // How I came up with accessing _bonusPoint variable.
                        // Sine I'm working with List<Goal> I can't access child
                        // class attributes or methods.
                        string[] pieces = goals[finished].GetFileSummary().Split(':', ',');
                        int bonus = Int32.Parse(pieces[4]);

                        // Finalizing points earned
                        if (goals[finished].GetCompleted() == false)
                        {
                            earnedPoints += repPoints;
                        }
                        else
                        {
                            earnedPoints += (repPoints + bonus);
                        }
                        
                        // Message about points earned
                        Console.WriteLine($"Congratulations you have earned {earnedPoints} points!");
                    }
                    else // "SimpleGoal"
                    {
                        // SetComplete will always set to true
                        goals[finished].SetComplete();
                        goals[finished].MarkCheckBox();

                        // Message about earning points
                        Console.WriteLine($"Congratulations you have earned {goals[finished].GetPoints()} points!");
                    }
                    // Message about current point total
                    totalPoints = 0;
                    int currentPoints = CalcTotalPoints();
                    Console.WriteLine($"You now have {currentPoints} points.");

                    // // Message to inform user task was completed (No longer used)
                    // Console.WriteLine("Progress has been recorded");
                }
            } 
            // Save file
            else if (choice == "4")
            {
                foreach (Goal g in goals)
                {
                    // Need string version of goals
                    string str = g.GetFileSummary();
                    // Add string representations to list
                    stringGoals.Add(str);
                    // SaveFile requires name of file and List<string>
                    SaveFile("goals.txt", stringGoals);
                }
                // Message to inform user task was completed
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
        

        // Function to display main menu options
        void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Quit");
        }

        // Function to display menu of goal types
        void DisplayGoalMenu()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
        }

        // Function to calculate total points earned
        int CalcTotalPoints()
        {
            foreach (Goal g in goals)
            {
                // Count points for completed simple goals
                if (g.GetGoalType() == "SimpleGoal" && g.GetCompleted() == true)
                {
                    totalPoints += g.GetPoints();
                }

                // Count points for eternal and checklist goal reps completed
                if (g.GetRepetitions() > 0)
                {
                    totalPoints += g.GetPoints() * g.GetRepetitions();
                }

                // Count points for checklist goal finish bonus
                if (g.GetGoalType() == "CheckListGoal" && g.GetCompleted() == true)
                {
                    // How I came up with accessing _bonusPoint variable.
                    // Sine I'm working with List<Goal> I can't access child
                    // class attributes or methods.
                    string[] pieces = g.GetFileSummary().Split(':', ',');
                    int bonus = Int32.Parse(pieces[4]);
                    totalPoints += bonus;
                }
            }
            return totalPoints;
        }

        // Function to display total points
        void DisplayTotalPoints()
        {
            Console.WriteLine($"\nYou have {totalPoints} points.");
        }

        // Function to get user input about goal being created
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

            // Only checklist goals will ask these extra questions
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

                // Split goal data into individual parts and
                // turn into appropriate type of goal.
                // Add Goal objects to goals list.
                if (type == "SimpleGoal")
                {
                    string[] pieces = data.Split(',');
                    string name = pieces[0];
                    string description = pieces[1];
                    int points = Int32.Parse(pieces[2]);
                    bool isComplete = bool.Parse(pieces[3]);
                    string checkBox = pieces[4];

                    SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, isComplete, checkBox);
                    goals.Add(simpleGoal);
                }
                else if (type == "EternalGoal")
                {
                    string[] pieces = data.Split(',');
                    string name = pieces[0];
                    string description = pieces[1];
                    int points = Int32.Parse(pieces[2]);
                    bool isComplete = bool.Parse(pieces[3]);
                    string checkBox = pieces[4];
                    int repetitions = Int32.Parse(pieces[5]);

                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points, 
                        isComplete, checkBox, repetitions);
                    goals.Add(eternalGoal);
                }
                else
                {
                    string[] pieces = data.Split(',');
                    string name = pieces[0];
                    string description = pieces[1];
                    int points = Int32.Parse(pieces[2]);
                    int bonusPoints = Int32.Parse(pieces[3]);
                    bool isComplete = bool.Parse(pieces[4]);
                    string checkBox = pieces[5];
                    int repsCompleted = Int32.Parse(pieces[6]);
                    int totalReps = Int32.Parse(pieces[7]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, 
                        bonusPoints, totalReps, repsCompleted, isComplete, checkBox);
                    goals.Add(checklistGoal);
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