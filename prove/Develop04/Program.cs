using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> allCounts = new List<string>();
        LoadActivityCount();
        
        string breath = allCounts[0];
        int breathCount = Int32.Parse(breath);

        string reflect = allCounts[1];
        int reflectCount = Int32.Parse(reflect);
        
        string list = allCounts[2];
        int listCount = Int32.Parse(list);

        while (true)
        {
            DisplayMenu();
            Console.Write("Select menu option: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                BreathingActivity b1 = new BreathingActivity("Breathing");
                b1.RunActivity();
                breathCount += 1;
                Console.Clear();
            } else if (choice == "2") {
                ReflectActivity r1 = new ReflectActivity("Reflecting");
                r1.RunActivity();
                reflectCount += 1;
                Console.Clear();
            } else if (choice == "3") {
                ListActivity l1 = new ListActivity("Listing");
                l1.RunActivity();
                listCount += 1;
                Console.Clear();
            } else if (choice == "4") {
                // Needed to replace list values instead of adding values to end of list.
                ReplaceList(allCounts, 0, breathCount.ToString());
                ReplaceList(allCounts, 1, reflectCount.ToString());
                ReplaceList(allCounts, 2, listCount.ToString());
                // Display how many times a certain activity has been performed.
                Console.WriteLine($"You have done the Breathing Activity {breathCount} time(s).");
                Console.WriteLine($"You have done the Reflecting Activity {reflectCount} time(s).");
                Console.WriteLine($"You have done the Listing Activity {listCount} time(s).");
                // Save activity counts to file.
                SaveActivityCount("activityCounts.txt", allCounts);
                // Exit program.
                System.Environment.Exit(0);
            } else {
                Console.WriteLine("That was not a valid option.");
            }
        }
        
        void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
        }

        // Function to add items to a list.
        void AddToList(List<string> list, string item)
        {
            list.Add(item);
        }

        // Function to replace value of list at certain index.
        void ReplaceList(List<string> list, int index, string item)
        {
            list[index] = item;
        }

        // Method to load file to list.
        void LoadActivityCount()
        {
            string[] fromFile = File.ReadAllLines("activityCounts.txt");
            
            // Add each line to allCounts so they can be displayed or saved later.
            foreach (string line in fromFile)
            {
                AddToList(allCounts, line);
            }
        }

        // Method to save list to text file.
        void SaveActivityCount(string file, List<string> counts)
        {
            File.WriteAllLines(file, counts);
        }
    }
}