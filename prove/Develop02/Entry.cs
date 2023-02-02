using System;

public class Entry
{
    // Initialize attributes for this class.
    public string _prompt;
    public string _date = DateTime.Today.ToString("D");
    public string _entry;
    

    /* Don't need this method anymore.

    // Method that displays today's date to screen.
    public void DisplayDate()
    {
        // "D" is long date formatting. Means date
        // will display like: Monday, June 6, 2017
        _date = DateTime.Today.ToString("D");
        Console.WriteLine($"Date: {_date}");
    }
    */
    
    // Method that calls Prompt class to get a random
    // prompt and display the prompt on screen.
    public void DisplayPrompt()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.GeneratePrompt();
        Console.WriteLine($"Prompt: {_prompt}");
    }

    // Method to get user input.
    // Should only be called after DisplayPrompt()
    // or similar so there is something to answer.
    public void GetWrittenResponse()
    {
        _entry = Console.ReadLine();
    }
}