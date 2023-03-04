using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Select menu option: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                BreathingActivity b1 = new BreathingActivity("Breathing");
                b1.RunActivity();
                Console.Clear();
            } else if (choice == "2") {
                ReflectActivity r1 = new ReflectActivity("Reflecting");
                r1.RunActivity();
                Console.Clear();
            } else if (choice == "3") {
                ListActivity l1 = new ListActivity("Listing");
                l1.RunActivity();
                Console.Clear();
            } else if (choice == "4") {
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
    }
}