using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", "3", "5", "6");
        Scripture s1 = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own \n" +
        "understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // Clear Console then display reference with text.
        Console.Clear();
        Console.WriteLine($"{r1.FormatReference()} {s1.GetText()}");

        // Ask user to press enter or quit.
        string response = "";
        Console.Write("\nPress enter to continue or type 'quit' to exit: ");
        response = Console.ReadLine();

        // Loop to keep program running until exit conditions reached.
        do
        {
            // Clear console between each time scripture is displayed.
            Console.Clear();

            // Exit program it user types quit.
            if (response == "quit")
            {
                System.Environment.Exit(0);
            }
            else 
            {   
                // Get random number for range
                Random rnd = new Random();
                // Between 2 and 5 words will be hidden each time.
                int number = rnd.Next(2, 6);

                // Hide x words based on random number from above.
                for (int i = 0; i < number; i++)
                {
                    s1.HideWord();
                }
                //Display scripture reference.
                Console.Write($"{r1.FormatReference()} ");
                // Display text of scripture.
                s1.DisplayList();
                
                // Check if all words are hidden
                bool hidden = s1.CheckIfAllHidden();
                if (hidden == false)
                {
                    // If not all words are hidden, ask user press
                    // enter again or type quit to exit.
                    Console.Write("\n\nPress enter to continue or type 'quit' to exit: ");
                    response = Console.ReadLine();
                }
                else
                {
                    // If all words are hidden, exit program.
                    System.Environment.Exit(0);
                }
            }
        } while (response != "quit");


        // These are 2 different scriptures I used to test program.

        // Reference r1 = new Reference("Proverbs", "3", "5", "6");
        // Scripture s1 = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own \n" +
        // "understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // Reference r1 = new Reference("Luke", "1", "37");
        // Scripture s1 = new Scripture("For with God nothing shall be impossible.");
    }
    
}