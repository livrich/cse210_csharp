using System;

public class ReflectActivity : Activity 
{
    // Attributes
    private string _introMessage;
    private string _prompt;

    // Constructor
    public ReflectActivity(string type) : base(type)
    {
        _introMessage = "\nThis activity will help you reflect on times in \n" +
            "your life when you have shown strength and resilience. \n" +
            "This will help you recognize the power you have and how \n" +
            "you can use it in other aspects of your life.";
        // _inMessage = "Breathe in...";
        // _outMessage = "Breathe out...";
    }

    // Methods
    private void DisplayIntro()
    {
        Console.WriteLine(_introMessage);
    }

    // Method that calls Prompt class to get a random
    // prompt and display the prompt on screen.
    public void DisplayPrompt()
    {
        Prompt prompt = new Prompt("Rprompts.txt");
        _prompt = prompt.GeneratePrompt();
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"-- {_prompt} --");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string proceed = Console.ReadLine();
    }


    public void RunActivity()
    {
        DisplayWelcome();
        DisplayIntro();
        PromptDurationTime();
        DisplayReady();
        DisplayDots(3);

        DisplayPrompt();

        // Breathe();

        DisplayWellDone();
        // DisplaySpinner(3);
        DisplayFinish();
        // DisplaySpinner(4);
    }
}