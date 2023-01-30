using System;

public class Prompt
{
    // There are no attributes for this class.

    // Method to read designated file and return list of strings.
    public List<string> ReadFile()
    {
        // Designated file where journal prompts are stored.
        // Need to have full file path.
        string file = @"C:\Users\olivi\OneDrive\Documents\Programming\CSE_210\cse210_csharp\prove\Develop02\prompts.txt";
        // Read text file line by line into list.
        List<string> lines = File.ReadAllLines(file).ToList();
        lines = lines.Skip(1).ToList();
        return lines;
    }

    // Method to randomly generate and return a string prompt.
    // Calls on ReadFile() method above to get list of prompts.
    public string GeneratePrompt()
    {
        // Get list of prompts by reading file with prompts.
        List<string> promptsList = ReadFile();
        
        // Get random number with Random class.
        Random rnd = new Random();
        // Min value is included, max value is not.
        int number = rnd.Next(0, 5);
        // Console.WriteLine(number);
        
        // Get specified prompt by index value.
        string prompt = promptsList[number];
        // Console.WriteLine(prompt);
        return prompt;
    }
}