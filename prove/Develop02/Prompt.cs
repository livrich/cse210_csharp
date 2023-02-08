using System;

public class Prompt
{
    // Class attributes.
    // Type of prompt user wants.
    string _type;
    // Path of file for correct prompts.
    string _file;

     // Method to ask user what kind of journal prompt they want.
     // Returns number as string.
     public string PickPromptType()
    {
        Console.WriteLine("What kind of prompt would you like?");
        Console.WriteLine("1. Gratitude/Optimism");
        Console.WriteLine("2. Personal History");
        Console.WriteLine("3. Therapy");
        Console.Write("Enter number: ");
        string type = Console.ReadLine();
        return type;
    }
    
    // Method to read designated file and return list of strings.
    public List<string> ReadFile(string fileName)
    {
        // Read text file line by line into list.
        List<string> lines = File.ReadAllLines(fileName).ToList();
        lines = lines.Skip(1).ToList();
        return lines;
    }
   
    // Method to randomly generate and return a string prompt.
    // Calls on ReadFile() method above to get list of prompts.
    public string GeneratePrompt()
    {
        do
        {
            // Determine what kind of prompt user wants.
            _type = PickPromptType();
            
            if (_type == "1")
            {
                // Gratitude/Optimism Prompts.
                // Learned I should have relative path names.
                // Otherwise code will only work on my computer.
                _file = "GOprompts.txt";
            }
            else if (_type == "2")
            {
                // Personal History Prompts.
                _file = "PHprompts.txt";
            }
            else if (_type == "3")
            {
                // Therapy Prompts.
                _file = "Tprompts.txt";
            }
            else
            {
                // Display error message and continue loop so user
                // can enter valid input.
                Console.WriteLine("Error: invalid response");
                continue;
            } 
        } while (_type != "1" && _type != "2" && _type != "3");
        
        // Get list of prompts by reading file with prompts.
        List<string> promptsList = ReadFile(_file);
        
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