using System;

class Program
{
    static void Main(string[] args)
    {
        // Get grade percentage from user
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        // Convert input from string to double
        // Round input to whole number (must be double to round)
        double doublePercent = Math.Round(Single.Parse(answer));
        // Convert double to int to save memory space
        int percent = Convert.ToInt32(doublePercent);

        // Default letter grade is F
        string letter = "F";
        
        // Loop so we can break out of if statements
        do
        {
            // Check letter grade in increments of 10

            // if true, check next if statement.
            // if next if statement is false, set 'letter'
            // to current grade letter and break loop.
            if (percent >= 60)
            {
                if (percent >= 70)
                {
                    if (percent >= 80)
                    {
                        if (percent >= 90)
                        {
                            letter = "A";
                            break;
                        }
                        letter = "B";
                        break;
                    }
                    letter = "C";
                    break;
                }
                letter = "D";
            }
        } while (false);

        // Divide percent by 10 to get remainder
        int remainder = percent % 10;
        // Default sign is nothing
        string sign = "";

        // Check if letter grade should have a '+'
        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        // Check if letter grade should have a '-'
        else if (remainder < 3 && letter != "F")
        {
            sign = "-";
        }

        // Display letter grade to terminal
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if grade is enough to pass or fail
        // Display appropriate message to terminal
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed... :(");
        }
    }
}